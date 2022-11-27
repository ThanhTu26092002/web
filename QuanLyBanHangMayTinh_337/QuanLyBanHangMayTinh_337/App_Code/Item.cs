using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHangMayTinh_337.App_Code
{
    public class Item
    {
        private String masanpham;
        private string tensanpham;
        private double dongia;
        private int soluong;
        private String hinhanh;

        public Item(string masanpham, string tensanpham, double dongia, int soluong, string hinhanh)
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.dongia = dongia;
            this.soluong = soluong;
            this.hinhanh = hinhanh;
        }



        public string Masanpham { get => masanpham; set => masanpham = value; }
        public string Tensanpham { get => tensanpham; set => tensanpham = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }

        public double THANHTIEN
        {
            get { return this.soluong * this.dongia; }
        }
        public Item() { }
    }
}