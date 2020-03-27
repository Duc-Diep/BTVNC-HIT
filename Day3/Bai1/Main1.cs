using System;

namespace Bai1
{
    class Main1
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Nhap so luong hang hoa: ");
            int n = int.Parse(Console.ReadLine());
            HangHoa[] list = new HangHoa[n];
            for(int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("Nhap thong tin mat hang thu "+(i+1));
                list[i] = new HangHoa();
                list[i].NHAP();
            }
            list[0].SAPXEP(list,n);
            foreach (HangHoa x in list)
            {
                x.XUAT();
            }
        }
        
    }
}
