using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai7
{
    internal class DanhSach
    {
        List<NhanVien> ds;
        
        public List<NhanVien> Ds
        {
            get { return ds; }
            set { ds = value; }
        }
        public DanhSach()   
        {
            ds = new List<NhanVien>();
        }
        public void DocXml(string filepath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);

            XmlNodeList nodelist = doc.SelectNodes("/DanhSach/NhanVien");

            foreach (XmlNode node in nodelist)
            {
                string loai = node.Attributes["Loai"].Value;
                NhanVien nv = null;
                if (loai == "NhanVienKinhDoanh")
                {
                    nv = new NhanVienKinhDoanh();
                }
                else if (loai == "NhanVienSanXuat")
                {
                    nv = new NhanVienSanXuat();
                }
                else if (loai == "NhanVienQuanLy")
                {
                    nv = new NhanVienQuanLy();
                }
                
                ds.Add(nv);
            }
        }


    }
}
