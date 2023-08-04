using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();

            if (Utility.IsValidEmail(email))
            {
                Console.WriteLine("Valid email address.");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }

            Console.ReadKey();
        }
    }


}
