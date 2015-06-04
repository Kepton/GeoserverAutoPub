using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoserverAutoPub
{
    public static  class SysParam
    {
        /// <summary>
        /// Geoserver的Data的路径
        /// </summary>
        public static string GeoserverDataPath = "";

        public static string DataSource = "";

        public static string UserName = "";

        public static string Password = "";

        public static Workspace WordsSpaceSelected = null;

        public static List<Store> ListStore = null;


        //最大最小经纬度
        public static string MinX = "";
        public static string MinY = "";
        public static string MaxX = "";
        public static string MaxY = "";

        /// <summary>
        /// 坐标系
        /// </summary>
        public static string ZBX = "";
    }
}
