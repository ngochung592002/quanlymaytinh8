using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace quanlymaytinh8
{
    class DanhSachMayTinh
    {
        List<MayTinh> ds = new List<MayTinh>();

        public void NhapTuFile()
        {
            string path = @"data.txt";
            StreamReader a = new StreamReader(path);
            string line = "";
            while ((line = a.ReadLine()) != null)
            {
                string[] d = line.Split('*');
                MayTinh hh = new MayTinh();
                foreach (var item in d)
                {
                    if (item.IndexOf("CPU") == 0)
                    {
                        hh.Them(new CPU(item));
                    }
                    if (item.IndexOf("RAM") == 0)
                    {
                        hh.Them(new RAM(item));
                    }
                    if (item.IndexOf("HDD") == 0)
                    {
                        hh.Them(new HDD(item));
                    }

                }
                Them(hh);
            }

        }

        public void Them(MayTinh hh)
        {
            ds.Add(hh);
        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in ds)
            {
                s += item + "\n";
                s += "\n";
            }

            return s;
        }
        public void ThemDanhSachHang(List<string> kq, List<string> hang)
        {
            foreach (var item in hang)
            {
                if (!kq.Contains(item))
                    kq.Add(item);
            }
        }
        public List<string> TimDanhSachHang()
        {
            List<string> kq = new List<string>();
            foreach (var item in ds)
            {
                ThemDanhSachHang(kq, item.TimDanhSachHang());
            }
            return kq;
        }
        public int DemThietBiTheoHang(string hang)
        {
            int dem = 0;
            foreach (var item in ds)
            {
                dem = dem + item.DemTheoHang(hang);
            }
            return dem;
        }
        public int TimThietBiNhieuNhat()
        {
            int max = -1;
            List<string> hang = TimDanhSachHang();
            foreach (var item in hang)
            {
                int tam = DemThietBiTheoHang(item);
                if (tam > max)
                {
                    max = tam;
                }
            }
            return max;
        }
        public List<string> TimThietBiXuatHienNhieuNhat()
        {
            List<string> kq = new List<string>();
            List<string> ds = TimDanhSachHang();
            foreach (var item in ds)
            {
                int tam = DemThietBiTheoHang(item);
                if (tam == TimThietBiNhieuNhat())
                {
                    kq.Add(item);
                }
            }
            return kq;
        }
        public float CPUReNhat()
        {
            float max = float.MaxValue;
            foreach (var item in ds)
            {
                if (item.GiaCPU() < max)
                {
                    max = item.GiaCPU();
                }
            }
            return max;
        }
        public float CPULonNhat()
        {
            float max = float.MinValue;
            foreach (var item in ds)
            {
                if (item.GiaCPU() > max)
                {
                    max = item.GiaCPU();
                }
            }
            return max;
        }
        public DanhSachMayTinh DanhSachMayTinhCoCPUReNhat()
        {
            DanhSachMayTinh a = new DanhSachMayTinh();
            foreach (var item in ds)
            {
                if (item.GiaCPU() == CPUReNhat())
                {
                    a.Them(item);
                }
            }
            return a;
        }
        public DanhSachMayTinh DanhSachMayTinhCoCPULonNhat()
        {
            DanhSachMayTinh a = new DanhSachMayTinh();
            foreach (var item in ds)
            {
                if (item.GiaCPU() == CPULonNhat())
                {
                    a.Them(item);
                }
            }
            return a;
        }
        public void ThemDanhSachHangCPU(List<string> kq, List<string> hang)
        {
            foreach (var item in hang)
            {
                if (!kq.Contains(item))
                    kq.Add(item);
            }
        }
        public List<string> TimDanhSachHangCPU()
        {
            List<string> kq = new List<string>();
            foreach (var item in ds)
            {
                ThemDanhSachHangCPU(kq, item.TimTheoHangCPU());
            }
            return kq;
        }
        public int DemThietBiTheoHangCPU(string hang)
        {
            int dem = 0;
            foreach (var item in ds)
            {
                dem = dem + item.DemTheoHang(hang);
            }
            return dem;
        }
        public int TimHangCPUNhieuNhat()
        {
            int max = -1;
            List<string> hang = TimDanhSachHangCPU();
            foreach (var item in hang)
            {
                int tam = DemThietBiTheoHangCPU(item);
                if (tam > max)
                {
                    max = tam;
                }
            }
            return max;
        }
        public List<string> TimThietBiXuatHienNhieuNhatCPU()
        {
            List<string> kq = new List<string>();
            List<string> ds = TimDanhSachHangCPU();
            foreach (var item in ds)
            {
                int tam = DemThietBiTheoHang(item);
                if (tam == TimHangCPUNhieuNhat())
                {
                    kq.Add(item);
                }
            }
            return kq;
        }
        public int TimHangCPUItNhat()
        {
            int max = int.MaxValue;
            List<string> hang = TimDanhSachHangCPU();
            foreach (var item in hang)
            {
                int tam = DemThietBiTheoHangCPU(item);
                if (tam < max)
                {
                    max = tam;
                }
            }
            return max;
        }
        public List<string> TimThietBiXuatHienItNhatCPU()
        {
            List<string> kq = new List<string>();
            List<string> ds = TimDanhSachHangCPU();
            foreach (var item in ds)
            {
                int tam = DemThietBiTheoHangCPU(item);
                if (tam == TimHangCPUItNhat())
                {
                    kq.Add(item);
                }
            }
            return kq;
        }
    }
}
