using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class Fruit
    {
        public string nameFruit { get; set; }
        public double fresh { get; set; }

        public void EnterData(){
            Console.WriteLine($"nameFruit = ");
            nameFruit = Console.ReadLine();
            Console.WriteLine($"fresh = ");
            fresh = Convert.ToDouble(Console.ReadLine());
            
        }
        public void Display()
        {
            Console.WriteLine("{0} - {1}", nameFruit, fresh);
        }
    }
}