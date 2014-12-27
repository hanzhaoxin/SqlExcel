using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace SqlExcel
{
    static class SqlHelper
    {
        private static string GetConnectionString(string dataSource)
        {
            if (string.IsNullOrEmpty(dataSource))
            {
                throw new Exception("数据源不能为空！");
            }
            return string.Format(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString, dataSource);
        }
        public static DataTable ExecuteDataTable(string dataSource, string sql, params OleDbParameter[] parameters)
        {
            using (OleDbConnection conn = new OleDbConnection(GetConnectionString(dataSource)))
            {
                using (OleDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static int ExecuteNonQuery(string dataSource, string sql, params OleDbParameter[] parameters)
        {
            using (OleDbConnection conn = new OleDbConnection(GetConnectionString(dataSource)))
            {
                conn.Open();
                using (OleDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
