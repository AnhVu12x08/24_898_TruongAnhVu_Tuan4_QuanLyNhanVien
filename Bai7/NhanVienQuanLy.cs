using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class NhanVienQuanLy : NhanVien
    {
        string ChucVu;
        double HeSoChucVu;
        public NhanVienQuanLy()
            : base()
        {
            ChucVu = "";
            HeSoChucVu = 0.0;
        }
        public NhanVienQuanLy(string MaSo, string HoTen, string NgaySinh, string GioiTinh, int ThamNien, double heSoLuong, string ChucVu, double HeSoChucVu)
            : base(MaSo, HoTen, NgaySinh, GioiTinh, ThamNien, heSoLuong)
        {
            this.ChucVu = ChucVu;
            this.HeSoChucVu = HeSoChucVu;
        }
        public override string XepLoai()
        {
            return "A";
        }
        public double PhuCapChucVu()
        {
            return HeSoChucVu * 1100;
        }
        public override double Luong()
        {
            return (HeSoLuong * LuongCoBan) + PhuCapChucVu();
        }
        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập chức vụ");
            ChucVu = Console.ReadLine();
            Console.WriteLine("Nhập hệ số chức vụ");
            HeSoChucVu = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("===============NHÂN VIÊN QUẢN LÝ===============");
            base.Xuat();
            Console.WriteLine("Chức vụ là: {0}", ChucVu);
            Console.WriteLine("Hệ số chức vụ là: {0}", HeSoChucVu);
            Console.WriteLine("===============");

        }
    }
}
