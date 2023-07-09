using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class sinhVien
    {
        public string name { get; set; }
        public int age { get; set; }
        public int id { get; set; }
     public void nhap()
        {
            Console.WriteLine("nhap ten");
            name= Console.ReadLine();
            Console.WriteLine("nhap tuoi");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ma sinh vien");
            id=Convert.ToInt32(Console.ReadLine());
        }
     public void xuat()
        {
            Console.WriteLine(name); 
            Console.WriteLine(age); 
            Console.WriteLine(id); 
            Console.WriteLine();
        }
    public void running()
        {
            Console.WriteLine("nguoi chay nhanh nhat ten la " + name);
        }
    }
}
