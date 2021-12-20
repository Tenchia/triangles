using System;
namespace triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.Write("Выберете метод решения задачи:\n");
            Console.Write("1. По формуле герона\n");
            Console.Write("2. По Внутренннему радиусу\n");
            Console.Write("3. Через высоту\n");
            Console.Write("4. По двум сторонам и углу между ними\n");
            Console.Write("5. По стороне и двум прилежащим углам\n");
            int cases = Convert.ToInt32(Console.ReadLine());
            switch (cases)
            {
                case 1:
                    Console.Write("Введите сторону А\n");
                    triangle.A = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите сторону В\n");
                    triangle.B = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите сторону С\n");
                    triangle.C = Convert.ToDouble(Console.ReadLine());
                    triangle.perimeter();
                    triangle.semiPerimeter();
                    triangle.semiPerimeterSquare();
                    Console.WriteLine("Площадь равна: {0}", triangle.S);
                    break;
                case 2:
                    Console.Write("Введите сторону А\n");
                    triangle.A = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите сторону В\n");
                    triangle.B = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите сторону С\n");
                    triangle.C = Convert.ToDouble(Console.ReadLine());
                    triangle.perimeter();
                    triangle.semiPerimeter();
                    triangle.innerRadius();
                    triangle.innerRadiusSquare();
                    Console.WriteLine("Площадь равна: {0}", triangle.S);
                    break;
                case 3:
                    Console.Write("Введите сторону А\n");
                    triangle.A = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту\n");
                    triangle.h = Convert.ToDouble(Console.ReadLine());
                    triangle.heightSquare();
                    Console.WriteLine("Площадь равна: {0}", triangle.S);
                    break;
                case 4:
                    Console.Write("Введите сторону А\n");
                    triangle.A = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите сторону В\n");
                    triangle.B = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите угол а\n");
                    triangle.a = Convert.ToDouble(Console.ReadLine());
                    triangle.twoSideAngleSquare();
                    Console.WriteLine("Площадь равна: {0}", triangle.S);
                    break;
                case 5:
                    Console.Write("!!!СУММА ВВЕДЕННЫХ УГЛОВ НЕ ДОЛЖНА ПРЕВЫШАТЬ 180 ГРАДУСОВ!!!\n");
                    Console.Write("Введите сторону А\n");
                    triangle.A = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите угол a\n");
                    triangle.a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите угол b\n");
                    triangle.b = Convert.ToDouble(Console.ReadLine());
                    triangle.sideTwoAnglesSquare();
                    Console.WriteLine("Площадь равна: {0}", triangle.S);
                    break;
            }
        }
    }

    class Triangle
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
        public void innerRadius()
        {
            r = Math.Sqrt((p - A)*(p - B)*(p - C) / 2);
        }
        public void semiPerimeterSquare()
        {
            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public void innerRadiusSquare()
        {
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
