using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_
{
    class PhanSo
    {
        public int Tu { get; set; }
        public int Mau { get; set; }

        public PhanSo() { }

        public PhanSo(int tu, int mau)
        {
            Tu = tu;
            Mau = mau != 0 ? mau : 1;
            RutGon();
        }

        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            Tu = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhập mẫu số (khác 0): ");
                Mau = int.Parse(Console.ReadLine());
            } while (Mau == 0);

            RutGon();
        }

        public PhanSo Cong(PhanSo ps)
        {
            int tuMoi = this.Tu * ps.Mau + ps.Tu * this.Mau;
            int mauMoi = this.Mau * ps.Mau;
            return new PhanSo(tuMoi, mauMoi);
        }

        private void RutGon()
        {
            int ucln = UCLN(Math.Abs(Tu), Math.Abs(Mau));
            Tu /= ucln;
            Mau /= ucln;
        }

        private int UCLN(int a, int b)
        {
            return b == 0 ? a : UCLN(b, a % b);
        }

        public override string ToString()
        {
            return $"{Tu}/{Mau}";
        }
    }

   
}
