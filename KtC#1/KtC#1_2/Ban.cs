﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtC_1_2
{
    internal class Ban : Dodac
    {
        public override void InraThongTin()
        {
            Console.WriteLine($"Bàn có kích thước :{chieudai} - {chieurong} - {chieusau}");
        }
    }
}
