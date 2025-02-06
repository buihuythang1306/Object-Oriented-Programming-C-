using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDT_BuiHuyThang
{
    class GiayTheThao:SanPham,IPhuThu
    {
        string loaiGiay;

        public string LoaiGiay
        {
            get { return loaiGiay; }
            set { loaiGiay = value; }
        }
        public GiayTheThao()
        {
            loaiGiay = string.Empty;
        }
        public GiayTheThao(string msp, string tsp, string cl, double kc, string mau, int namsx, double dongia, string loaigiay)
            : base(msp, tsp, cl, kc, mau, namsx, dongia)
        {
            LoaiGiay = loaigiay;
        }
        public override double ThanhTien()
        {
            return donGia * 65000 + 30000;
        }
        public double PhuThu()
        {
            if (loaiGiay == "Running")
                return 30000;
            else
                return 25000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("\tLoaiGia:{0}\tPhuThu:{1}", loaiGiay, PhuThu());
        }
    }
}
