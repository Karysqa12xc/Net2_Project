using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        // TODO: Khoi tao hai doi tuong
        Person ps1 = new Person();    
        Person ps2 = new Person();
        // TODO: Gan thuoc tinh vao doi tuong cua phuong thuc 1
        ps1.FullName = "Nguyen Van A";
        ps1.Address = "Ha Noi";
        ps1.Age = 18;
        // TODO: Hien thi thuoc tinh cua doi tuong ps1
        ps1.Display();
        // TODO: Nhap thong tin cua doi tuong ps2
        ps2.EnterData();
        // TODO: Hien thi thong tin thuoc tinh cua ps2
        ps2.Display();

        // TODO: Khoi tao doi tuong student, employee, fruit
        Student st1 = new Student();
        Employee emp1 = new Employee();
        Fruit fr1 = new Fruit();
        // TODO: Nhap thong tin cua doi tuong st1, emp1, fr1
        st1.EnterData();
        emp1.NhapThongTin();
        fr1.EnterData();
        // TODO: Hien thi thong tin cua doi tuong st1, emp1, fr1
        Console.WriteLine($"Nhap thong tin Student");
        st1.Display();
        Console.WriteLine($"Nhap thong tin Employee");
        emp1.HienThi();
        Console.WriteLine($"Nhap thong tin Fruit");
        fr1.Display();
    }
}
