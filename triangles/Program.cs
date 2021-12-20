using System;
namespace triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выберете метод решения задачи:\n");
            Console.Write("1. По формуле герона\n");
            Console.Write("2. По Внутренннему радиусу\n");
            Console.Write("3. Через высоту\n");
            Console.Write("4. По двум сторонам и углу между ними\n");
            Console.Write("5. По стороне и двум прилежащим углам\n");
            int cases = Convert.ToInt32(Console.ReadLine());
            switch (cases)
            {
             
            }
        }
    }

    class triangle
    {
        public double A, B, C, a, b, c, p, r, h, S, P, R;

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
            S = r * p;
        }

        public void heightSquare()
        {
            S = A / 2 * h;
        }

        public void twoSideAngleSquare()
        {
            S = A / 2 * B * Math.Sin(a);
        }
        
        public void sideTwoAnglesSquare()
        {
            S = Math.Pow(A, 2) / 2 * (Math.Sin(a) * Math.Sin(b) / Math.Sin(180 - (a + b)));
        }


    }
}
