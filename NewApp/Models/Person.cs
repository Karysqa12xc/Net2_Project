using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public Person()
        {
            FullName = "Nguyen Viet Hoang Nam";
            Address = "Ha Noi";
            Age = 22;
        }
        public void EnterData()
        {
            Console.WriteLine($"FullName: ");
            FullName = Console.ReadLine();
            Console.WriteLine($"Address: ");
            Address = Console.ReadLine();
            Console.WriteLine($"Age: ");
            Age = Convert.ToInt16(Console.ReadLine());    
        }
        public void Display()
        {
            Console.WriteLine($"FullName = {FullName}" +
            $" - Address = {Address}" + $" - Age = {Age}");
        }
        public int GetYearOfBirth(int age)
        {
            int yearOfBirth = 2023 - age;
            return yearOfBirth;
        }
    }
}