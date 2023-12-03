using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class NhanVienSanXuat: NhanVien
    {
        private int SoNgayNghi;
        static double PhuCap = 0.1;

        public NhanVienSanXuat() : base()
        {
            SoNgayNghi = 0;
        }
        public NhanVienSanXuat(string MaSo, string HoTen, string NgaySinh, string GioiTinh, int ThamNien, double heSoLuong, int SoNgayNghi)
            : base(MaSo, HoTen, NgaySinh, GioiTinh, ThamNien, heSoLuong)
        {
            this.SoNgayNghi = SoNgayNghi;
        }
        public override string XepLoai()
        {
            if (SoNgayNghi <= 1)
                return "A";
            else if (SoNgayNghi <= 3)
                return "B";
            else if (SoNgayNghi <= 5)
                return "C";
            else
                return "D";
        }
        public override double Luong()
        {
            return HeSoLuong * LuongCoBan * (1 + NhanVienSanXuat.PhuCap);
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập số ngày nghỉ");
            SoNgayNghi = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("===============NHÂN VIÊN SẢN XUẤT===============");
            base.Xuat();
            Console.WriteLine("So ngày nghỉ là: {0}", SoNgayNghi);

        }
    }
}
