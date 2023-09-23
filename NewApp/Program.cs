using System.Runtime.CompilerServices;
using NewApp.Models;

// TODO: Khoi tao doi tuong
Person ps1 = new Person();
//* Khai bao 2 bien va gan gia tri
string str = "Nguyen Van A";
int a = 22;
Console.WriteLine($"{str} sinh nam {ps1.GetYearOfBirth(a)}");

