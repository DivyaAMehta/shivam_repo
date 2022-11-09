using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class GenericException
    {
        public void airthmetic()
        {
            int x = 10;
            int y = 0;
            int z = 0;
            try
            {
                z = x / y;
                Console.WriteLine(z);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
