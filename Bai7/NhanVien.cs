using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    abstract class NhanVien
    {
        protected string MaSo;
        protected string HoTen;
        protected string NgaySinh;
        protected string GioiTinh;
        protected int ThamNien;
        protected double LuongCoBan = 1300000.0;
        protected double HeSoLuong;
        
        public NhanVien()
        {
            MaSo = "";
            HoTen = "";
            NgaySinh = "";
            GioiTinh = "";
            ThamNien = 0;
            HeSoLuong = 0.0;
        }
        public NhanVien(string MaSo, string HoTen, string NgaySinh, string GioiTinh, int ThamNien, double HeSoLuong)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.ThamNien = ThamNien;
            this.HeSoLuong = HeSoLuong;
        }
        public double PhuCapThamNien()
        {
            if (ThamNien >= 5)
                return ThamNien * LuongCoBan / 100;
            else return 0;
        }
        public abstract string XepLoai();
        public abstract double Luong();
        public double ThuNhap()
        {
            if (XepLoai() == "A")
                return Luong() + PhuCapThamNien();
            else if (XepLoai() == "B")
                return Luong() * 0.75 + PhuCapThamNien();
            else if (XepLoai() == "C")
                return Luong() * 0.50 + PhuCapThamNien();
            else
                return Luong() * 0.0 + PhuCapThamNien();
        }
        public virtual void Nhap()
        {
            Console.WriteLine("============NHẬP THÔNG TIN============ ");
            Console.WriteLine("Nhập mã số: ");
            MaSo = Console.ReadLine();
            Console.WriteLine("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh: ");
            NgaySinh = Console.ReadLine();
            Console.WriteLine("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhập thâm niên: ");
            ThamNien = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số lương: ");
            HeSoLuong = double.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Mã số là: {0}", MaSo);
            Console.WriteLine("Họ tên là: {0}", HoTen);
            Console.WriteLine("Ngày sinh là: {0}", NgaySinh);
            Console.WriteLine("Giới tính là: {0}", GioiTinh);
            Console.WriteLine("Thâm niên là: {0}", ThamNien);
            Console.WriteLine("Hệ số lương là: {0}", HeSoLuong);
            Console.WriteLine("Lương cơ bản là: {0}", LuongCoBan);
            Console.WriteLine("Phụ cấp thâm niên là: {0}", PhuCapThamNien());
            Console.WriteLine("Xếp loại là: {0}", XepLoai());
            Console.WriteLine("Lương là: {0:f}", Luong());
            Console.WriteLine("Thu nhập là: {0:f}", ThuNhap());
        }
    }
}
