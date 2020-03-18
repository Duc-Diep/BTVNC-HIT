using System;

namespace Bai4
{
    class Bai4
    {
        struct Date{
            public int Day;
            public int Month;
            public int Year;
        }
        struct Student
        {
            public int ID;
            public String Name;
            public Date DateOfBirth;
        }
        static void InputInfo(out Student s)
        {
            Console.Write("Nhap ID: ");
            s.ID = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: ");
            s.Name = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            s.DateOfBirth.Day = int.Parse(Console.ReadLine());
            Console.Write("Thang sinh: ");
            s.DateOfBirth.Month = int.Parse(Console.ReadLine());
            Console.Write("Nam sinh: ");
            s.DateOfBirth.Year = int.Parse(Console.ReadLine());
        }
        static void ShowInfo(Student s)
        {
            Console.WriteLine (s.ID+"\t"+ s.Name+"\t"+ s.DateOfBirth.Day + "/" + s.DateOfBirth.Month + "/" + s.DateOfBirth.Year);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so sv: ");
            int n = int.Parse(Console.ReadLine());
            Student[] list = new Student[n];
            //Nhap thong tin tung sv
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sv thu "+(i+1));
                InputInfo(out list[i]);
            }
            //Hien thi thong tin all sv
            Console.WriteLine("Ma sv\tTen\tNgay sinh");
            for(int i = 0; i < n; i++)
            {
                ShowInfo(list[i]);
            }
            //Sap xep theo thu tu tang dan cua nam sinh
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (list[i].DateOfBirth.Year > list[j].DateOfBirth.Year)
                    {
                        Student temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            //Hien thi lai danh sach sau khi sap xep
            Console.WriteLine("Danh sach sau khi sap xep theo nam sinh: ");
            Console.WriteLine("Ma sv\tTen\tNgay sinh");
            for (int i = 0; i < n; i++)
            {
                ShowInfo(list[i]);
            }
        }
    }
}
