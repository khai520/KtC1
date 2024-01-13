using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtC_1 
{
    internal class SinhVienUD : SinhVien
    {
        int Kihoc;

        public int Kihoc1 { get => Kihoc; set => Kihoc = value; }

        public SinhVienUD()
        {
        }

        public SinhVienUD(int kihoc)
        {
            Kihoc = kihoc;
        }
        public override void inThongTin()
        {
            Console.WriteLine($"{MaSv1} - {Ten1} - {NamSinh1} - {Diem1} - {Kihoc1}");
        }
    }
}
