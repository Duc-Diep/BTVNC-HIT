using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class NhanVien
    {
        private String name;
        private String position;

        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }

        public void nhap()
        {
            Console.WriteLine("Nhap ten nhan vien: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Nhap chuc vu: ");
            this.position = Console.ReadLine();
        }
        public void xuat()
        {
            Console.Write("\nNhan Vien: "+this.name+", Chuc vu: "+this.position+", ");
        }
    }
}
