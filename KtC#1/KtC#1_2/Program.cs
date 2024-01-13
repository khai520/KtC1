using KtC_1_2;
using System.Collections;
const int VnhatDinh = 100;
Khachhang kh = new Khachhang();
CTychuyendo ctyCd = new CTychuyendo();
string checkKh = "0" , checkDo = "0" ;
ArrayList arrCty = new ArrayList();
ArrayList Kh;
ArrayList Do;
do
{
    Kh = new ArrayList();
    Do = new ArrayList();
    Console.Write("Nhập tên:");
    string ten = Console.ReadLine();
    Console.Write("Nhập tuổi:");
    int tuoi = Convert.ToInt32(Console.ReadLine());
    Console.Write("Nhập địa chỉ:");
    string diachi = Console.ReadLine();
    Console.Write("Nhập SDT:");
    string sdt = Console.ReadLine();
    Kh.Add(ctyCd.ThemKH(ten, tuoi, diachi, sdt));
    do
    {
        Console.Write("Nhập tên đồ đạc:");
        string tenDo = Console.ReadLine();
        Console.Write("Nhập chiều dài:");
        int chieudai = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập chiều rộng:");
        int chieurong = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập chiều sâu:");
        int chieusau = Convert.ToInt32(Console.ReadLine());
        Do.Add(kh.Them(tenDo, chieudai ,chieurong,chieusau));
        Console.Write("Có muốn nhập thêm đồ không (0:n / 1:y):");
        checkDo = Console.ReadLine();
    } while (checkDo == "1" || checkDo == "y");
    Kh.Add(Do);
    arrCty.Add(Kh);
    Console.WriteLine("Có muốn nhập thêm khách hàng không (0:n / 1:y):");
    checkKh = Console.ReadLine();
} while (checkKh == "1" || checkKh == "y");
foreach (var Cty in arrCty)
{
    
}