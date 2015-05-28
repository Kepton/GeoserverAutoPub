using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            ShowMainWorkForm(null, "编辑", typeof(WorkSpaceSetting));
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

        }
    }
}
