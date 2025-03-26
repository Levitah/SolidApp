using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.Test
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        [Ignore("Ignoring this test due to the functionality being disabled")]
        public void TransferAllMoneyToSavings()
        {
            // Arrange
            double beginningBalance = 11.99;
            double expected = 0;

            //Act
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            account.TransferAllMoneyToSavings();

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual);
        }
    }
}
