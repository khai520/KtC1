using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtC_1_2
{
    internal class Khachhang
    {
        public string Ten;
        public int Tuoi;
        string Diachi;
        string SDT;

        public string Diachi1 { get => Diachi; set => Diachi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }

        ArrayList Dodac = new ArrayList();
        Dodac dodac;
        public void Them()
        {
            Console.WriteLine("Nhập chiều dài:");
            dodac.chieudai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng:");
            dodac.chieurong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập chiều sâu");
            dodac.chieusau = Convert.ToInt32(Console.ReadLine());
            Dodac.Add(dodac);
        }
        public void Bot()
        {
            
        }
        public void InRa_ThongTinKH()
        {
            Console.WriteLine($"{Ten} - {Tuoi} - {Diachi} - {SDT}");
        }
    }
}
