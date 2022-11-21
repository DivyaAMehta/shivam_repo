using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
     class GenericMethod
    {
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}
