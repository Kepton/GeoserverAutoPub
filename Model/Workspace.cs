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
    }
}
