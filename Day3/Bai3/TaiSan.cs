using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class TaiSan
    {
        private String name;
        private int number;
        private String status;

        public string Name { get => name; set => name = value; }
        public int Number { get => number; set => number = value; }
        public string Status { get => status; set => status = value; }
        public void nhap()
        {
            Console.Write("Nhap ten san pham: ");
            this.name = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            this.number = int.Parse(Console.ReadLine());
            Console.Write("Nhap trang thai: ");
            this.status = Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("Ten San pham: "+this.name+", So luong: "+this.number+", Trang thai: "+this.status);
        }
    }
    
}
