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
    public partial class ChiTietSanPham : System.Web.UI.Page
    {

        DataTable tbSanPham;
        protected void Page_Load(object sender, EventArgs e)
        {
            App_Code.XuLyDuLieu xldl = new App_Code.XuLyDuLieu();

            string masanpham = Request.QueryString.Get("MaSanPham");
            SqlParameter[] pr;
            if (masanpham != null)
            {
                pr = new SqlParameter[] { new SqlParameter("@MaSanPham", masanpham) };

            }
            else
                pr = new SqlParameter[] { new SqlParameter("@MaSanPham", DBNull.Value) };
            tbSanPham = xldl.getTable("psGETCHiTIETSANPHAM", pr);
            Repeater2.DataSource = tbSanPham;
            Repeater2.DataBind();
            int soluong = Convert.ToInt32(tbSanPham.Rows[0]["SoLuong"].ToString());
            for (int i = 1; i <= 1; i++)
            {
                this.drlSOLUONG.Items.Add(i.ToString());
            }
        }

        protected void btn_GioHang_Click(object sender, EventArgs e)
        {
            Session.Timeout = 2;
            App_Code.CART cart = new App_Code.CART();
            if (tbSanPham != null)
            {
                String masanpham = tbSanPham.Rows[0]["MaThietBi"].ToString();
                String tensanpham = tbSanPham.Rows[0]["TenThietBi"].ToString();
                double dongia = Double.Parse(tbSanPham.Rows[0]["DonGia"].ToString());
                String hinhanh = tbSanPham.Rows[0]["HinhAnh"].ToString();
                int soluong = Int16.Parse(drlSOLUONG.SelectedItem.Text);
                if (Session["CART"] != null)
                    cart = (App_Code.CART)Session["CART"];
                cart.AddCart(masanpham, tensanpham, hinhanh, soluong, dongia);
                Session["CART"] = cart;
                Response.Redirect("GIOHANG.aspx");
            }
        }
    }
}