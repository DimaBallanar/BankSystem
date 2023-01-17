using System;
using BankSystem.Models;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(1, "Test1");
            User user2 = new User(1, "Test1");
            System.Console.WriteLine(user1 == user2);
            System.Console.WriteLine(user1.Equals(user2));
        }
    }
}