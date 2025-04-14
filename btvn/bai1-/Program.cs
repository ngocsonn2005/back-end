using bai1_;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<PhanSo> danhSach = new List<PhanSo>();

        Console.Write("Nhập số lượng phân số: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập phân số thứ {i + 1}:");
            PhanSo ps = new PhanSo();
            ps.Nhap();
            danhSach.Add(ps);
        }

        PhanSo tong = new PhanSo(0, 1);
        foreach (var ps in danhSach)
        {
            tong = tong.Cong(ps);
        }

        Console.WriteLine($"Tổng các phân số là: {tong}");
    }
}
