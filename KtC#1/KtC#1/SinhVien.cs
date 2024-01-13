using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtC_1
{
    internal class SinhVien
    {
        string MaSv;
        string Ten;
        int NamSinh;
        double Diem;

        public string MaSv1 { get => MaSv; set => MaSv = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public int NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public double Diem1 { get => Diem; set => Diem = value; }

        public SinhVien()
        {
        }

        public SinhVien(string maSv, string ten, int namSinh, double diem)
        {
            MaSv = maSv;
            Ten = ten;
            NamSinh = namSinh;
            Diem = diem;
        }

        public virtual void inThongTin()
        {
            Console.WriteLine($"{MaSv} - {Ten} - {NamSinh} - {Diem}");
        }
    }
}
