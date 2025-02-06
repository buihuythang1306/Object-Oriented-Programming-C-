using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDT_BuiHuyThang
{
    class DepSandal:SanPham
    {
        double soQuay;

        public double SoQuay
        {
            get { return soQuay; }
            set { soQuay = value; }
        }
        string loaiDe;

        public string LoaiDe
        {
            get { return loaiDe; }
            set { loaiDe = value; }
        }
        public DepSandal()
        {
            SoQuay = 0;
            LoaiDe = string.Empty;
        }
        public DepSandal(string msp, string tsp, string cl, double kc, string mau, int namsx, double dongia, double sq, string loaide)
            : base(msp, tsp, cl, kc, mau, namsx, dongia)
        {
            SoQuay = sq;
            LoaiDe = loaide;
        }
        public override double ThanhTien()
        {
            return donGia * 35000 + soQuay * 5000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("\tSoQuay:{0}\tLoaiDeGiay:{1}", soQuay, loaiDe);
        }
    }
}
