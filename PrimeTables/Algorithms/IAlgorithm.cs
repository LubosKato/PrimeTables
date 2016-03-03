using System.Collections.Generic;
using System.Numerics;

namespace PrimeTables.Algorithms
{
    public interface IAlgorithm
    {
        List<BigInteger> Generate(BigInteger max);
    }
}