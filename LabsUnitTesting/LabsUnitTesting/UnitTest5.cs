using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabsUnitTesting
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMoney()
        {
            Lab5.Money m1 = new Lab5.Money(2, Lab5.Currency.Euro);
            Lab5.Money m2 = new Lab5.Money(4, Lab5.Currency.US);
            Assert.AreEqual(4, m1 + m2);
        }
    }
}
