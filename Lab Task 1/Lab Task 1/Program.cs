using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
        //1
            Console.WriteLine("Hello World ");
            Console.WriteLine("Susmita Chowdhury Barua");

        //2
            int a, b, sum;
            a = 100;
            b = 2;
            sum = a + b;
            Console.WriteLine("Sum = " + sum);

        //3
            int divide;
            divide = a / b;
            Console.WriteLine("Divide = " + divide);

        //4
            int result1, result2, result3, result4;
            result1 = -5 + 8 * 6;
            Console.WriteLine("Result1 = " + result1);
            result2 = (55 + 9) % 9;
            Console.WriteLine("Result2 = " + result2);
            result3 = 20 + -3 * 5 / 8;
            Console.WriteLine("Result3 = " + result3);
            result4 = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("Result4 = " + result4);

        //5
            int c, d, add, mul, sub, div, rem;
            c = 70;
            d = 10;
            add = c + d;
            mul = c * d;
            sub = c - d;
            div = c / d;
            rem = c % d;
            Console.WriteLine("Add = " + add);
            Console.WriteLine("Mul = " + mul);
            Console.WriteLine("Sub = " + sub);
            Console.WriteLine("Div = " + div);
            Console.WriteLine("Rem = " + rem);

        //6
            double expression = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine("Result = " + expression);

        //7
            double w = 5.6, h = 8.5;
            double area = 5.6 * 8.5;
            double p = 2 * (5.6 * 8.5);
            Console.WriteLine("Area is " +w+ " * " +h+ " = " +area);
            Console.WriteLine("Perimeter is 2 * ("+w+" + "+h+") = " + p);

         }
    }
}
