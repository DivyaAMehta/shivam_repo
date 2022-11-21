using System;

namespace Question6
{
    class GenericDemo
    {
        public static void Main(string[] args)
        {
            GenericClass<string> gen = new GenericClass<string>("This is generic class");
            GenericClass<int> genI = new GenericClass<int>(101);
            GenericClass<char> getCh = new GenericClass<char>('I');

            GenericMethod genM = new GenericMethod();
            genM.Show("This is generic method");
            genM.Show(101);
            genM.Show('I');
        }
    }
}