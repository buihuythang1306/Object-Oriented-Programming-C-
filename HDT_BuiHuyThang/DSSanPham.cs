using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HDT_BuiHuyThang
{
    class DSSanPham
    {
        string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        string msThue;

        public string MsThue
        {
            get { return msThue; }
            set { msThue = value; }
        }
        List<SanPham> lst;
        public DSSanPham()
        {
            lst = new List<SanPham>();
            DiaChi = string.Empty;
            MsThue = string.Empty;
        }
        public void docFileXMl(string a)
        {
            XmlDocument read = new XmlDocument();
            read.Load(a);
            XmlNode n = read.SelectSingleNode("congty_a");
            DiaChi = n["diachi"].InnerText;
            MsThue = n["masothue"].InnerText;
            XmlNodeList node_list = read.SelectNodes("congty_a/dssanphams/sanpham");
            int loai;
            foreach (XmlNode node in node_list)
            {
                loai = int.Parse(node["loaigiay"].InnerText);
                SanPham sp;
                if (loai == 1)
                {
                    string ma = node["masp"].InnerText;
                    string ten = node["tensp"].InnerText;
                    string cl = node["chatlieu"].InnerText;
                    double kc = double.Parse(node["size"].InnerText);
                    string mau = node["mausac"].InnerText;
                    int nsx = int.Parse(node["namsx"].InnerText);
                    double gia = double.Parse(node["dongia"].InnerText);
                    double ccde = double.Parse(node["chieucaode"].InnerText);
                    string loaimd = node["loaimuigiay"].InnerText;
                    sp = new GiayThoiTrang(ma, ten, cl, kc, mau, nsx, gia, ccde, loaimd);
                }
                else if (loai == 2)
                {
                    string ma = node["masp"].InnerText;
                    string ten = node["tensp"].InnerText;
                    string cl = node["chatlieu"].InnerText;
                    double kc = double.Parse(node["size"].InnerText);
                    string mau = node["mausac"].InnerText;
                    int nsx = int.Parse(node["namsx"].InnerText);
                    double gia = double.Parse(node["dongia"].InnerText);
                    string loaigiay = node["loaigiayda"].InnerText;
                    sp = new GiayTheThao(ma, ten, cl, kc, mau, nsx, gia, loaigiay);
                }
                else
                {
                    string ma = node["masp"].InnerText;
                    string ten = node["tensp"].InnerText;
                    string cl = node["chatlieu"].InnerText;
                    double kc = double.Parse(node["size"].InnerText);
                    string mau = node["mausac"].InnerText;
                    int nsx = int.Parse(node["namsx"].InnerText);
                    double gia = double.Parse(node["dongia"].InnerText);
                    double soquay = double.Parse(node["soquay"].InnerText);
                    string loaide = node["loaide"].InnerText;
                    sp = new DepSandal(ma, ten, cl, kc, mau, nsx, gia, soquay, loaide);
                }
                lst.Add(sp);
            }
        }
        public void xuatDS()
        {
            Console.WriteLine("DiaChi:{0}\nMaSoThue:{1}", diaChi, msThue);
            Console.Write("\n\n");
            foreach (SanPham sp in lst)
            {
                sp.Xuat();
                Console.Write("\n\n\n");
            }
        }
        public void TongThanhTien()
        {
            double tongTT = 0;
            foreach (SanPham sp in lst)
            {
                tongTT += sp.ThanhTien();
            }
            Console.WriteLine("Tong Thanh Tien Cua Tat Ca San Pham:{0}", tongTT);
        }
        public void TongPhiPhuThuCuaTungLoai()
        {
            double tongThoiTrang = 0;
            double tongTheThao = 0;
            foreach (SanPham b in lst)
            {
                if (b is GiayThoiTrang)
                {
                    IPhuThu t = (IPhuThu)b;
                    tongThoiTrang += t.PhuThu();
                }
                if (b is GiayTheThao)
                {
                    IPhuThu t = (IPhuThu)b;
                    tongTheThao += t.PhuThu();
                }
            }
            Console.Write("\nTong phi phu thu cua giay thoi trang:{0}\nTong phi phu thu cua giay the thao:{1}", tongThoiTrang, tongTheThao);
        }
        public void XapXep()
        {
            lst = lst.OrderByDescending(t => t.NSX).ThenBy(t => t.KichCo).ToList();
        }
        public void xuatSPX(string a)
        {
            int c = 0;
            foreach (SanPham b in lst)
            {
                if (b.MaSP == a)
                {
                    b.Xuat();
                    c++;
                }
            }
            if (c == 0)
            {
                Console.WriteLine("Khong Co San Pham Nao!!!");
            }
        }
        public void TheThaoRungNing()
        {
            List<GiayTheThao> TheThaoList = new List<GiayTheThao>();
            foreach (SanPham b in lst)
            {
                if (b is GiayTheThao)
                {
                    TheThaoList.Add((GiayTheThao)b);
                }
            }
            foreach (GiayTheThao abc in TheThaoList)
            {
                if (abc.LoaiGiay == "Running" && abc.KichCo == 37)
                {
                    abc.Xuat();
                }
            }
        }
    }
}
