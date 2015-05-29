using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Model
{
    public class Store
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public string IsEnabled { get; set; }

        /// <summary>
        /// 工作区ID
        /// </summary>
        public string WorkspaceID { get; set; }

        /// <summary>
        /// 是否使用内存映射的缓冲区
        /// </summary>
        public string Memory_Mapped_Buffer { get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// shpae
        /// </summary>
        public string Fstype { get; set; }

        /// <summary>
        /// 创建空间索引
        /// </summary>
        public string Create_spatial_Index { get; set; }

        /// <summary>
        /// 是否使用空间索引
        /// </summary>
        public string Enable_Spatial_Index { get; set; }

        /// <summary>
        /// DBF的字符集
        /// </summary>
        public string Charset { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 是否使用高速缓存和重用内存映射
        /// </summary>
        public string Cache_and_Reuse_Memory_Maps { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// namespace
        /// </summary>
        public string Namespace { get; set; }
        /// <summary>
        /// 是否默认
        /// </summary>
        public string IsDefault { get; set; }


        public Store()
        {
 
        }

        public Store(string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path); //加载XML文档
            XmlNode Node = xmlDoc.SelectSingleNode("dataStore");
            this.ID = Node.ChildNodes[0].InnerText;
            this.Name = Node.ChildNodes[1].InnerText;
            this.Description = Node.ChildNodes[2].InnerText;
            this.Type = Node.ChildNodes[3].InnerText;
            this.IsEnabled = Node.ChildNodes[4].InnerText;
            this.WorkspaceID = Node.ChildNodes[5].ChildNodes[0].InnerText;
            this.Memory_Mapped_Buffer = Node.ChildNodes[6].ChildNodes[0].InnerText;
            this.Timezone = Node.ChildNodes[6].ChildNodes[1].InnerText;
            this.Fstype = Node.ChildNodes[6].ChildNodes[2].InnerText;
            this.Create_spatial_Index = Node.ChildNodes[6].ChildNodes[3].InnerText;
            this.Charset = Node.ChildNodes[6].ChildNodes[4].InnerText;
            this.FileType = Node.ChildNodes[6].ChildNodes[5].InnerText;
            this.Cache_and_Reuse_Memory_Maps = Node.ChildNodes[6].ChildNodes[6].InnerText;
            this.Enable_Spatial_Index = Node.ChildNodes[6].ChildNodes[7].InnerText;
            this.Url = Node.ChildNodes[6].ChildNodes[8].InnerText;
            this.Namespace = Node.ChildNodes[6].ChildNodes[9].InnerText;
            this.IsDefault = Node.ChildNodes[7].InnerText;
        }

        public void SetAttribut(Workspace wp,Store store, string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path); //加载XML文档
            XmlNode Node = xmlDoc.SelectSingleNode("dataStore");
            Node.ChildNodes[0].InnerText = store.ID;
            Node.ChildNodes[1].InnerText = store.Name;
            Node.ChildNodes[2].InnerText = store.Description;
            Node.ChildNodes[3].InnerText = store.Type;
            Node.ChildNodes[4].InnerText = store.IsEnabled;
            Node.ChildNodes[5].ChildNodes[0].InnerText = wp.ID;

            Node.ChildNodes[6].ChildNodes[0].InnerText = store.Memory_Mapped_Buffer;
            Node.ChildNodes[6].ChildNodes[1].InnerText = "Asia/Shanghai";
            Node.ChildNodes[6].ChildNodes[2].InnerText = "shape";
            Node.ChildNodes[6].ChildNodes[3].InnerText = ;

            xmlDoc.Save(path);  
        }
    }
}
