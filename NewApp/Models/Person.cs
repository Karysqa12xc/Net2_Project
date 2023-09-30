using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string PersonID { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public Person()
        {
            FullName = "Nguyen Viet Hoang Nam";
            Address = "Ha Noi";
            PersonID = "PS01";
            Age = 22;
        }
        public void EnterData()
        {
            Console.WriteLine($"PersonId: ");
            PersonID = Console.ReadLine() ?? "";
            Console.WriteLine($"FullName: ");
            FullName = Console.ReadLine() ?? "";
            Console.WriteLine($"Address: ");
            Address = Console.ReadLine() ?? "";
            Console.WriteLine($"Age: ");
            Age = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine($"PersonId = {PersonID} - " +
            $"FullName = {FullName}" +
            $" - Address = {Address}" + $" - Age = {Age}");
        }
        public void ModifierInfoPerson(string PersonId)
        {
            if (PersonID.Equals(PersonId))
            {
                FullName = Console.ReadLine() ?? "";
                Address = Console.ReadLine() ?? "";
                Age = int.Parse(Console.ReadLine() ?? "1");
            }
        }
        public int GetYearOfBirth(int age)
        {
            int yearOfBirth = 2023 - age;
            return yearOfBirth;
        }

        public static void CreatePersonByArrayList(ArrayList p)
        {
            int length = int.Parse(Console.ReadLine() ?? "1");
            for (int i = 0; i < length; i++)
            {
                Person ps = new Person();
                ps.EnterData();
                p.Add(ps);
            }
        }
        public static void ModifierArrayList(ArrayList p, string id){
            foreach (Person ps in p)
            {
                ps.ModifierInfoPerson(id);
            }
        }
        public static void PrintAllInfoArrayList(ArrayList p)
        {   
            foreach(Person ps in p){
                ps.Display();
            }
        }
    }
}