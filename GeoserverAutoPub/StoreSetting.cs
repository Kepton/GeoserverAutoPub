using Model;
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
    public partial class StoreSetting : Form
    {
        public StoreSetting()
        {
            InitializeComponent();
        }

        private void StoreSetting_Load(object sender, EventArgs e)
        {
            if (SysParam.WordsSpaceSelected != null)
            {
                MessageBox.Show("请先选择工作区");
                return;

            }
            lbl_selectedworkspacename.Text = SysParam.WordsSpaceSelected.Name;

            string[] diarr = Directory.GetDirectories(SysParam.GeoserverDataPath + "workspaces\\" + SysParam.WordsSpaceSelected.Name, "*", SearchOption.TopDirectoryOnly);
            foreach (string item in diarr)
            {
                DirectoryInfo workspacedict = new DirectoryInfo(item);
                FileInfo[] files = workspacedict.GetFiles("datastore.xml");
                foreach (FileInfo file in files)
                {

                    com_storeslist.Items.Add("");
                }
            }
        }
    }
}
