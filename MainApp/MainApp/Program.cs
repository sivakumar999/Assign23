using SharedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class Program
    {
        public static void EmailValidation(string email)
        {
            if (SharedValidation.IsValidEmail(email))
            {
                Console.WriteLine("Valid email.");
            }
            else
            {
                Console.WriteLine("Invalid email.");
            }
        }
        static void Main(string[] args)
        { 
            Console.Write("Enter Email ID for validation:");
            string em = Console.ReadLine();
            EmailValidation(em);

            Console.ReadKey();
        }
    }
}