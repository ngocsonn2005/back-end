using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class HinhVuong : Hinh
    {
        private double canh;

        public HinhVuong(double c)
        {
            canh = c;
        }

        public override double TinhChuVi() => 4 * canh;
        public override double TinhDienTich() => canh * canh;
    }
}
