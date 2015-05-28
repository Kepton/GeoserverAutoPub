using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlHelper;
using System.Xml;

namespace Model
{
    public class Workspace
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// workspacename
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        public string URI { get; set; }

        /// <summary>
        /// Prefix
        /// </summary>
        public string Prefix { get; set; }

        public Workspace()
        { 
            
        }



        public Workspace(string workspacepath)
        { 
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(workspacepath); //加载XML文档
            XmlNode Node = xmlDoc.SelectSingleNode("workspace");
            XmlNode IDNode = Node.FirstChild ;
            XmlNode NameNode = Node.LastChild;
            if (IDNode != null)
            {
                ID = IDNode.InnerText;
            }
            if (NameNode != null)
            {
                Name = NameNode.InnerText;
            }

            string namespacepath = workspacepath.Replace("workspace.xml", "namespace.xml");
            xmlDoc.Load(namespacepath);
            Node = xmlDoc.SelectSingleNode("namespace");
            XmlNode PrefixNode = Node.ChildNodes[1];
            XmlNode UriNode = Node.ChildNodes[2];

            if (PrefixNode != null)
            {
                this.Prefix = PrefixNode.InnerText;
                this.URI = UriNode.InnerText;
            }
        }

        /// <summary>
        /// 根据添加的属性 生成workspace以及namespace 两个xml文件
        /// </summary>
        /// <param name="workspace"></param>
        /// <param name="workspacepath"></param>
        ///  <param name="defaultxmlpath">default文件路径</param>
        /// <param name="isDefult">是否默认</param>
        public void SetAttribute(Workspace workspace,string workspacepath,string defaultxmlpath,bool isDefult)
        {
            /*<workspace>
              <id>WorkspaceInfoImpl--68929cbb:14d9308effa:-8000</id>
              <name>guangxi</name>
            </workspace>*/
             XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(workspacepath); //加载XML文档
            XmlNode Node = xmlDoc.SelectSingleNode("workspace");
            Node.ChildNodes[0].InnerText = workspace.ID;
            Node.ChildNodes[1].InnerText = workspace.Name;
            xmlDoc.Save(workspacepath);

            //NamespaceInfoImpl--68929cbb:14d9308effa:-7fff
            // WorkspaceInfoImpl--68929cbb:14d9308effa:-8000
            /*<namespace>
                  <id>NamespaceInfoImpl--68929cbb:14d9308effa:-7fff</id>
                  <prefix>guangxi</prefix>
                  <uri>www.guangxi.com</uri>
                </namespace>*/
            string namespacepath = workspacepath.Replace("workspace.xml", "namespace.xml");
            xmlDoc.Load(namespacepath);
            XmlNode npNode = xmlDoc.SelectSingleNode("namespace");
            npNode.ChildNodes[0].InnerText = workspace.ID.Replace("WorkspaceInfoImpl", "NamespaceInfoImpl");
            npNode.ChildNodes[1].InnerText = workspace.Name;
            npNode.ChildNodes[2].InnerText = workspace.URI;
            xmlDoc.Save(namespacepath);

            //修改default文档
            if (isDefult)
            {
                XmlDocument xmlDefaultDoc = new XmlDocument();
                xmlDefaultDoc.Load(defaultxmlpath);
                XmlNode DefaultNode = xmlDefaultDoc.SelectSingleNode("workspace");
                DefaultNode.ChildNodes[0].InnerText = workspace.ID;
                DefaultNode.ChildNodes[1].InnerText = workspace.Name;
                xmlDefaultDoc.Save(defaultxmlpath);
            }

        }
    }
}
