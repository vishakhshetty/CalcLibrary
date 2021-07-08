
using NUnit.Framework;
using System;
using CalcLibrary;

namespace UnitTestProject
{
    [TestFixture]
    public class CalculatorTests
    {
        SimpleCalculator calLib;
        [SetUp]
        public void SetInit()
        {
            calLib = new SimpleCalculator();
        }

        [TestCase(23,1,24)]
        public void CheckAddition(double value1, double value2, double expected)
        {
            double result = calLib.Addition(value1, value2);

            Assert.AreEqual(expected, result);

        }

        [TestCase(23, 1, 22)]
        [TestCase(5,1,4)]
        public void CheckSubtraction(double value1, double value2, double expected)
        {
            double result = calLib.Subtraction(value1, value2);

            Assert.AreEqual(expected, result);

        }

        [TestCase(23, 1, 23)]
        [TestCase(5, 11, 55)]
        public void CheckMultiplication(double value1, double value2, double expected)
        {
            double result = calLib.Multiplication(value1, value2);

            Assert.AreEqual(expected, result);

        }


        [TestCase(23, 1, 23)]
        [TestCase(5, 0, 0)]
        public void CheckDivision(double value1, double value2, double expected)
        {
            try
            {
                double result = calLib.Division(value1, value2);
                Assert.AreEqual(expected, result);
                Assert.Fail();

            }
            catch(ArgumentException e)
            {
                Assert.Pass("Division By zero");
            }

        }

        [TestCase(1, 2, 3)]
        public void TestAddAndClear(double value1, double value2, double expected)
        {
            double result = calLib.Addition(value1, value2);
            Assert.AreEqual(expected, result);
            calLib.AllClear();
            Assert.AreEqual(0, calLib.GetResult);
        }

        [TearDown]
        public void MathLibraryDown()
        {
            calLib.Dispose();
        }
    }
}
