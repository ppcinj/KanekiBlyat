using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogin
{
    class Program
    {
        static List<User> spisok = new List<User>();

        static void Main(string[] args)
        {
            Console.WriteLine("Создать нового пользователя?");
            var otvet = Console.ReadLine();
            while (otvet == "da")
            {
                Login();
                Console.WriteLine("Закончить ввод?");
                var otvet1 = Console.ReadLine();
                if (otvet1 == "da")
                {
                    break;
                }
            }
            Console.WriteLine("Зайдите в учётную запись");
            while (true)
            {
                Console.WriteLine("Введите логин");
                var log = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                var pas = Console.ReadLine();

                if (spisok.Any(x => x.Password == pas && x.Username == log))
                {
                    Console.WriteLine("Деньги:");
                    Console.WriteLine(spisok.FirstOrDefault(x => x.Password == pas && x.Username == log).Money);
                    break;
                }
                Console.WriteLine("Попробуйте ещё раз");
            }

            Console.ReadKey();
        }
        public static void Login()
        {

            var userCredentials = new User();
            Console.Write("Username: ");
            userCredentials.Username = Console.ReadLine();
            Console.Write("Password: ");
            userCredentials.Password = Console.ReadLine();
            Console.Write("Money: ");
            userCredentials.Money = Convert.ToSingle(Console.ReadLine());

            spisok.Add(userCredentials);




        }
    }
}
