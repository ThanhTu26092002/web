using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHangMayTinh_337.App_Code
{
    public class CART
    {
        Dictionary<string, Item> listcarts;
        public Dictionary<string, Item> LISTCARTS
        {
            get { return this.listcarts; }
        }
        public CART()
        {
            listcarts = new Dictionary<string, Item>();
        }
        public void AddCart(string masanpham, string tensanpham, string hinhanh, int soluong, double dongia)
        {
            Item item = new Item(masanpham, tensanpham, dongia, soluong, hinhanh);
            if (listcarts.ContainsKey(item.Masanpham))
            {
                listcarts[item.Masanpham].Soluong += item.Soluong;
            }
            else
                listcarts.Add(item.Masanpham, item);
        }
        public void RemoveCart(string MaSanPham)
        {
            listcarts.Remove(MaSanPham);
        }
        public double TotaBill()
        {
            double total = 0;
            foreach (Item item in listcarts.Values)
                total += item.THANHTIEN;
            return total;
        }
    }
}