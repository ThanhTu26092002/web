using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyBanHangMayTinh_337
{
    public partial class User : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\QuanLyBanHangMayTinh_337\QuanLyBanHangMayTinh_337\QuanLyBanHangMayTinh_337\App_Data\QuanLyBanHangMayTinh.mdf;Integrated Security=True";
            cn.Open();

            String sql = "select * from NhomThietBi";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, cn);
            DataTable tb = new DataTable(); // dữ liệu vào trong tb
            adapter.Fill(tb);
            Repeater1.DataSource = tb;
            Repeater1.DataBind();
            cn.Close();

        }
    }
}