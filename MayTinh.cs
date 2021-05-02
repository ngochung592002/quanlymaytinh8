using System;
using System.Collections.Generic;
using System.Text;

namespace quanlymaytinh8
{
    class MayTinh
    {
        List<IThietBi> ds = new List<IThietBi>();
        public void Them(IThietBi hh)
        {
            ds.Add(hh);
        }
        public float TongGia()
        {
            float tong = 0;
            foreach (var item in ds)
            {
                tong += item.Gia;
            }
            return tong;
        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in ds)
            {
                s = s + item + '\n';
            }
            s = s + "Tong Gia La" + TongGia();
            return s;
        }
        public float GiaCPU()
        {
            float gia = 0;
            foreach (var item in ds)
            {
                if (item is CPU)
                {
                    gia = gia + ((CPU)item).Gia;
                }
            }
            return gia;
        }
        public int DemTheoHang(string hang)
        {
            int dem = 0;
            foreach (var item in ds)
            {
                if (item.HangSX == hang)
                {
                    dem++;
                }
            }
            return dem;
        }
        public List<string> TimDanhSachHang()
        {
            List<string> kq = new List<string>();
            foreach (var item in ds)
            {
                kq.Add(item.HangSX);
            }
            return kq;
        }
        public int DemTheoHangSXCPU(string hang)
        {
            int dem = 0;
            foreach (var item in ds)
            {
                if (item is CPU && item.HangSX == hang)
                {
                    dem++;
                }
            }
            return dem;
        }
        public List<string> TimTheoHangCPU()
        {
            List<string> kq = new List<string>();
            foreach (var item in ds)
            {
                if (item is CPU)
                {
                    kq.Add(((CPU)item).HangSX);
                }
            }
            return kq;
        }


    }
}
