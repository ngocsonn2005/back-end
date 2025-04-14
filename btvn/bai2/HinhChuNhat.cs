using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class HinhChuNhat : Hinh
    {
        private double dai, rong;

        public HinhChuNhat(double d, double r)
        {
            dai = d;
            rong = r;
        }

        public override double TinhChuVi() => 2 * (dai + rong);
        public override double TinhDienTich() => dai * rong;
    }
}
