using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.InputEncoding = UnicodeEncoding.Unicode;

            NhanVienSanXuat nv1 = new NhanVienSanXuat();
            nv1.Nhap();
            nv1.Xuat();
            NhanVienKinhDoanh nv2 = new NhanVienKinhDoanh();
            nv2.Nhap();
            nv2.Xuat();
            NhanVienQuanLy nv3 = new NhanVienQuanLy();
            nv3.Nhap();
            nv3.Xuat();
            Console.ReadKey();

            //a. Đọc dữ liệu từ file XML(cấu trúc file do SV tự thiết kế để phù hợp với các truy vấn của bài).
            //b. Xuất danh sách bảng lương của các nhân viên.
            //c. Xuất danh sách các nhân viên của công ty có hệ số lương là 3.99.
            //d. Xuất danh sách các nhân viên có lương cao nhất.
            //e. Đếm số nhân viên có phụ cấp thâm niên.
            //f. Xuất thông tin các nhân viên có thâm niên từ 10 năm trở lên.
        }
    }
}
