using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hoa
    {
        int ID;string ten;string DiaPhuong;
        public Hoa()
        {
            
        }

        public Hoa(int iD, string ten, string diaPhuong)
        {
            this.ID = iD;
            this.ten = ten;
            this.DiaPhuong = diaPhuong;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaPhuong1 { get => DiaPhuong; set => DiaPhuong = value; }
        public void inthongtin()
        {
            Console.WriteLine($"ID:{ID}, ten:{ten},dia phuong: {DiaPhuong}");
        }

    }
}
