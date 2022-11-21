using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
     class Question2
    {
         public static void validation()
        {
            string str = "shiv@gmail.com";
            Console.WriteLine("The email is "+str+"");
            var mail = new MailAddress(str);
            bool isValid = mail.Host.Contains(".");
            if (!isValid)
            {
                Console.WriteLine("Email is Invalid");
            }
            else
            {
                Console.WriteLine("Email is Valid.");
            }

        }

    }
}
