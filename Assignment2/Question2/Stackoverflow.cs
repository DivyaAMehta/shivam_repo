using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Stackoverflow
    {
        static void excep(int value)
        {
            Console.WriteLine(value);
            excep(++value);
        }
        public void demo()
        {
            try
            {
                excep(0);
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
