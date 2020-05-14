using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class SInhVienHaUI
    {
        private String name;
        private String gt;
        private String country;
        private String married;

        public string Name { get => name; set => name = value; }
        public string Gt { get => gt; set => gt = value; }
        public string Country { get => country; set => country = value; }
        public string Married { get => married; set => married = value; }
        public SInhVienHaUI()
        {

        }
        public void input()
        {
            Console.Write("Nhap ho ten : ");
            this.name = Console.ReadLine();
            Console.Write("Nhap gioi tinh : ");
            this.gt = Console.ReadLine();
            Console.Write("Nhap que quan : ");
            this.country = Console.ReadLine();
            Console.Write("Nhap tinh trang hon nhan(da co ny/ chua co ny) : ");
            this.Married = Console.ReadLine();
        }
        public void output()
        {
            Console.Write("Ho ten: "+this.name +", Gioi tinh: "+this.gt +", Que quan: "+this.country + ", Tinh trang hon nhan: "+this.married+", ");
        }
    }
}
