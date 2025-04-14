using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class HinhTamGiac : Hinh
    {
        private double a, b, c;

        public HinhTamGiac(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }

        public override double TinhChuVi() => a + b + c;

        public override double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Heron
        }
    }
}
