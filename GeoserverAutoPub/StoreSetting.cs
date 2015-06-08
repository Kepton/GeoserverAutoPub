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


           AddFeatrueTypeAndLayer(newwppathstr, txt_shapepath.Text, newStore);
           




        }

        /// <summary>
        /// 
        /// </summary>
        private void AddFeatrueTypeAndLayer(string storepath,string Filename,Store store)
        {
            string[] filenames = Filename.Split('\\');
            string tempFileName = filenames[filenames.Length-1].Substring(0,filenames[filenames.Length-1].LastIndexOf('.'));
            if (!Directory.Exists(storepath + "\\" + tempFileName))
            {
                Directory.CreateDirectory(storepath + "\\" + tempFileName);
            }
            File.Copy(Application.StartupPath + "\\XmlTemplet\\Layer\\featuretype.xml", storepath + "\\" + tempFileName + "\\featuretype.xml");
           FeatureType feature = new FeatureType();
           feature.ID = "FeatureTypeInfoImpl--" + Guid.NewGuid().ToString();
           string[] tempfiles = txt_shapepath.Text.Split('\\');
           feature.Name = tempfiles[tempfiles.Length-1].Substring(0,tempfiles[tempfiles.Length-1].LastIndexOf('.'));
           feature.NativeName = feature.Name;
           feature.NamespaceID = SysParam.WordsSpaceSelected.ID.Replace("WorkspaceInfoImpl", "NamespaceInfoImpl");
           feature.Title = feature.Name;
           feature.Srs = "EPSG:4326";
           feature.NativeBoundingBox_MinX = SysParam.MinX;
           feature.NativeBoundingBox_MinY = SysParam.MinY;
           feature.NativeBoundingBox_MaxX = SysParam.MaxX;
           feature.NativeBoundingBox_MaxY = SysParam.MaxY;

           feature.LatLonBoundingBox_MinX = SysParam.MinX;
           feature.LatLonBoundingBox_MinY = SysParam.MinY;
           feature.LatLonBoundingBox_MaxX = SysParam.MaxX;
           feature.LatLonBoundingBox_MaxY = SysParam.MaxY;

           feature.ProjectionPolicy = "FORCE_DECLARED";
           feature.IsEnabled = "true";
           feature.StoreID = store.ID;
           feature.maxFeatures = "0";
           feature.numDecimals = "0";
           feature.overridingServiceSRS = "false";
           feature.circularArcPresent = "false";

           feature.SetAttribut(SysParam.WordsSpaceSelected, store, feature, storepath + "\\" + tempFileName + "\\featuretype.xml");


           File.Copy(Application.StartupPath + "\\XmlTemplet\\Layer\\layer.xml", storepath + "\\" + tempFileName + "\\layer.xml");

           layer _layer = new layer();
           _layer.Name = feature.Name;
           _layer.ID = "LayerInfoImpl--" + Guid.NewGuid().ToString();
           _layer.Type = "VECTOR";
           _layer.DefaultStyle_ID = "StyleInfoImpl--570ae188:124761b8d78:-7fe3";
           _layer.resource_ID = feature.ID;
           _layer.Attribution_LogoWidth = "0";
           _layer.Attribution_LogoHeight = "0";
           _layer.SetAttribut(feature, storepath + "\\" + tempFileName + "\\layer.xml");
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
