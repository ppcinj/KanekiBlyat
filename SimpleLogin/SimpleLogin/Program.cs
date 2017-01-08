using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var userCredentials = new User();
                Console.Write("Username: ");
                userCredentials.Username = Console.ReadLine();
                Console.Write("Password: ");
                userCredentials.Password = Console.ReadLine();

                if (userCredentials.Username == "test" && userCredentials.Password == "1234")
                {
                    break;
                }

                Console.WriteLine("Login unsuccessful, please try again!");
            }

            Console.WriteLine("Login successful");
            Console.ReadKey();
        }
    }
}
