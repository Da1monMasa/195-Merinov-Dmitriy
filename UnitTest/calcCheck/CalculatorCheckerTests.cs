using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Tests
{
    [TestClass()]
    public class CalculatorCheckerTests
    {
        [TestMethod()]
        public void ValidateCalculatorTest_plus_ReturnTrue()
        {
            double a = 5;
            double b = 15;
            string operation = "+";
            double result = 20;
            double actual = CalculatorChecker.ValidateCalculator(a, b, operation);
            Assert.AreEqual(result, actual);

        }


        [TestMethod]
        public void ValidateCalculatorTest_Minus_ReturnTrue()
        {
            double a = 70;
            double b = 6;
            string operation = "-";
            double result = 64;
            double actual = CalculatorChecker.ValidateCalculator(a, b, operation);
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void ValidateCalculatorTest_multiply_ReturnTrue()
        {
            double a = 5;
            double b = 5;
            string operation = "*";
            double result = 25;

            double actual = CalculatorChecker.ValidateCalculator(a, b, operation);
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void ValidateCalculatorTest_divide_ReturnTrue()
        {
            double a = 99;
            double b = 3;
            string operation = "/";
            double result = 33;

            double actual = CalculatorChecker.ValidateCalculator(a, b, operation);
            Assert.AreEqual(result, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException), "Вы не можете делить на ноль ")]
        public void ValidateCalculatorTest_divide_ReturnFalse()
        {
            double a = 99591;
            double b = 0;


            string operation = "/";
            double actual = CalculatorChecker.ValidateCalculator(a, b, operation);

        }




    }
}
