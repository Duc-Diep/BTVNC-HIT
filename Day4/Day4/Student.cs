using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class Student:SInhVienHaUI
    {
        int liab;
        public int Liab { get => liab; set => liab = value; }
        public Student()
        {
            this.liab = 10000;
        }
        public void ThanhToan(int money)
        {
            this.liab -= money;
        }
        public void input()
        {
            base.input();
        }
        public void output()
        {
            base.output();
            Console.Write(" Cong no: "+this.liab+"\n");
        }
    }
}
