using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Program
    {
        public static List<(string, string)> users = new List<(string, string)>();

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1.Register");
                Console.WriteLine("2.Login");
                Console.WriteLine("0.Exit");
                
                int opinion = int.Parse(Console.ReadLine());
                switch (opinion)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        Login();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Choose according to menu!");
                        break;
                }

            }

            void Register()
            {
                Console.Write("Enter username: ");
                string userName = Console.ReadLine();
                Console.Write("Enter password: ");
                string password = Console.ReadLine();
                var user = (userName, password);
                users.Add(user);
                Console.WriteLine("User registered!");
            }

            void Login()
            {
                if(users.Count == 0)
                {
                    Console.WriteLine("You need to register first!");
                    return;
                }

                bool isLogined = false;
                while(!isLogined)
                {
                    Console.Write("Enter username: ");
                    string userName = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();

                    foreach (var user in users)
                    {
                        if (user.Item1 == userName && user.Item2 == password)
                        {
                            Console.WriteLine("Login successful!");
                            isLogined = true;
                        }
                        if(isLogined == false)
                        {
                            Console.WriteLine("Wrong username of password");
                        }
                    }
                }
            }
        }
    }
}
