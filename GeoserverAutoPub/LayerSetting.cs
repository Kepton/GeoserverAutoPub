using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeoserverAutoPub
{
    public partial class LayerSetting : Form
    {
        public LayerSetting()
        {
            InitializeComponent();
        }

        private void btn_CreateShape_Click(object sender, EventArgs e)
        {
            CreateShape();
        }

        #region 生成prj文件
        private void BuildPrj(string fileName)
        {
            string str = "GEOGCS[\"GCS_WGS_1984\",DATUM[\"D_WGS_1984\",SPHEROID[\"WGS_1984\",6378137.0,298.257223563]],PRIMEM[\"Greenwich\",0.0],UNIT[\"degree\",0.0174532925199433],METADATA[\"World\",-180.0,-90.0,180.0,90.0,0.0,0.0174532925199433,0.0,1262]]";
            FileStream fs = new FileStream("D:\\Work Documents\\Test" + "\\" + fileName + ".prj", FileMode.Create, FileAccess.ReadWrite);
            byte[] bytes = Encoding.Default.GetBytes(str);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }
        #endregion

        private void CreateShape()
        {
            if (!File.Exists(SysParam.ShapeSettingPath))
            {
                MessageBox.Show("当前行政区划导出配置不存在！");
                return;
            }
            DataTable ExportData = new DataTable();
            ExportData = AccessHelper.AccessHelper.ExecuteDataTable("select * from exportsetting where enable='1'");
            foreach (DataRow dr in ExportData.Rows)
            {
                DataTable FieldTable = AccessHelper.AccessHelper.ExecuteDataTable("select * from exportfield where shapeTable='"+dr["ShapeTable"].ToString()+"'");
                StringBuilder select = new StringBuilder();
                if (dr["Type"].ToString().ToUpper() == "POINT")
                {
                    select.Append("select ptx,pty");

                }
                else if (dr["Type"].ToString().ToUpper() == "LINE")
                {
                    select.Append("select shape");
                }
                foreach (DataRow fielddr in FieldTable.Rows)
                {
                    select.Append("," + fielddr["SQLField"].ToString() + " as " + fielddr["ShapeField"].ToString());
                }

                select.Append(" from " + dr["SQLTable"].ToString());

                if (dr["Wherestr"].ToString().Trim() != "")
                {
                    select.Append(" where " + dr["Wherestr"].ToString());
                }

                DataTable sqltable = SqlHelper.SQLHelper.ExecuteDataTable(CommandType.Text, select.ToString(), null);

                if (dr["Type"].ToString().ToUpper() == "POINT")
                {
                    SaveShapeFile.SavePointShape sp = new SaveShapeFile.SavePointShape();
                    sp.ShapePath = "D:\\";
                    sp.ShapeFileName = dr["ShapeTable"].ToString();
                    int iFieldNum = FieldTable.Rows.Count;
                    sp.SetFiledNums(iFieldNum);
                    foreach (DataRow fielddr in FieldTable.Rows)
                    {
                        string sFileName = fielddr["ShapeField"].ToString();
                        byte iFieldType; byte iFieldSize; byte iFieldDec;
                        if (fielddr["Type"].ToString().ToUpper() == "STRING")
                        {
                            iFieldType = 0x43;
                        }
                        else
                        {
                            iFieldType = 0x15;
                        }
                        iFieldSize = byte.Parse(fielddr["Length"].ToString());
                        iFieldDec = byte.Parse(fielddr["xsdLength"].ToString());

                        sp.AddFileDefine(sFileName, iFieldType, iFieldSize, iFieldDec);
                    }
                    foreach (DataRow fielddr in FieldTable.Rows)
                    {
                        string shapeField = fielddr["ShapeField"].ToString();
                        foreach (DataRow sqldr in sqltable.Rows)
                        {
                            sp.SetFieldValue(shapeField, dr[shapeField].ToString());
                        }
                    }
                   
                    sp.Save();
                }
                else if (dr["Type"].ToString().ToUpper() == "LINE")
                {
                 
                }

            }
        }
    }
}
