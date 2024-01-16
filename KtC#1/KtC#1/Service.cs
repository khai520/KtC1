using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtC_1
{
    internal class Service
    {
        string check = "1";
        List<SinhVien> list = new List<SinhVien>();
        public void Nhap()
        {
            do
            {
                try
                {
                    string MSv = Console.ReadLine();
                    Console.Write("Nhập Tên Sv:");
                    string Ten = Console.ReadLine();
                    Console.Write("Nhập năm sinh:");
                    int NS = Convert.ToInt32(Console.ReadLine());
                    if (DateTime.Now.Year - NS < 18 || NS - DateTime.Now.Year > 0)
                    {
                        Console.WriteLine("Lỗi năm sinh");
                        continue;
                    }
                    Console.Write("Nhập điểm:");
                    double diem = Convert.ToDouble(Console.ReadLine());
                    if (diem > 10 || diem < 0)
                    {
                        Console.WriteLine("Lỗi điểm");
                        continue;
                    }
                    list.Add(new SinhVien()
                    {
                        MaSv1 = MSv,
                        Ten1 = Ten,
                        NamSinh1 = NS,
                        Diem1 = diem
                    });
                    Console.Write("Bạn có muốn nhập tiếp không (0:no / 1:yes):");
                    check = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Sai kiểu dữ liệu");
                    continue;
                }
                Console.Write("Nhập Mã Sv:");
            } while (check == "1" || check.ToLower() == "y");
        }
        public void Xuat1()
        {
            foreach (var item in list)
            {
                item.inThongTin();
            }
        }
        public void Xuat2()
        {
            foreach(var item in list)
            {
                if (item.Diem1 >= 8 && item.Diem1 < 25)
                {
                    item.inThongTin();
                }
            }
        }
        public void Xoa()
        {
            for (int i = 0; i < list.Count(); i++)
            {
                if (DateTime.Now.Year - list[i].NamSinh1 > 25 && list[i].Diem1 <= 8)
                {
                    list.Remove(list[i]);
                    i--; 
                }
            }
        }
        public void KeThua()
        {
            List<SinhVienUD> svUD = new List<SinhVienUD>();
            Console.Write("Nhập Mã Sv:");
            string MSv = Console.ReadLine();
            Console.Write("Nhập Tên Sv:");
            string Ten = Console.ReadLine();
            Console.Write("Nhập năm sinh:");
            int NS = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập điểm:");
            double diem = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập kì học:");
            int kihoc = Convert.ToInt32(Console.ReadLine());
            svUD.Add(new SinhVienUD()
            {
                MaSv1 = MSv,
                Ten1 = Ten,
                NamSinh1 = NS,
                Diem1 = diem,
                Kihoc1 = kihoc
            });
            foreach (var item in svUD)
            {
                item.inThongTin();
            }
        }
    }
}
