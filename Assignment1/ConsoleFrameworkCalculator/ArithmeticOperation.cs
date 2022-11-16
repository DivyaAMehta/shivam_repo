using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFrameworkCalculator
{
    internal class ArithmeticOperation
    {
        public static void add(int num1,int num2)
        {
            int res=num1+ num2;
            Console.WriteLine("Addition: " + res);
        }
        public static void sub(int num1, int num2)
        {
            int res = num1 - num2;
            Console.WriteLine("Substraction: " + res);
        }
        public static void mul(int num1, int num2)
        {
            int res = num1 * num2;
            Console.WriteLine("Multiplication: " + res);
        }
        public static void div(int num1, int num2)
        {
            int res = num1 / num2;
            Console.WriteLine("Division: " + res);
        }
    }
}
