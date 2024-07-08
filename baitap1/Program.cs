// Nhap danh sach hoc sinh 
using bai1;

List<HocSinh> dshs = new List<HocSinh>();
Console.Write("Nhap so luong hoc sinh:");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhap thong tin hoc sih thu:" + (i + 1) + ":");
    Console.Write("Ma hoc sinh: ");
    string mahs = Console.ReadLine();
    Console.Write("Ho va ten:");
    string hoten = Console.ReadLine();
    Console.Write("Gioi tinh:");
    string gioitinh = Console.ReadLine();
    Console.Write("Dia chi:");
    string diachi = Console.ReadLine();
    Console.Write("Diem toan:");
    float toan = float.Parse(Console.ReadLine());
    Console.Write("Diem ly:");
    float ly = float.Parse(Console.ReadLine());
    Console.Write("Diem hoa:");
    float hoa = float.Parse(Console.ReadLine());
    HocSinh hs = new HocSinh(mahs, hoten, gioitinh, diachi, toan, ly, hoa);
    dshs.Add(hs);
}
    // xuat danh sach hoc sinh
    Console.WriteLine("Danh sach hoc sinh");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(dshs[i].Mahs + "\t" + dshs[i].Hoten + "\t" + dshs[i].Phai + "\t" + dshs[i].Diachi + "\t" + dshs[i].Diemtoan + "\t" + dshs[i].DiemLy + "\t" + dshs[i].DiemHoa + "\t" + dshs[i].Dtb +"\t" + dshs[i].Xeploai());
    }
    // sắp xếp học sinh theo dtb
    dshs.Sort((hs1,hs2) => hs2.Dtb.CompareTo(hs1.Dtb));
// Xuất danh sách học sinh sau sắp xếp
Console.WriteLine("Danh sach hoc sinh sau khi sap xep");
for (int i = 0;i<n;i++)
    Console.WriteLine(dshs[i].Mahs + "\t" + dshs[i].Hoten + "\t" + dshs[i].Phai + "\t" + dshs[i].Diachi + "\t" + dshs[i].Diemtoan + "\t" + dshs[i].DiemLy + "\t" + dshs[i].DiemHoa + "\t" + dshs[i].Dtb + "\t" + dshs[i].Xeploai());
