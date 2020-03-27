using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class Phieu
    {
        private String codeForm;
        private Date dateForm;
        private Phong roomForm;
        private TaiSan[] x;
        private int n;
        public Phieu()
        {

        }
        public string CodeForm { get => codeForm; set => codeForm = value; }
        public int N { get => n; set => n = value; }
        internal Phong RoomForm { get => roomForm; set => roomForm = value; }
        internal TaiSan[] X { get => x; set => x = value; }
        internal Date DateForm { get => dateForm; set => dateForm = value; }
        public void nhap()
        {
            Console.WriteLine("Nhap ma phieu: ");
            this.codeForm = Console.ReadLine();
            dateForm = new Date();
            Console.WriteLine("Nhap ngay kiem ke: ");
            dateForm.nhap();
            roomForm = new Phong();
            Console.WriteLine("Nhap thong tin phong kiem ke: ");
            roomForm.nhap();
            Console.WriteLine("Nhap so luong tai san: ");
            this.n = int.Parse(Console.ReadLine());
            x = new TaiSan[n];
            for(int i = 0; i < n; i++)
            {
                x[i] = new TaiSan();
                Console.WriteLine("Nhap thong tin tai san thu "+(i+1));
                x[i].nhap();
            }
        }
        public int Tongsohang()
        {
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += x[i].Number;
            }
            return sum;
        }
        public void xuat()
        {
            Console.WriteLine("Ma phieu: "+this.codeForm +"\nNgay kiem ke: ");
            dateForm.xuat();
            roomForm.xuat();
            foreach (TaiSan i in x)
            {
                i.xuat();
            }
            Console.WriteLine("So tai san da kiem ke: "+n);
            Console.WriteLine("Tong so luong: "+Tongsohang());
        }
    }
    
}
