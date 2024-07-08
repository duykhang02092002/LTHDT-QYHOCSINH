using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class HocSinh
    {
        public string Mahs { get; set; }
        public string Hoten { get; set; }
        public string Phai { get; set; }
        public string Diachi { get; set; }
        public float Diemtoan { get; set; }
        public float DiemLy { get; set; }
        public float DiemHoa { get; set; }
        public float Dtb
        {
            get
            {
                return (Diemtoan + DiemLy + DiemHoa) / 3;
            }
        }

        public HocSinh(string mahs, string hoten, string phai, string diachi, float toan, float ly, float hoa)
        {
            Mahs = mahs;
            Hoten = hoten;
            Phai = phai;
            Diachi = diachi;
            Diemtoan = toan;
            DiemLy = ly;
            DiemHoa = hoa;
        }
        public string Xeploai()
        {
            if (Dtb >= 9)
                return "Xuat sac";
            else if (Dtb >= 8)
                return "Gioi";
            else if (Dtb >= 5)
                return "Trung Binh";
            else return "Yeu";

        }
    }
}