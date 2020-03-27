using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class TamThucBac2
    {
        private float a, b, c;

        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }
        public float C { get => c; set => c = value; }

        public TamThucBac2()
        {

        }
        public TamThucBac2(float a,float b,float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void xuat()
        {
            Console.WriteLine(this.a + "x^2 + "+this.b+"x + "+this.c);
        }
        public static TamThucBac2 operator -(TamThucBac2 x)
        {
            x.A *= -1;
            x.B *= -1;
            x.C *= -1;
            return x;
        }
        public static TamThucBac2 operator +(TamThucBac2 x,TamThucBac2 y)
        {
            TamThucBac2 sum = new TamThucBac2();
            sum.A = x.A + y.A;
            sum.B = x.B + y.B;
            sum.C = x.C + y.C;
            return sum;
        }
        public static TamThucBac2 operator -(TamThucBac2 x, TamThucBac2 y)
        {
            TamThucBac2 subtract = new TamThucBac2();
            subtract.A = x.A - y.A;
            subtract.B = x.B - y.B;
            subtract.C = x.C - y.C;
            return subtract;
        }
    }
}
