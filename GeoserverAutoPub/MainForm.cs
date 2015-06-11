using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeoserverAutoPub
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_workspace_Click(object sender, EventArgs e)
        {
            ShowMainWorkForm(null, "WorkspaceSetting", typeof(WorkSpaceSetting));
        }
        public void ShowMainWorkForm(string sFixPath, string sCaption, Type formType)
        {
            Form Mr = null;
            foreach (Form pForm in Application.OpenForms)
            {
                if (pForm.Text == sCaption) //pForm is Check.frmCheckMain
                {
                    Mr = (Form)pForm;
                    break;
                }
            }

            if (Mr == null)
            {
                Mr = (Form)Activator.CreateInstance(formType);
                Mr.TopLevel = false;
                Mr.FormBorderStyle = FormBorderStyle.None;
                Mr.WindowState = FormWindowState.Maximized;
                //Mr.MdiParent = this;
                Mr.Parent = panWorking;
                Mr.Text = sCaption;
                Mr.Show();
            }
            else
            {
                panWorking.Controls.Clear();
                panWorking.Dock = DockStyle.Fill;
                Mr.WindowState = FormWindowState.Maximized;
                Mr.Dock = DockStyle.Fill;
                Mr.Parent = panWorking;
                Mr.Show();
                Mr.Focus();
            }
        }


        private void btn_Store_Click(object sender, EventArgs e)
        {
            ShowMainWorkForm(null, "StoreSetting", typeof(StoreSetting));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SysParam.MinX = ConfigurationSettings.AppSettings["MinX"];
            SysParam.MinY = ConfigurationSettings.AppSettings["MinY"];
            SysParam.MaxX = ConfigurationSettings.AppSettings["MaxX"];
            SysParam.MaxY = ConfigurationSettings.AppSettings["MaxY"];
            SysParam.ZBX = ConfigurationSettings.AppSettings["ZBX"];

            SysParam.DataSource = ConfigurationSettings.AppSettings["DataSource"];
            SysParam.DataBase=ConfigurationSettings.AppSettings["DataBase"];
            SysParam.UserName = ConfigurationSettings.AppSettings["UserName"];
            SysParam.Password = ConfigurationSettings.AppSettings["Password"];

            SqlHelper.SQLHelper.connectionString = string.Format("server={0};uid={1};pwd={2};database={3}",SysParam.DataSource,SysParam.UserName,SysParam.Password,SysParam.DataBase);
            SysParam.ShapeSettingPath = Application.StartupPath + "\\ShapeSetting\\" + ConfigurationSettings.AppSettings["CurrentXZQH"] + "\\ShapeExportSetting.mdb";
            AccessHelper.AccessHelper.connstring = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + SysParam.ShapeSettingPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowMainWorkForm(null, "LayerSetting", typeof(LayerSetting));
        }
    }
}
