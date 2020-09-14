using System;
using System.Linq;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goodPassword = false;

            while (goodPassword == false)
            {

                Console.WriteLine("Hello, Please Enter a Valid Password. Passwords must contain at least one of the following characters: A lowercase letter, an uppercase letter, and an explination mark. Passwords must be between 7-12 characters long");

                string password = Console.ReadLine();


                if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Contains("!")
                    && password.Count() > 6 && password.Count()< 13 )
                {
                    goodPassword = true;
                    Console.WriteLine("Password Valid and Accepted");
                }
                else { Console.WriteLine("Error"); }

            }


        }
    }
}

