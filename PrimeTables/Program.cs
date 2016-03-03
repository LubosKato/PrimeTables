using System;
using PrimeTables.Algorithms;

namespace PrimeTables
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please insert number for Prime Table:"); // Prompt
                string numberOfPrimes = Console.ReadLine();
                var primeTable = new PrimeTable(new UserInputHelper(numberOfPrimes).ProcessInput(), new Context(new Naive()));
                var primes = primeTable.GeneratePrimes();

                foreach (var row in primes)
                {
                    Console.WriteLine(row);
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
