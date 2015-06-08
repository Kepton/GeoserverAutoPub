using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using XmlHelper;

namespace Model
{
    public class FeatureType
    {
        /// <summary>
        /// FeatureID
        /// </summary>
        public string ID = "";

        /// <summary>
        /// Name
        /// </summary>
        public string Name = "";

        /// <summary>
        /// NativeName
        /// </summary>
        public string NativeName = "";

        /// <summary>
        /// NamespaceID
        /// </summary>
        public string NamespaceID = "";

        /// <summary>
        /// Title
        /// </summary>
        public string Title = "";

        /// <summary>
        /// 关键字
        /// </summary>
        public List<string> Keywords = new List<string>();

        /// <summary>
        /// 坐标系
        /// </summary>
        public string Srs = "";

        /// <summary>
        /// nativeBoundingBox最小经度
        /// </summary>
        public string NativeBoundingBox_MinX = "";

        /// <summary>
        /// nativeBoundingBox最小纬度
        /// </summary>
        public string NativeBoundingBox_MinY = "";

        /// <summary>
        /// nativeBoundingBox最大经度
        /// </summary>
        public string NativeBoundingBox_MaxX = "";

        /// <summary>
        /// nativeBoundingBox最大纬度
        /// </summary>
        public string NativeBoundingBox_MaxY = "";

        /// <summary>
        /// latLonBoundingBox的最小经度
        /// </summary>
        public string LatLonBoundingBox_MinX = "";

        /// <summary>
        /// latLonBoundingBox的最小纬度
        /// </summary>
        public string LatLonBoundingBox_MinY = "";

        /// <summary>
        /// latLonBoundingBox的最大经度
        /// </summary>
        public string LatLonBoundingBox_MaxX = "";

        /// <summary>
        /// latLonBoundingBox的最大纬度
        /// </summary>
        public string LatLonBoundingBox_MaxY = "";

        /// <summary>
        /// 这个不知道什么意思
        /// </summary>
        public string LatLonBoundingBox_Crs = @"GEOGCS[&quot;WGS84(DD)&quot;, &#xd;
  DATUM[&quot;WGS84&quot;, &#xd;
    SPHEROID[&quot;WGS84&quot;, 6378137.0, 298.257223563]], &#xd;
  PRIMEM[&quot;Greenwich&quot;, 0.0], &#xd;
  UNIT[&quot;degree&quot;, 0.017453292519943295], &#xd;
  AXIS[&quot;Geodetic longitude&quot;, EAST], &#xd;
  AXIS[&quot;Geodetic latitude&quot;, NORTH]]";

        public string ProjectionPolicy = "";

        public string IsEnabled = "";

        public string StoreID = "";

        public string maxFeatures = "";

        public string numDecimals = "";

        public string overridingServiceSRS = "";

        public string circularArcPresent = "";

        public FeatureType()
        {
 
        }

        public FeatureType(string xmlpath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlpath); //加载XML文档
            XmlNode Node = xmlDoc.SelectSingleNode("featureType");
            this.ID = XMLHelper.GetNodeValue(Node, "id");
            this.Name = XMLHelper.GetNodeValue(Node, "name");
            this.NativeName = XMLHelper.GetNodeValue(Node, "nativeName");
            this.NamespaceID = XMLHelper.GetNodeValue(Node, "namespace","id");
            this.Title = XMLHelper.GetNodeValue(Node, "title");
            this.Srs = XMLHelper.GetNodeValue(Node, "srs");

            this.NativeBoundingBox_MinX = XMLHelper.GetNodeValue(Node, "nativeBoundingBox", "minx");
            this.NativeBoundingBox_MinY = XMLHelper.GetNodeValue(Node, "nativeBoundingBox", "miny");
            this.NativeBoundingBox_MaxX = XMLHelper.GetNodeValue(Node, "nativeBoundingBox", "maxx");
            this.NativeBoundingBox_MaxY = XMLHelper.GetNodeValue(Node, "nativeBoundingBox", "maxy");

            this.LatLonBoundingBox_MinX = XMLHelper.GetNodeValue(Node, "latLonBoundingBox", "minx");
            this.LatLonBoundingBox_MinY = XMLHelper.GetNodeValue(Node, "latLonBoundingBox", "miny");
            this.LatLonBoundingBox_MaxX = XMLHelper.GetNodeValue(Node, "latLonBoundingBox", "maxx");
            this.LatLonBoundingBox_MaxY = XMLHelper.GetNodeValue(Node, "latLonBoundingBox", "maxy");
            //this.LatLonBoundingBox_Crs = XMLHelper.GetNodeValue(Node, "latLonBoundingBox", "crs");
            this.ProjectionPolicy = XMLHelper.GetNodeValue(Node, "projectionPolicy");
            this.IsEnabled = XMLHelper.GetNodeValue(Node, "enabled");
            this.StoreID = XMLHelper.GetNodeValue(Node, "store", "id");
            this.maxFeatures = XMLHelper.GetNodeValue(Node, "maxFeatures");
            this.numDecimals = XMLHelper.GetNodeValue(Node, "numDecimals");
            this.overridingServiceSRS = XMLHelper.GetNodeValue(Node, "overridingServiceSRS");
            this.circularArcPresent = XMLHelper.GetNodeValue(Node, "circularArcPresent");

        }

        public void SetAttribut(Workspace wp, Store store, FeatureType featuretype, string xmlpath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlpath); //加载XML文档
            XmlNode Node = xmlDoc.SelectSingleNode("featureType");
            XMLHelper.SetAttributeValue(Node, "id", featuretype.ID);
            XMLHelper.SetAttributeValue(Node, "name", featuretype.Name);
            XMLHelper.SetAttributeValue(Node, "nativeName", featuretype.NativeName);
            XMLHelper.SetAttributeValue(Node, "namespace","id", featuretype.NamespaceID);
            XMLHelper.SetAttributeValue(Node, "title", featuretype.Title);
            XMLHelper.SetAttributeValue(Node, "srs", featuretype.Srs);

            XMLHelper.SetAttributeValue(Node, "nativeBoundingBox","minx", featuretype.NativeBoundingBox_MinX);
            XMLHelper.SetAttributeValue(Node, "nativeBoundingBox", "miny", featuretype.NativeBoundingBox_MinY);
            XMLHelper.SetAttributeValue(Node, "nativeBoundingBox", "maxx", featuretype.NativeBoundingBox_MaxX);
            XMLHelper.SetAttributeValue(Node, "nativeBoundingBox", "maxy", featuretype.NativeBoundingBox_MaxY);

            XMLHelper.SetAttributeValue(Node, "latLonBoundingBox", "minx", featuretype.LatLonBoundingBox_MinX);
            XMLHelper.SetAttributeValue(Node, "latLonBoundingBox", "miny", featuretype.LatLonBoundingBox_MinY);
            XMLHelper.SetAttributeValue(Node, "latLonBoundingBox", "maxx", featuretype.LatLonBoundingBox_MaxX);
            XMLHelper.SetAttributeValue(Node, "latLonBoundingBox", "maxy", featuretype.LatLonBoundingBox_MaxY);
            XMLHelper.SetAttributeValue(Node, "latLonBoundingBox", "crs", featuretype.LatLonBoundingBox_Crs);

            XMLHelper.SetAttributeValue(Node, "projectionPolicy",  featuretype.ProjectionPolicy);
            XMLHelper.SetAttributeValue(Node, "enabled", featuretype.IsEnabled);

            XMLHelper.SetAttributeValue(Node, "store","id", store.ID);

            XMLHelper.SetAttributeValue(Node, "maxFeatures", featuretype.maxFeatures);
            XMLHelper.SetAttributeValue(Node, "numDecimals", featuretype.numDecimals);
            XMLHelper.SetAttributeValue(Node, "overridingServiceSRS", featuretype.overridingServiceSRS);
            XMLHelper.SetAttributeValue(Node, "circularArcPresent", featuretype.circularArcPresent);

            xmlDoc.Save(xmlpath);
        }

    }
}
