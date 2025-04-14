using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class HinhTron : Hinh
    {

        private double banKinh;

        public HinhTron(double r)
        {
            banKinh = r;
        }

        public override double TinhChuVi() => 2 * Math.PI * banKinh;
        public override double TinhDienTich() => Math.PI * banKinh * banKinh;
    }
}
