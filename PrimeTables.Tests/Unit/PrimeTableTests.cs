
using System.Collections.Generic;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace PrimeTables.Tests.Unit
{
    [TestClass]
    public class PrimeTableTests
    {
        [TestMethod]
        public void When_User_Enters_Input_It_Calls_Generate_And_Returns_Correct_Result()
        {
            var mockUserInput = new Mock<UserInputHelper>();
            mockUserInput.Setup(mock => mock.ProcessInput()).Returns(3);

            var mockContext = new Mock<Context>();
            mockContext.Setup(mock => mock.GenerateContext()).Returns(new List<BigInteger> { 2, 3, 5 });

            var primeTable = new PrimeTable(mockUserInput.Object.ProcessInput(), mockContext.Object);
            var results = primeTable.GeneratePrimes();

            mockContext.Verify(mock => mock.GenerateContext(), Times.Once());
            Assert.AreEqual("|2|4|6|10|", results[1]);
        }
    }
}
