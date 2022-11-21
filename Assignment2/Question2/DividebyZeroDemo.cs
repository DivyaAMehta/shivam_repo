using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class DividebyZeroDemo
    {
        public void division()
        {
            int a = 10;
            int b = 0;
            int c = 0;
            try
            {
                c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
