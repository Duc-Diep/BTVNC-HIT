using System;
using System.Collections.Generic;

namespace Day4
{
    class CLB
    {
        static List<Student> listst = new List<Student>();
        static List<Leader> listld = new List<Leader>();
        static int m, n;//m: so leader,n: so hoc vien
        static void Main(string[] args)
        {
            String name="";
            int money=0;
            inputall();
            outputall();
            Random();
            ThanhToan(name,money);
            TangCongNo();
            Console.ReadKey();
        }
        static void inputall()
        {
            Console.Write("Nhap so luong leader: ");
            m = int.Parse(Console.ReadLine());
            for(int i = 0; i < m; i++)
            {
                Leader a = new Leader();
                Console.WriteLine("\nNhap thong tin leader thu "+(i+1));
                a.input();
                listld.Add(a);
            }

            Console.Write("\nNhap so luong hoc vien: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student a = new Student();
                Console.WriteLine("\nNhap thong tin hoc vien thu " + (i + 1));
                a.input();
                listst.Add(a);
            }
        }
        static void outputall()
        {
            Console.Write("\nDanh sach leader: \n");
            for(int i = 0; i < m; i++)
            {
                listld[i].output();
            }
            Console.Write("\nDanh sach hoc vien: \n");
            for (int i = 0; i < n; i++)
            {
                listst[i].output();
            }
        }
        static void Random()
        {
            Random rd = new Random();
            int i = rd.Next(0, n - 1);
            Console.Write("\nHoc vien ngau nhien khong co ny: \n");
            while (listst[i].Married.CompareTo("da co ny") == 0)
            {
                i = rd.Next(0, n - 1);
            }
            listst[i].output();
        }
        static void ThanhToan(String name,int money)
        {
            int dem = 0;
            Console.Write("Nhap ten hoc vien can thanh toan:");
            name = Console.ReadLine();
            for(int i = 0; i < n; i++)
            {
                if (listst[i].Name.Equals(name))
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                Console.Write("Khong co hoc vien nao ten: "+name);
            }
            else
            {
                Console.Write("Nhap so tien can thanh toan: ");
                money = int.Parse(Console.ReadLine());
                for(int i = 0; i < n; i++)
                {
                    if (listst[i].Name.Equals(name))
                    {
                        listst[i].ThanhToan(money);
                    }
                }
                Console.WriteLine("\nDanh sach hoc vien sau khi thanh toan: ");
                foreach (Student st in listst)
                {
                    st.output();
                }
            }
        }
        static void TangCongNo()
        {
            for(int i = 0; i < n; i++)
            {
                if(listst[i].Married.CompareTo("da co ny") == 0)
                {
                    listst[i].ThanhToan(-5000);
                }
            }
            Console.WriteLine("\n Danh sach sau khi tang cong no nhung ai co ny");
            foreach(Student st in listst)
            {
                st.output();
            }
        }
    }
}
