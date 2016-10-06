using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabsUnitTesting
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestEncrypt()
        {
            string s1 = "Hello world";

            Lab6.EncryptDelegate e1 = new Lab6.EncryptDelegate(Lab6.Encrypt.Cipher1);
            string s2 = e1(s1);

            Lab6.EncryptDelegate e2 = new Lab6.EncryptDelegate(Lab6.Encrypt.Cipher2);
            string s3 = e2(s1);

            Assert.AreEqual("Ifmmp!xpsme", s2);
        }
    }
}
