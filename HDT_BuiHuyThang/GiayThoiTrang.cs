using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDT_BuiHuyThang
{
    class GiayThoiTrang:SanPham,IPhuThu
    {
        double chieuCaoDe;

        public double ChieuCaoDe
        {
            get { return chieuCaoDe; }
            set { chieuCaoDe = value; }
        }
        string loaiMuiGiay;

        public string LoaiMuiGiay
        {
            get { return loaiMuiGiay; }
            set { loaiMuiGiay = value; }
        }
        public GiayThoiTrang()
        {
            ChieuCaoDe = 0;
            LoaiMuiGiay = string.Empty;
        }
        public GiayThoiTrang(string msp, string tsp, string cl, double kc, string mau, int namsx, double dongia, double ccd, string lmd)
            : base(msp, tsp, cl, kc, mau, namsx, dongia)
        {
            ChieuCaoDe = ccd;
            LoaiMuiGiay = lmd;
        }
        public override double ThanhTien()
        {
            return donGia * 50000 + chieuCaoDe * 2000;
        }
        public double PhuThu()
        {
            if (loaiMuiGiay == "Muinhon")
                return 12500;
            else
                return 10000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("\tChieuCaoDe:{0}\tLoaiMuiGiay:{1}\tPhuThu:{2}", chieuCaoDe, loaiMuiGiay, PhuThu());
        }
    }
}
