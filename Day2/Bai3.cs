using System;

namespace Bai3
{
    class Bai3
    {
        static String[] str;
        static void Main(string[] args)
        {
            Console.WriteLine("Mhap chuoi s: ");
            String s=Console.ReadLine();
            Split(s);
            Show();
            Console.WriteLine("Tuoi: "+Age());
            Console.ReadKey();
        }
        static void Split(String s)
        {
            str = s.Split(' ');
            Console.Write("str[]={");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]+",");
            }
            Console.WriteLine("}");
        }
        static void Show()
        {
            Console.WriteLine("Ho: "+str[0]);
            Console.WriteLine("Ten Dem: "+str[1]);
            Console.WriteLine("Ten: "+str[2]);
            Console.WriteLine("nam Sinh: "+str[3]);
        }
        static int Age()
        {
            return 2020 - int.Parse(str[str.Length - 1]);
        }
    }
}
