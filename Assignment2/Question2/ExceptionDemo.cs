using System;
using System.Security.Cryptography.X509Certificates;

namespace Question2
{
    class ExceptionDemo
    {
        public static void Main(string[] args)
        {
            NullReference n = new NullReference();
            // n.nullReference();
            DividebyZeroDemo d = new DividebyZeroDemo();
            // d.division();
            Stackoverflow s = new Stackoverflow();
            //s.demo();
            GenericException g = new GenericException();
            g.airthmetic();
        }
    }
}