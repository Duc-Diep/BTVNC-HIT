using System;

namespace Bai7
{
    class Bai7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thuc c: ");
            float c = float.Parse(Console.ReadLine());
            float mu = 1, gt = 1, i = 1;
            float ex = 0;
            while ((mu / gt) >= c)
            {
                ex += mu / gt;
                mu *= x;
                gt *= i;
                i++;
            }
            Console.WriteLine("e^" + x + "=" + ex);
        }
    }
}
