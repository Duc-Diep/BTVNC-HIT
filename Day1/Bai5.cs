using System;

namespace Bai5
{
    class Bai5
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            bool check = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) { check = false; break; }
            }
            if (check)
            {
                Console.WriteLine(n + " la so nguyen to");
            }
            else
            {
                Console.WriteLine(n + " khong la so nguyen to");
            }
        }
    }
}
