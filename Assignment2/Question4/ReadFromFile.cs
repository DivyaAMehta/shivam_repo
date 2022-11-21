using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class ReadFromFile
    {
        public static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Shivam.Yadav\Desktop\New folder\C#\Assignments–II.txt");
            System.Console.WriteLine("Contents of Assignment-II.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}