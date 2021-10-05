using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLabraryPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            string password = "BigblackB";
            bool expected = true;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_20Symbols_ReturnsFalse()
        {
            string password = "Smallwhitesultfatflashlightpussy";
            bool expected = false;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_6Symbols_ReturnsFalse()
        {
            string password = "Medium";
            bool expected = false;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_HasDigits_ReturnsTrue()
        {
            string password = "8igblack8";
            bool expected = true;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_HasDigits_ReturnsFalse()
        {
            string password = "Passwithoutdigit";
            bool expected = false;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_HasSpecS_ReturnsTrue()
        {
            string password = "Cum1n_th3-$ky";
            bool expected = true;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_HasSpecS_ReturnsFalse()
        {
            string password = "cuminsky";
            bool expected = false;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);
        }
        public void Check_HasUpperLowerCase_ReturnsTrue()
        {
            string password = "AlcoholicSemenThrower";
            bool expected = true;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(expected, actual);
        }
        public void Check_HasUpperLowerCase_ReturnsFalse()
        {
            string password = "athwhiteblack";
            bool expected = false;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);

        }

    }
}
