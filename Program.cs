using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's locate some primes!");

            Console.WriteLine("This application will find you any prime, in order, from first prime number on.");

            while (true)
            {
                Console.WriteLine("Which prime number are you looking for?");

                int userInput = Convert.ToInt32(Console.ReadLine());

                PrimeNumbers prime = new PrimeNumbers();
                Console.WriteLine($"The number {userInput} prime is {prime.GetNPrime(userInput)}");

                Console.WriteLine("Do you want to find another prime number? (y/n): ");

                string continueInput = Console.ReadLine().ToLower();

                if (continueInput == "y")
                {
                    continue;
                }
                else if (continueInput == "n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Goodbye");
                    break;
                }

            }
        }
    }
}
