using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class Date
    {
        private int day, month, year;

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public void nhap()
        {
            Console.Write("Nhap ngay: ");
            this.day = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            this.month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            this.year = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.Write(this.day+"/"+this.month+"/"+this.year);
        }
         
    }
}
