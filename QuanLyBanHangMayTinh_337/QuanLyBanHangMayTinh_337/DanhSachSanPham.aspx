<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="DanhSachSanPham.aspx.cs" Inherits="QuanLyBanHangMayTinh_337.DanhSachSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <a href="ChiTietSanPham.aspx?MaSanPham=<%# Eval("MaThietBi") %>">
                <img alt =" "src ='Image/<%# Eval("HinhAnh") %>' width="150px" height="150px" />
                 <br />
                    Tên sản phẩm:  <H3> <%# Eval("TenThietBi") %></H3>
                <br /></a>
            <%# Eval("MoTa") %>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
