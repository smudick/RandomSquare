using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {

            var listOfRandomNumbers = new List<int>();
            Console.WriteLine("Initial List of Random Numbers \n---------------------------------");
            for (var i = 0; i < 20; i++)
            {
                var rand = new Random();
                var randomNumber = rand.Next(50);
                listOfRandomNumbers.Add(randomNumber);
                Console.WriteLine(randomNumber);
            }

            var listOfSquaredNumbers = listOfRandomNumbers.Select(number => number * number);
            Console.WriteLine("\nList of Random Numbers Squared \n---------------------------------");
            foreach (var squaredNumber in listOfSquaredNumbers)
            {
                Console.WriteLine(squaredNumber);
            }

            var listWithoutOddNumbers = listOfSquaredNumbers.Where(number => number % 2 == 0);
            Console.WriteLine("\nList of Random Even Squared Numbers\n---------------------------------");
            foreach (var evenNumber in listWithoutOddNumbers)
            {
                Console.WriteLine(evenNumber);
            }
        }
    }
}
