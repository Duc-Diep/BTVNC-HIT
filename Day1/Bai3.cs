using System;

namespace Bai3
{
    class Bai3
    {
        static void Main(string[] args)
        {
            
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cac uoc cua n la: ");
            int i = 1;
            while (i <= n)
            {
                if (n % i == 0) Console.Write(i+" ");
                i++;
            }
        }
    }
}
