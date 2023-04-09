using System;

namespace ChallengeIfStatement
{
    class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
        }

        public static void Register()
        {
            Console.WriteLine("Please register the username: ");
            username = Console.ReadLine();
            Console.WriteLine("Please register the password: ");
            password = Console.ReadLine();
            Console.WriteLine("Registration success");
        }

        public static void Login()
        {
            Console.WriteLine("Login - Enter the username: ");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Login - Enter the password: ");
            string inputPassword = Console.ReadLine();

            if (inputUsername.Equals(username) && inputPassword.Equals(password))
            {
                Console.WriteLine("Login success");
            }
            else
            {
                Console.WriteLine("Wrong username or password");
            }
        }
    }
}
