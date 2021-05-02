using System;
using System.Collections.Generic;
using System.Text;

namespace quanlymaytinh8
{
    class RAM : IThietBi
    {
        float gia;
        string hangSX;
        public string HangSX
        {
            set { hangSX = value; }
            get { return hangSX; }
        }
        public RAM(string line)
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
            return "RAM Hang " + HangSX + " gia=" + Gia;
        }
    }
}
