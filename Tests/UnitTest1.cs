using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc = new Calculator();

        [TestMethod]
        public void MultiplyTesting()
        {
            calc.ResultingOperation(10, 30, '*');
            Assert.AreEqual(300, calc.Total);
        }

        [TestMethod]
        public void DivideTesting()
        {
            calc.ResultingOperation(50, 2, '/');
            Assert.IsNotNull(calc.Total);
        }

        [TestMethod]
        public void AddTesting()
        {
            calc.ResultingOperation(5, 4, '+');
            Assert.AreNotEqual(1, calc.Total);
        }

        [TestMethod]
        public void SubstractTesting()
        {
            calc.ResultingOperation(20, 20, '-');
            Assert.AreEqual(0, calc.Total);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroTest()
        {
            calc.ResultingOperation(5, 0, '/');
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void StringInputTest()
        {
            string test = "Aloha";
            calc.NumberOne = double.Parse(test);
        }
    }
}
