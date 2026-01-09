using System;

namespace ConsoleApp1.Resources
{
    internal class Greeting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0} !", name);
            Console.WriteLine("{0}, how old are you?", name);
            string age = Console.ReadLine();
            if (Int32.Parse(age)<18)
            {
                Console.WriteLine("You're quite young! " +
                    "{0}, {1} is a wonderful age!", name, age);
            } else
            {
                Console.WriteLine("You look great! " +
                    "{0}, {1} is a wonderful age!", name, age);
            }

        }
    }
}