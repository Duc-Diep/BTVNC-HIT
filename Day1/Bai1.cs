using System;

namespace Bai1
{
    class Bai1
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            Console.Write("Nhap so thu 1: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 2: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 3: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 4: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 5: ");
            e = int.Parse(Console.ReadLine());
            int max1 = a;
            if (max1 < b) max1 = b;
            if (max1 < c) max1 = c;
            if (max1 < d) max1 = d;
            if (max1 < e) max1 = e;
            int max2 = a;
            if (max2 < b && b < max1) max2 = b;
            if (max2 < c && c < max1) max2 = c;
            if (max2 < d && d < max1) max2 = d;
            if (max2 < e && e < max1) max2 = e;
            Console.WriteLine("So lon thu 2 la: "+max2);
        }
    }
}
