<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="QuanLyBanHangMayTinh_337.ChiTietSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server" >
         <ItemTemplate>
            <img alt="" src='Image/<%# Eval("HinhAnh") %>' width ="150px" hight ="150px" />
            <h1>Tên Sản Phẩm: <%# Eval ("TenThietBi") %></h1>
            <%# Eval("MoTa") %>
            <br />

        </ItemTemplate>
    </asp:Repeater>
    <asp:DropDownList ID="drlSOLUONG" runat="server">
    </asp:DropDownList>
    <asp:Button ID="btn_GioHang" runat="server" Text="Thêm Vào Giỏ Hàng" OnClick="btn_GioHang_Click" />
</asp:Content>
