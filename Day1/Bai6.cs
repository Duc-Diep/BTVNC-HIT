using System;

namespace Bai6
{
    class Bai6
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            while (n>0) {
                while (n % i == 0 && n > 0)
                {
                    n /= i;
                    if (n == 1)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + "x");
                    }
                }
                i++;
            }    
        }
    }
}
