using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class NullReference
    {
       public void nullReference()
        {
            try
            {
                string value = null;
                if (value.Length == 0)
                {
                    Console.WriteLine(value);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
