using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtC_1_2
{
    abstract class Dodac
    {
        public int chieudai;
        public int chieurong;
        public int chieusau;
        double thetich;

        double Thetich { get => thetich = chieudai * chieurong * chieusau; }

        protected Dodac()
        {
        }

        protected Dodac(int chieudai, int chieurong, int chieusau, double thetich)
        {
            this.chieudai = chieudai;
            this.chieurong = chieurong;
            this.chieusau = chieusau;
            this.thetich = thetich;
        }

        double TinhThetich()
        {
            return Thetich;
        }
        public void Thetichh(int cd, int cr, int cs)
        {
            chieudai = cd;
            chieurong = cr;
            chieusau = cs;
            TinhThetich();
        }
        public abstract void InraThongTin();
    }
}
