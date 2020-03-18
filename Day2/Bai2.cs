using System;

namespace Bai2
{
    class Bai2
    {
        static void Main(string[] args)
        {
            float A,x;
            int n;
            inputNumber(out A, out x, out n);
            Cal(A, x, n);
        }
        static void inputNumber(out float A,out float x, out int n)
        {
            Console.Write("Nhap so thuc A: ");
            A = float.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap so thuc x: ");
                x = float.Parse(Console.ReadLine());
                if (x < 0) Console.WriteLine("Nhap lai! (x>0)");
            } while (x < 0);
            do
            {
                Console.Write("Nhap so nguyen n: ");
                n = int.Parse(Console.ReadLine());
                if (n < 5 || n > 20) Console.WriteLine("Nhap lai! (5<=n<=20)");
            } while (n<5||n>20);
        }
        static float xk(float x,int k)
        {
            return (float)Math.Sqrt(Math.Pow(x, k));
        }
        static void Cal(float A,float x,int n)
        {
            float S = A;
            for(int i = 1; i <= n; i++)
            {
                S += (float)Math.Pow(-1, i) * xk(x, i) / (n + 1 - i);
            }
            Console.WriteLine("S= "+S);
        }
    }
}
