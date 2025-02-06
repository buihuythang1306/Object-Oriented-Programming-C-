using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDT_BuiHuyThang
{
    abstract class SanPham
    {
        protected string maSP;

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        protected string tenSP;

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
        protected string chatLieu;

        public string ChatLieu
        {
            get { return chatLieu; }
            set { chatLieu = value; }
        }
        protected double kichCo;

        public double KichCo
        {
            get { return kichCo; }
            set { kichCo = value; }
        }
        protected string mauSac;

        public string MauSac
        {
            get { return mauSac; }
            set { mauSac = value; }
        }
        protected int nSX;

        public int NSX
        {
            get { return nSX; }
            set { nSX = value; }
        }
        protected double donGia;

        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public SanPham()
        {
            MaSP = string.Empty;
            TenSP = string.Empty;
            ChatLieu = string.Empty;
            KichCo = 0;
            MauSac = string.Empty;
            NSX = 0;
            DonGia = 0;
        }
        public SanPham(string msp, string tsp, string cl, double kc, string mau, int namsx, double dongia)
        {
            MaSP = msp;
            TenSP = tsp;
            ChatLieu = cl;
            KichCo = kc;
            MauSac = mau;
            NSX = namsx;
            DonGia = dongia;
        }
        public SanPham(SanPham sp)
        {
            MaSP = sp.MaSP;
            TenSP = sp.TenSP;
            ChatLieu = sp.ChatLieu;
            KichCo = sp.KichCo;
            MauSac = sp.MauSac;
            NSX = sp.NSX;
            DonGia = sp.DonGia;
        }

        public abstract double ThanhTien();

        public virtual void Xuat()
        {
            Console.Write("MaSP:{0}\tTenSP:{1}\tChatLieu:{2}\tKichCo:{3}\tMauSac:{4}\tNamSX:{5}\tDonGia:{6}\tThanhTien:{7}", maSP, tenSP, chatLieu, kichCo, mauSac, nSX, donGia, ThanhTien());
        }
    }
}
