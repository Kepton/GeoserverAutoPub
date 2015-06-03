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
            if (SysParam.WordsSpaceSelected == null)
            {
                MessageBox.Show("请先选择工作区");
                return;

            }
            lbl_selectedworkspacename.Text = SysParam.WordsSpaceSelected.Name;

            string[] diarr = Directory.GetDirectories(SysParam.GeoserverDataPath + "workspaces\\" + SysParam.WordsSpaceSelected.Name, "*", SearchOption.TopDirectoryOnly);
            SysParam.ListStore = new List<Store>();
            foreach (string item in diarr)
            {
                DirectoryInfo workspacedict = new DirectoryInfo(item);
                FileInfo[] files = workspacedict.GetFiles("datastore.xml");
                foreach (FileInfo file in files)
                {
                    string[] dir=item.Split('\\');
                    com_storeslist.Items.Add(dir[dir.Length-1]);
                    Store itemstore = new Store(file.FullName);
                    SysParam.ListStore.Add(itemstore);
                }
            }
        }

        private void btn_addstore_Click(object sender, EventArgs e)
        {
            if (txt_storeName.Text.Trim() == "")
            {
                MessageBox.Show("数据存储名称不能为空！");
                return;
            }
            string StoreName=txt_storeName.Text.Trim();
            foreach (Store itemstore in SysParam.ListStore)
            {
                if (itemstore.Name == StoreName)
                {
                    MessageBox.Show("此名称已经被使用");
                    return;
                }
            }
            string shapepath=txt_shapepath.Text;
            Store newStore = new Store();
            newStore.ID = "DataStoreInfoImpl--"+Guid.NewGuid().ToString();
            newStore.Name = StoreName;
            newStore.Description = txt_storedescription.Text.Trim();
            newStore.Type = "Shapefile";
            newStore.IsEnabled=ckb_isenabled.Checked?"true":"false";
            newStore.WorkspaceID = SysParam.WordsSpaceSelected.ID;

            newStore.Memory_Mapped_Buffer = ckb_cache_memory_map.Checked ? "true" : "false";
            newStore.Timezone = "Asia/Shanghai";
            newStore.Fstype = "shape";
            newStore.Create_spatial_Index = ckb_create_index.Checked ? "true" : "false";
            newStore.Charset = txt_dbf.Text.Trim();
            newStore.FileType = "shapefile";

            newStore.Cache_and_Reuse_Memory_Maps = ckb_cache_reuse_memory.Checked ? "true" : "false";
            newStore.Enable_Spatial_Index = "true";
            newStore.Url = shapepath;
            newStore.Namespace = SysParam.WordsSpaceSelected.URI;
            newStore.IsDefault = "false";

            string newwppathstr = SysParam.GeoserverDataPath + "workspaces\\" + SysParam.WordsSpaceSelected.Name +"\\"+ StoreName;

            if (!Directory.Exists(newwppathstr))
            {
                Directory.CreateDirectory(newwppathstr);
            }

            File.Copy(Application.StartupPath + "\\XmlTemplet\\DataStore\\datastore.xml", newwppathstr + "\\datastore.xml");


            newStore.SetAttribut(SysParam.WordsSpaceSelected, newStore, newwppathstr + "\\datastore.xml");
           com_storeslist.Items.Add(StoreName);

           SysParam.ListStore.Add(newStore);
           




        }

        private void btn_selectpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "(*.shp)|*.shp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                txt_shapepath.Text = "file://" + op.FileName;
            }

        }
    }
}
