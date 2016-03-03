using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeTables.Tests.Integration
{
    [TestClass]
    public class UserInputHelperTests
    {
        [TestMethod]
        public void User_Tyeps_In_Correct_Input()
        {
            var result = new UserInputHelper("100000000000").ProcessInput();
            BigInteger number = 100000000000;

            Assert.AreEqual(result, number);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void User_Tyeps_In_Wrong_Input()
        {
            var result = new UserInputHelper("asd").ProcessInput();
        }
    }
}
