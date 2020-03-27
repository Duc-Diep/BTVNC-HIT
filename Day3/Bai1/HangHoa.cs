using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class HangHoa
    {
        private String maHang;
        private String tenHang;
        private long donGia;
        private int soLuong;

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public long DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public void NHAP()
        {
            Console.Write("Nhap ma hang:");
            this.maHang = Console.ReadLine();
            Console.Write("Nhap ten hang: ");
            this.tenHang = Console.ReadLine();
            Console.Write("Nhap don gia: ");
            this.donGia = long.Parse(Console.ReadLine());
            Console.Write("Nhap so luong: ");
            this.soLuong = int.Parse(Console.ReadLine());
        }
        public long THANHTIEN()
        {
            return this.donGia * this.soLuong;
        }
        public void XUAT()
        {
            Console.WriteLine("Ma hang: "+this.maHang+", Ten hang: "+this.tenHang+", Don gia: "+this.donGia+", So luong: "+this.soLuong +", Thanh tien: "+THANHTIEN());
        }
        public void SAPXEP(HangHoa[] list,int n)
        {
            for(int i = 0; i < n-1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (list[i].THANHTIEN() > list[j].THANHTIEN())
                    {
                        HangHoa temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
        
    }
}
