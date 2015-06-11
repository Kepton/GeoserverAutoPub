using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SqlHelper
{
    public static class SQLHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string connectionString { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="cmdParms"></param>

        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;
            cmd.CommandTimeout = 0;

            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

         public static int ExecuteNonQuery(CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
         {

             SqlCommand cmd = new SqlCommand();

             using (SqlConnection conn = new SqlConnection(connectionString))
             {
                 PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                 int val = cmd.ExecuteNonQuery();
                 cmd.Parameters.Clear();
                 return val;
             }
         }

         /// <summary>
         /// 
         /// </summary>
         /// <param name="cmdType"></param>
         /// <param name="cmdText"></param>
         /// <param name="commandParameters"></param>
         /// <returns></returns>
         public static DataTable ExecuteDataTable(CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
         {
             SqlCommand cmd = new SqlCommand();
             DataSet ds = new DataSet();

             using (SqlConnection conn = new SqlConnection(connectionString))
             {
                 PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                 SqlDataAdapter sda = new SqlDataAdapter();
                 sda.SelectCommand = cmd;

                 sda.Fill(ds);
                 cmd.Parameters.Clear();
                 return ds.Tables[0];
             }
         }
    }
}
