using System;
using System.Collections.Generic;
using System.Numerics;
using PrimeTables.Algorithms;

namespace PrimeTables
{
    public class Context : PrimeTable
    {
        private readonly IAlgorithm _strategy;

        public Context(){}

        public Context(IAlgorithm strategy)
        {
            this._strategy = strategy;
        }

        public virtual List<BigInteger> GenerateContext()
        {
            return _strategy.Generate(NumberOfPrimes);
        }
    }
}
