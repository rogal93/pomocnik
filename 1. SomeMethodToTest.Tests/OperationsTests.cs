using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1.SomeMethodToTest.Tests
{
    [TestClass]
    public class OperationsTests
    {
        [TestMethod]
        public void AddingTest()
        {
            //klasa z metoda do sprawdzenia
            Operations operations = new Operations();

            double firstNumber = -3,
                secondNumber = 12;
            double expectedResult = 9;

            //czy sa rowne te wartosci
            Assert.AreEqual(expectedResult, operations.Add(firstNumber, secondNumber));
        }
    }
}
