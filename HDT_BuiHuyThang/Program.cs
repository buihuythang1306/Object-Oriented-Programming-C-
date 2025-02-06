using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDT_BuiHuyThang
{
    class Program
    {
        static void Main(string[] args)
        {
            DSSanPham ds = new DSSanPham();
            ds.docFileXMl("../../Data/file.xml");
            ds.xuatDS();
            ds.TongThanhTien();
            ds.TongPhiPhuThuCuaTungLoai();
            Console.WriteLine("\n================Giay The Thao Loai Running va size 37===================");
            ds.TheThaoRungNing();
            Console.WriteLine("\n==============================Danh Sach sau khi xap xep=======================================");
            ds.XapXep();
            ds.xuatDS();
            Console.WriteLine("\n\nnhap MaSP can Tim");
            string ma = Console.ReadLine();
            ds.xuatSPX(ma);
            Console.ReadKey();
        }
    }
}
