using System;

namespace Bai2
{
    class Bai2
    {
        static void Main(string[] args)
        {
            float a, b, c;
            do
            {
                Console.Write("Nhap canh a: ");
                a = float.Parse(Console.ReadLine());
                if (a < 0) Console.WriteLine("Nhap lai!(a>0)");
            } while (a<0);
            do
            {
                Console.Write("Nhap canh b: ");
                b = float.Parse(Console.ReadLine());
                if (b < 0) Console.WriteLine("Nhap lai!(b>0)");
            } while (b < 0);
            do
            {
                Console.Write("Nhap canh c: ");
                c = float.Parse(Console.ReadLine());
                if (c < 0) Console.WriteLine("Nhap lai!(c>0)");
            } while (c < 0);
            if (a + b > c && b + c > a && c + a > b)
            {
                if (a == b && b == c && c == a)
                {
                    Console.WriteLine("tam giac deu");
                }
                else if(a*a+b*b==c*c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    if (a == b || b == c || a == c)
                    {
                        Console.WriteLine("Tam giac vuong can");
                    }
                    else
                    {
                        Console.WriteLine("Tam giac vuong");
                    }
                }
                else Console.WriteLine("Tam giac thuong");
            }
            else
            {
                Console.WriteLine("Khong la 3 canh cua tam giac!");
            }
        }
    }
}
