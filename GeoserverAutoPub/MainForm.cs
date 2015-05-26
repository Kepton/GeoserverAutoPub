using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Model;
using System.Xml;

namespace GeoserverAutoPub
{
    public partial class MainForm : Form
    {
        List<Workspace> wslist = new List<Workspace>();
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选择设置工作区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Workspace item = getSelectedWPByName(Com_workspaceList.Text);
            SysParam.WordsSpaceSelected = item;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            
            string[] diarr = Directory.GetDirectories(SysParam.GeoserverDataPath + "workspaces\\", "*", SearchOption.TopDirectoryOnly);
            
            foreach (string item in diarr)
            {
                DirectoryInfo workspacedict = new DirectoryInfo(item);
                FileInfo[] files = workspacedict.GetFiles("workspace.xml");
                foreach (FileInfo file in files)
                {
                    Workspace wp = new Workspace(file.FullName);
                    wslist.Add(wp);
                    Com_workspaceList.Items.Add(wp.Name);
                }
            }

            DirectoryInfo workspacedefaultdr = new DirectoryInfo(SysParam.GeoserverDataPath + "workspaces\\");
            FileInfo[] defaultxml = workspacedefaultdr.GetFiles("default.xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(defaultxml[0].FullName); //加载XML文档
            XmlNode Node = xmlDoc.SelectSingleNode("workspace");
            string  defaultName = Node.LastChild.InnerText;
            if (SysParam.WordsSpaceSelected == null)
            {
                Com_workspaceList.SelectedText = defaultName;
                SysParam.WordsSpaceSelected = getSelectedWPByName(defaultName);
            }
            else
            {
                Com_workspaceList.SelectedText = SysParam.WordsSpaceSelected.Name;
            }

        }

        /// <summary>
        /// 根据下拉文本，得到wp信息
        /// </summary>
        /// <param name="selectedname"></param>
        /// <returns></returns>
        private Workspace getSelectedWPByName(string selectedname)
        {
            Workspace selectedwp = null;
            foreach (Workspace itemsp in wslist)
            {
                if (itemsp.Name == selectedname)
                {
                    selectedwp = itemsp;
                }
            }
            return selectedwp;
        }

        private void Init()
        {
            SysParam.GeoserverDataPath = ConfigurationSettings.AppSettings["GeoserverPath"];
        }
    }
}
