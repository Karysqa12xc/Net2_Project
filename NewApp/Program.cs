using System.Runtime.CompilerServices;
using NewApp.Models;

// TODO: Khoi tao doi tuong
Person ps1 = new Person();
Person ps2 = new Person();
SinhVien std1 = new SinhVien();
//* gan gia tri cho thuoc tinh doi tuong ps1
ps1.FullName = "Nguyen Van A";
ps1.Address = "Ha Noi";
ps1.Age = 18;
//* Khai bao 2 bien va gan gia tri
string str = "Nguyen Van B";
int a = 22;
//* Goi phuong thuc hien thi thong tin
ps1.Display();
ps2.Display();
std1.Display(str, a);