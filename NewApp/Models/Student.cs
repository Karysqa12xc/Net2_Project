using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class Student
    {
        public string name { get; set; }
        public int classOfStudent { get; set; }
        public Student()
        {
            name = "";
            classOfStudent = 0;
        }
        public void EnterData()
        {
            Console.WriteLine($"name = ");
            name = Console.ReadLine() ?? "";
            Console.WriteLine($"classOfStudent = ");
            classOfStudent = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine($"{0} - {1}", name, classOfStudent);
        }
        public void Display(string name, int classOfStudent)
        {
          Console.WriteLine($"{0} - {1}", name, classOfStudent);
        }
        public int ReturnClassNumber(int classNum)
        {
            return classNum;
        }
    }
}