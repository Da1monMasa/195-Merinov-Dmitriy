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
            double a = 2;
            double b = 4;
            string operation = "+";
            double result = 6;
            double actual = CalculatorChecker.ValidateCalculator(a, b, operation);
            Assert.AreEqual(result, actual);

        }


        [TestMethod]
        public void ValidateCalculatorTest_Minus_ReturnTrue()
        {
            double a = 10;
            double b = 5;
            string operation = "-";
            double result = 5;
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
            double a = 2.5;
            double b = 5;
            string operation = "/";
            double result = 0.5;

            double actual = CalculatorChecker.ValidateCalculator(a, b, operation);
            Assert.AreEqual(result, actual);
        }

        /*[TestMethod()]

        [ExpectedException(typeof(DivideByZeroException), "Ошибка: Attempted to divide by zero.")]
        public void ValidateCalculatorTest_divide_ReturnFalse()
        {
            double a = 25;
            double b = 0;
            
            string operation = "/";
            double actual = CalculatorChecker.ValidateCalculator(a, b, operation);
            

        }*/
        [TestMethod()]
        public void TestDiv_null()
        {
            try
            {
                double a = 25;
                double b = 0;

                string operation = "/";
                double res = 1;
                double actual = CalculatorChecker.ValidateCalculator(a, b, operation);

                Assert.AreEqual(actual,res);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }




    }
}