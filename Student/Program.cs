using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sinhVien sv= new sinhVien();
            sv.nhap();
            Console.WriteLine();
            sv.xuat();
            sv.running();
        }
    }
}
