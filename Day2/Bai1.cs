using System;

namespace BTVNB2
{
    class Bai1
    {
        
        static void Main(string[] args)
        {
            int n = inputn();
            int[] a = new int[n];
            Console.WriteLine("Nhap mang: ");
            inputArr(a, n);
            Console.WriteLine("Vi tri cua cac so nguyen to trong mang");
            IndexOfPrime(a);
            Console.ReadKey();
        }
        static int inputn()
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen duong n: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0) Console.WriteLine("Nhap lai! ");
            } while (n < 0);
            return n;
        }
        static void inputArr(int[] arr,int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("a["+i+"]=");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static bool isPrime(int n)
        {
            if (n < 2) return false;
            else
            {
                for(int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return false;
                }
            }
            return true;
        }
        static void IndexOfPrime(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (isPrime(arr[i]))
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
