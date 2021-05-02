using System;

namespace quanlymaytinh8
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachMayTinh ds = new DanhSachMayTinh();

            ds.NhapTuFile();
            Console.WriteLine("Danh sach may tinh la ");
            Console.WriteLine(ds.ToString());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ds.DanhSachMayTinhCoCPUReNhat());
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(ds.DanhSachMayTinhCoCPULonNhat());
            Console.ResetColor();


            Console.WriteLine(" Hang xuat hien nhieu nhat la ");
            foreach (string s in ds.TimThietBiXuatHienNhieuNhat())
            {
                Console.WriteLine(s + " so lan " + ds.DemThietBiTheoHang(s));
            }
            Console.WriteLine(" Hang CPU xuat hien nhieu nhat la ");
            foreach (string s in ds.TimThietBiXuatHienNhieuNhatCPU())
            {
                Console.WriteLine(s + " so lan " + ds.DemThietBiTheoHangCPU(s));
            }
            Console.WriteLine(" Hang CPU xuat hien it nhat la ");
            foreach (string s in ds.TimThietBiXuatHienItNhatCPU())
            {
                Console.WriteLine(s + " so lan " + ds.DemThietBiTheoHangCPU(s));
            }
            Console.ReadKey();
        }
    }
}
