using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class SinhVien
    {
        public string Hoten { get; set; }
        public string DiaChi { get; set; }
        public int tuoi { get; set; }
        public int soDienThoai { set; get; }

        public void NhapThongTin()
        {
            Console.WriteLine($"HoTen = ");
            Hoten = Console.ReadLine();
            Console.WriteLine($"DiaChi = ");
            DiaChi = Console.ReadLine();
            Console.WriteLine($"tuoi = ");
            tuoi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"soDienThoai = ");
            soDienThoai = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
          Console.WriteLine($"{0} - {1} - {2} - {3}"
          , Hoten, DiaChi, tuoi, soDienThoai);
            
        }
        public void Display(string ten, int tuoi)
        {
            Console.WriteLine("Sinh vien {0} - {1} tuoi", ten, tuoi);
        }
        public void Display(string ten, string diaChi)
        {
            Console.WriteLine("Sinh vien {0} - {1}", ten, diaChi);    
        }
    }
}
