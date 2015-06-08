using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using XmlHelper;

namespace Model
{
    public class layer
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name = "";

        /// <summary>
        /// ID
        /// </summary>
        public string ID = "";

        /// <summary>
        /// Type shape文件难道是vector
        /// </summary>
        public string Type = "VECTOR";

        /// <summary>
        /// 默认样式的ID
        /// </summary>
        public string DefaultStyle_ID = "";

        /// <summary>
        /// FeatureID
        /// </summary>
        public string resource_ID = "";

        /// <summary>
        /// Logowidth
        /// </summary>
        public string Attribution_LogoWidth = "";

        /// <summary>
        /// LogoHeight
        /// </summary>
        public string Attribution_LogoHeight = "";


        public void SetAttribut(FeatureType featuretype, string xmlpath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlpath); //加载XML文档
            XmlNode Node = xmlDoc.SelectSingleNode("layer");
            XMLHelper.SetAttributeValue(Node, "id", this.ID);
            XMLHelper.SetAttributeValue(Node, "name", this.Name);
            XMLHelper.SetAttributeValue(Node, "type", this.Type);
            XMLHelper.SetAttributeValue(Node, "defaultStyle","id", this.DefaultStyle_ID);
            XMLHelper.SetAttributeValue(Node, "resource", "id", featuretype.ID);

            XMLHelper.SetAttributeValue(Node, "attribution", "logoWidth", this.Attribution_LogoWidth);
            XMLHelper.SetAttributeValue(Node, "attribution", "logoWidth", this.Attribution_LogoHeight);

            xmlDoc.Save(xmlpath);
            
        }

    }
}
