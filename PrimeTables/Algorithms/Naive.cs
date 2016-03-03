using System;
using System.Collections.Generic;
using System.Numerics;

namespace PrimeTables.Algorithms
{ 
    public class Naive : IAlgorithm
    {
        public List<BigInteger> Generate(BigInteger max)
        {
            List<BigInteger> primes = new List<BigInteger>();
            primes.Add(2);
            BigInteger nextPrime = 3;
            while (primes.Count < max)
            {
                int sqrt = (int)Math.Sqrt((double)nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;
        }
    }
}
