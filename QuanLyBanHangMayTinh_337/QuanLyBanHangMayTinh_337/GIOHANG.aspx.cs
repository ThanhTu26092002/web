using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyBanHangMayTinh_337
{
    public partial class GIOHANG : System.Web.UI.Page
    {
        public void loadCart()
        {
            App_Code.CART cart = (App_Code.CART)Session["CART"];
            this.GrvCART.DataSource = cart.LISTCARTS.Values.ToList();
            this.GrvCART.DataBind();
            this.GrvCART.FooterRow.Cells[0].Text = "Tổng Tiền = ";
            this.GrvCART.FooterRow.Cells[4].Text = cart.TotaBill().ToString();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadCart();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            App_Code.CART cart = (App_Code.CART)Session["CART"];
            foreach (GridViewRow row in GrvCART.Rows)
            {
                CheckBox ckb = (CheckBox)row.FindControl("CkboxRemove");
                if (ckb.Checked)
                {
                    String masanpham = row.Cells[0].Text;
                    cart.RemoveCart(masanpham);
                }
            }
            Session["CART"] = cart;
            loadCart();
        }
    }
}