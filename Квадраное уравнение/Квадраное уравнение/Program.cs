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
            if (a != 0)
            {
                if (b != 0)
                {
                    if (c != 0)
                    {
                        if (D != 0)
                        {
                            if (D > 0)
                            {
                                x1 = (-b + (Math.Sqrt(D))) / (2 * a);
                                x2 = (-b - (Math.Sqrt(D))) / (2 * a);
                                Console.WriteLine("x1={0}, x2={1}", x1, x2); //2 корня
                            }
                            else { Console.WriteLine("Нет действительных корней"); } //нет
                        }
                        else { x1 = -b / (2 * a); Console.WriteLine("x={0}", x1); } //1 корень
                    }
                    else { x1 = 0; x2 = -b / a; Console.WriteLine("x1={0}, x2={1}", x1, x2); } //2 корня
                }
                else
                {
                    if ((-c / a) >= 0) { x1 = -Math.Sqrt(-c / a); x2 = Math.Sqrt(-c / a); Console.WriteLine("x1={0}, x2={1}", x1, x2); } //2 корня
                    else { Console.WriteLine("Нет действительных корней"); } //нет 
                }
            }
            else
            {
                if (b != 0)
                {
                    x1 = -c / b;
                    Console.WriteLine("x={0}", x1); //1 корень
                }
                else { if (c != 0) Console.WriteLine("нет решений"); //нет
                        else Console.WriteLine("Х-любое"); }//любое
            }
            Console.ReadLine();
        }
    }
}


