using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class Employee
    {
        public int maNhanVien { get; private set; }
        public string tenNhanVien { set; get; }
        public int tuoi { set; get; }
        public double luong { get; set; }
        public Employee(int maNhanVien, string tenNhanVien, int tuoi, double luong)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.tuoi = tuoi;
            this.luong = luong;
        }
        public void NhapThongTin()
        {
            Console.WriteLine($"MaNhanVien = ");
            maNhanVien = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"tenNhanVien = ");
            tenNhanVien = Console.ReadLine();
            Console.WriteLine($"tuoi = ");
            tuoi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"luong = ");
            luong = Convert.ToDouble(Console.ReadLine());
        }    
        public void HienThi()
        {
            Console.WriteLine($"{0} - {1} - {2} - {3}", 
            maNhanVien, tenNhanVien, tuoi, luong);  
        }
        public void HienThi(int maNhanVien, string tenNhanVien, int tuoi, double luong)
        {
            Console.WriteLine($"{0} - {1} - {2} - {3}", 
            maNhanVien, tenNhanVien, tuoi, luong); 
        }
        public int LayTuoi(int age)
        {
            return age;
        }
    }
}