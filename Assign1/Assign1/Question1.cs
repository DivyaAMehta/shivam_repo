using System;
    
namespace Assign1
{
    class Question1
    {
        public static void stringOperation()
        {
            string s1 = "welcome";
            string s2 = "welcome";
            string s3 = "WElCOME";
            string s4 = "csharp";
            //compare two strings
            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s1, s4)); 
            Console.WriteLine(string.Compare(s1, s3));
            //concat two strings
            Console.WriteLine(string.Concat(s1, s4));
            //substring
            Console.WriteLine(s1.Substring(3));
            Console.WriteLine(s2.Substring(0,3));
            //convert string to array
            char[] ch = s4.ToCharArray();
            Console.WriteLine(ch);
            //reverse string
            Array.Reverse(ch);
            Console.WriteLine(ch);

        }
    }
}
