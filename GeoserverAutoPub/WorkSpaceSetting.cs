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
using System.Diagnostics;

namespace GeoserverAutoPub
{
    public partial class WorkSpaceSetting : Form
    {
        List<Workspace> wslist = new List<Workspace>();
        public WorkSpaceSetting()
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

        private void btn_CreateWorkSpace_Click(object sender, EventArgs e)
        {
            string newName = txt_Name.Text.Trim();
            Workspace existswp = getSelectedWPByName(newName);
            if (existswp != null)
            {
                lbl_Msg.Text = "错误：当前工作区名已存在。";
                return;
            }
            else
            {
                Workspace newwp = new Workspace();
                newwp.ID ="WorkspaceInfoImpl--"+ System.Guid.NewGuid().ToString();
                newwp.Name = newName;
                newwp.Prefix = newName;
                newwp.URI = txt_URI.Text.Trim();

                wslist.Add(newwp);

                SysParam.WordsSpaceSelected = newwp;

                string newwppathstr = SysParam.GeoserverDataPath + "workspaces\\"+newName;
                if (!Directory.Exists(newwppathstr))
                {
                    Directory.CreateDirectory(newwppathstr);
                }

                File.Copy(Application.StartupPath + "\\XmlTemplet\\Workspace\\namespace.xml", newwppathstr + "\\namespace.xml");
                File.Copy(Application.StartupPath + "\\XmlTemplet\\Workspace\\workspace.xml", newwppathstr + "\\workspace.xml");

                bool IsDefault = false;
                if (rb_yes.Checked)
                    IsDefault = true;
                newwp.SetAttribute(newwp, newwppathstr + "\\workspace.xml", SysParam.GeoserverDataPath + "workspaces\\default.xml", IsDefault);

            }
        }

        private void txt_Name_Leave(object sender, EventArgs e)
        {
            string newName = txt_Name.Text.Trim();
            Workspace existswp = getSelectedWPByName(newName);
            if (existswp != null)
            {
                lbl_Msg.Text = "错误：当前工作区名已存在。";
            }
            else
            {
                lbl_Msg.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string shutup = "D:\\Program Files (x86)\\GeoServer 2.6.3\\bin\\startup.bat";
            Process pro = new Process();
            Process.Start(shutup);
        }
    }
}
