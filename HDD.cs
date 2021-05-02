using System;
using System.Collections.Generic;
using System.Text;

namespace quanlymaytinh8
{
    class HDD : IThietBi
    {
        float gia;
        string hangSX;
        public string HangSX
        {
            set { hangSX = value; }
            get { return hangSX; }
        }
        public HDD(string line)
        {
            string[] s = line.Split(',');
            HangSX = s[1].Trim();
            Gia = float.Parse(s[2].Trim());
        }
        public float Gia
        {
            set { gia = value; }
            get { return gia; }
        }
        public override string ToString()
        {
            return "HDD Hang " + HangSX + " gia=" + Gia;
        }
    }
}
