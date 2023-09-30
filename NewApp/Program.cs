using NewApp.Models;
//* Xây dựng phương thức thêm, xoá, sửa với kiểu collection
//* Array list
Console.WriteLine($"Nhap so luong person: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Person[] People = new Person[n];

for (int i = 0; i < People.Length; i++)
{
    Console.WriteLine($"Them thong tin person {i}: ");
    Person ps = new Person();
    ps.EnterData();
    People[i] = ps;
}

Console.WriteLine($"Nhap id cua person muon sua doi: ");
int id = int.Parse(Console.ReadLine() ?? "0");
People[id].ModifierInfoPerson();

foreach (var Person in People)
{
    Console.WriteLine($"In Ra thong tin person  : ");
    Person.Display();
}