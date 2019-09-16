using DataStorage.Data;
using System;

namespace DataStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            var userRepository = new UserRepository();

            Console.WriteLine("Enter the user's first name");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter the user's last name");
            var LastName = Console.ReadLine();

            Console.WriteLine("Enter the user's password");
            var password = Console.ReadLine();
        }
    }
}
