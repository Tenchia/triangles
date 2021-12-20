using System;
namespace triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class triangle
    {
        public double A, B, C, a, b, c, p, r, h, S, P;

        public void perimeter()
        {
            P = A + B + C;
        }
        public void semiPerimeter()
        {
            p = P / 2;
        }
        public void semiPerimeterSquare()
        {
            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public void innerRadiusSquare()
        {
            r = Math.Sqrt((p - A)*(p - B)*(p - C) / 2);
            S = r * (P / 2);
        }


    }
}
