using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Question1
{
    class EmailValidation
    {
        public static void Main(string[] args)
        {
            EmailValidation e=new EmailValidation();
            e.regexValidation();
        }
        public void regexValidation()
        {
            string email = "shivam@1234.com";
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Console.WriteLine($"The email is {email}");
            bool isValidEmail = regex.IsMatch(email);
            if (!isValidEmail)
            {
                Console.WriteLine($"The email is invalid");
            }
            else
            {
                Console.WriteLine($"The email is valid");
            }
            Console.ReadLine();
        }
    }
}
