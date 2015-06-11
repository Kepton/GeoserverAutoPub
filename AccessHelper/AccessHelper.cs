using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace AccessHelper
{
    public static class AccessHelper
    {
        public static string connstring = "";

        public static DataTable ExecuteDataTable(string cmdText)
        {
            OleDbCommand cmd = new OleDbCommand();
            DataSet ds = new DataSet();
            cmd.CommandText = cmdText;
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                cmd.Connection = conn;
                OleDbDataAdapter sda = new OleDbDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(ds);
                cmd.Parameters.Clear();
                return ds.Tables[0];
            }
        }
    }
}
