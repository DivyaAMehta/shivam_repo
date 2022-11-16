using System;

namespace ConsoleCoreCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            ArithmeticOperation.add(num1, num2);
            ArithmeticOperation.sub(num1, num2);
            ArithmeticOperation.mul(num1, num2);
            ArithmeticOperation.div(num1, num2);
        }
    }
}
