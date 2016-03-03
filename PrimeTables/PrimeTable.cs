using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace PrimeTables
{
    public class PrimeTable
    {
        public static BigInteger NumberOfPrimes { get; set; }
        private readonly Context _context;

        public PrimeTable(){}

        public PrimeTable(BigInteger numberOfPrimes, Context context)
        {
            NumberOfPrimes = numberOfPrimes;
            _context = context;
        }

        public List<string> GeneratePrimes()
        {
            var result = new List<string>();
            var primes = _context.GenerateContext();

            result.Add("| |" + string.Join("|", primes.Select(x => x.ToString()).ToArray()) + "|");

            // iterate through each prime number to create new row 
            for (int lineId = 0; lineId < NumberOfPrimes; lineId++)
            {
                var primeValue = primes[lineId];
                string row = "|" + primeValue + "|";
                // iterate through each prime number to create content of the row
                for (int primeId = 0; primeId < primes.Count; primeId++)
                {
                    row += (primeValue*primes[primeId]) + "|";
                }

                result.Add(row);
            }

            return result;
        }
    }
}
