using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэфициенты квадратного уравнения a,b,c");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x1, x2, D;
            D = (b * b) - (4 * a * c);
                if (D > 0)
                {
                    x1 = (-b + (Math.Sqrt(D))) / (2 * a);
                    x2 = (-b - (Math.Sqrt(D))) / (2 * a);
                    Console.WriteLine("x1={0}, x2={1}", x1, x2);
                }
                else { Console.WriteLine("Нет действительных корней"); }
            Console.ReadLine();
        }
    }
}


