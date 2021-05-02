using System;
using System.Collections.Generic;
using System.Text;

namespace quanlymaytinh8
{
    class CPU : IThietBi
    {
        float gia;
        string hangSX;
        public float Gia
        {
            set
            { gia = value; }
            get { return gia; }
        }
        public string HangSX
        {
            set { hangSX = value; }
            get { return hangSX; }
        }
        public CPU(string line)
        {
            string[] s = line.Split(',');
            HangSX = s[1].Trim();
            Gia = float.Parse(s[2].Trim());
        }
        public override string ToString()
        {
            return "CPU hang" + HangSX + " gia=" + Gia;
        }

    }
}
