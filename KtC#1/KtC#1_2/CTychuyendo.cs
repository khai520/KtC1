using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtC_1_2
{
    internal class CTychuyendo
    {
        Khachhang khachhang = new Khachhang();
        public ArrayList ThemKH()
        {
            Console.WriteLine("Nhập tên:");
            Console.WriteLine("Nhập Tuổi:");

        }
        public void XoaKH(ArrayList arrayList) 
        {
            arrayList.Remove(arrayList);
        }
    }
}
