using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GeoserverAutoPub
{
    public partial class LayerSetting : Form
    {
        private Thread mession = null;
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
                            iFieldType = 0x4e;
                        }
                        iFieldSize = byte.Parse(fielddr["Length"].ToString());
                        iFieldDec = byte.Parse(fielddr["xsdLength"].ToString());

                        sp.AddFileDefine(sFileName, iFieldType, iFieldSize, iFieldDec);
                    }

                    foreach (DataRow sqldr in sqltable.Rows)
                    {
                        foreach (DataRow fielddr in FieldTable.Rows)
                        {
                            string shapeField = fielddr["ShapeField"].ToString();
                            sp.SetFieldValue(shapeField, sqldr[shapeField].ToString());
                        }
                        if (sqldr["ptx"] == DBNull.Value || sqldr["pty"] == DBNull.Value)
                            continue;
                        //保存图形
                        sp.AddXY(Convert.ToDouble(sqldr["ptx"].ToString()), Convert.ToDouble(sqldr["pty"].ToString()));
                        sp.Update();
                    }
                   
                    sp.Save();
                }
                else if (dr["Type"].ToString().ToUpper() == "LINE")
                {
                    SaveShapeFile.SaveLineShape sa = new SaveShapeFile.SaveLineShape();
                    sa.ShapePath = "D:\\";
                    sa.ShapeFileName = dr["ShapeTable"].ToString();
                    int iFieldNum = FieldTable.Rows.Count;
                    sa.SetFiledNums(iFieldNum);

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
                            iFieldType = 0x4e;
                        }
                        iFieldSize = byte.Parse(fielddr["Length"].ToString());
                        iFieldDec = byte.Parse(fielddr["xsdLength"].ToString());

                        sa.AddFileDefine(sFileName, iFieldType, iFieldSize, iFieldDec);
                    }
                    foreach (DataRow sqldr in sqltable.Rows)
                    {
                        foreach (DataRow fielddr in FieldTable.Rows)
                        {
                            string shapeField = fielddr["ShapeField"].ToString();
                            sa.SetFieldValue(shapeField, sqldr[shapeField].ToString());
                        }
                        if (sqldr["shape"] == DBNull.Value)
                            continue;

                        byte[] bytes = (byte[])sqldr["Shape"];
                        HDLine.HDMeasureLine pLine = new HDLine.HDMeasureLine();
                        pLine.BytesToLine(bytes);

                        for (int i = 0; i < pLine.Parts.Count; i++)
                        {
                            List<HDLine.HDPoint> lstPoints = pLine.Parts[i];
                            List<SaveShapeFile.XYCoordinate> lstCooridnate = new List<SaveShapeFile.XYCoordinate>();
                            for (int j = 0; j < lstPoints.Count; j++)
                            {
                                SaveShapeFile.XYCoordinate item = new SaveShapeFile.XYCoordinate();
                                item.x = lstPoints[j].X;
                                item.y = lstPoints[j].Y;
                                lstCooridnate.Add(item);
                            }
                            sa.AddParts(lstCooridnate);
                        }
                      
                        sa.Update();
                    }
                    sa.Save();
                }

            }
        }

        private void Work()
        {
            DateTime lasttiem=DateTime.Parse( ConfigurationSettings.AppSettings["2015-06-01"]);
            if (DateTime.Now.DayOfWeek != lasttiem.DayOfWeek)//上一次导出时间与当前时间不在同一周  则重新导出
            {
 
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //mession=new Thread()
        }
    }
}
