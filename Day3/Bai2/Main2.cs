using System;

namespace Bai2
{
    class Main2
    {
        static void Main(string[] args)
        {
            TamThucBac2 x = new TamThucBac2(1, 1, 1);
            TamThucBac2 y = new TamThucBac2(2, 2, 2);
            TamThucBac2 xsub = new TamThucBac2();
            TamThucBac2 ysub = new TamThucBac2();
            xsub = -x;
            ysub = -y;
            xsub.xuat();
            ysub.xuat();
            TamThucBac2 sum = new TamThucBac2();
            sum = xsub + ysub;
            sum.xuat();
        }
    }
}
