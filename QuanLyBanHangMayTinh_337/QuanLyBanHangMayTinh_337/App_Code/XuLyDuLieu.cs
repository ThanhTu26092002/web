using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHangMayTinh_337.App_Code
{
    public class XuLyDuLieu
    {
        SqlConnection cn;
        public XuLyDuLieu()
        {
            this.cn = new SqlConnection();
            this.cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\QuanLyBanHangMayTinh_337\QuanLyBanHangMayTinh_337\QuanLyBanHangMayTinh_337\App_Data\QuanLyBanHangMayTinh.mdf;Integrated Security=True";
        }
        private void OpenConenction()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
        }
        private void CloseConnection()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }

        public DataTable GetTable(String sql)
        {
            OpenConenction();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, cn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CloseConnection();
            return table;


        }

        public DataTable getTable(string procedurce, SqlParameter[] pr)
        {
            OpenConenction();
            DataTable table = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = cn;
            sqlCommand.CommandText = procedurce;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            if (pr != null)
                sqlCommand.Parameters.AddRange(pr);
            SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
            adp.Fill(table);
            CloseConnection();
            return table;
        }
        public void getDataset(ref DataSet ds, String sql)
        {
            ds.Tables.Add(GetTable(sql));

        }
        public void getDataSet(ref DataSet ds, string procedurce, SqlParameter[] pr)
        {
            ds.Tables.Add(this.GetTable(procedurce));
        }
        public int Execute(String sql)
        {
            OpenConenction();
            SqlCommand sqlCommand = new SqlCommand(sql, cn);
            CloseConnection();
            int result = (int)sqlCommand.ExecuteNonQuery();
            return result;
        }
        public int Execute(string procedurce, SqlParameter[] pr)
        {
            OpenConenction();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = cn;
            sqlCommand.CommandText = procedurce;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            if (pr != null)
                sqlCommand.Parameters.AddRange(pr);

            int result = (int)sqlCommand.ExecuteNonQuery();
            CloseConnection();
            return result;

        }
    }
}