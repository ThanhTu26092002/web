using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyBanHangMayTinh_337
{
    public partial class DanhSachSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            App_Code.XuLyDuLieu xldl = new App_Code.XuLyDuLieu();
            string madm = Request.QueryString.Get("MADanhMuc");
            SqlParameter[] pr;
            if (madm != null)
                pr = new SqlParameter[] { new SqlParameter("@MADanhMuc", madm) };
            else
                pr = new SqlParameter[] { new SqlParameter("MADanhMuc", DBNull.Value) };
            DataList1.DataSource = xldl.getTable("psGETSANPHAM", pr);
            DataList1.DataBind();
            DataList1.RepeatColumns = 5;    
        }
    }
}