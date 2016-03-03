
using System;
using System.Numerics;

namespace PrimeTables
{
    public class UserInputHelper 
    {
        private readonly string _userInput;

        public UserInputHelper() {}

        public UserInputHelper(string userInput)
        {
            _userInput = userInput;
        }

        public virtual BigInteger ProcessInput()
        {
            BigInteger result;
            if (!BigInteger.TryParse(_userInput, out result))
            {
                // could implement custom exception and catch it above and also in test expect custom one same for below
                throw new Exception("wrong user input need to be a number");
            }
            if (result <= 0)
                throw new Exception("wrong user input need to contain number bigger the 0");

            return result;
        }
    }
}
