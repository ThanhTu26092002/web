<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="GIOHANG.aspx.cs" Inherits="QuanLyBanHangMayTinh_337.GIOHANG" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="TraHang" />
    <asp:GridView ID="GrvCART" runat="server" AutoGenerateColumns="False" Width="690px">
        <Columns>
            <asp:BoundField DataField="MaSanPham" HeaderText="Mã Sản phẩm" />
            <asp:BoundField DataField="TenSanPham" HeaderText="Tên Sẩn phẩm" />
            <asp:BoundField DataField="SoLuong" HeaderText="Số Lượng" />
            <asp:BoundField DataField="DonGia" HeaderText="Đơn Giá" />
            <asp:BoundField DataField="THANHTIEN" HeaderText="Thành Tiền" />
            <asp:ImageField DataAlternateTextField="HINHANH" DataImageUrlField="HINHANH" DataImageUrlFormatString="Image/{0}" HeaderText="Ảnh">
            </asp:ImageField>
            <asp:TemplateField HeaderText="Trả Hàng">
                <ItemTemplate>
                    <asp:CheckBox ID="CkboxRemove" runat="server"  />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
