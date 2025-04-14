using bai2;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<Hinh> danhSachHinh = new List<Hinh>
        {
            new HinhTron(3),
            new HinhVuong(4),
            new HinhChuNhat(5, 3),
            new HinhTamGiac(3, 4, 5)
        };

        double tongChuVi = 0, tongDienTich = 0;

        foreach (var hinh in danhSachHinh)
        {
            tongChuVi += hinh.TinhChuVi();
            tongDienTich += hinh.TinhDienTich();
        }

        Console.WriteLine($"Tổng chu vi các hình: {tongChuVi:F2}");
        Console.WriteLine($"Tổng diện tích các hình: {tongDienTich:F2}");
    }
}
