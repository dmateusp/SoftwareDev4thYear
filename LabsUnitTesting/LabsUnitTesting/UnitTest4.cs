using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabsUnitTesting
{
    /// <summary>
    /// Summary description for UnitTest4
    /// </summary>
    [TestClass]
    public class UnitTest4
    {
        public UnitTest4()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestCalculator()
        {
            string inputUser1 = "4.5";
            string inputUser2 = "5";
            double n1 = Double.Parse(inputUser1);
            double n2 = Double.Parse(inputUser2);
            Assert.AreEqual(0.9,Lab4.Calculator.divide(n1, n2));

            string inputUser3 = "ab";
            try
            {
                Double.Parse(inputUser3);
                Assert.Fail(); // If it gets to this line, no exception was thrown
            }
            catch (Exception e)
            {
                if(e is FormatException || e is OverflowException)
                {} else { Assert.Fail(); }
            }
        }
        [TestMethod]
        public void TestModuleCA()
        {
            string[] CAResults = { "A", "B+" ,"B" ,"B-"};
            Assert.AreEqual("A,B+,B,B-", String.Join(",",CAResults));

            Lab4.ModuleCAResults m = new Lab4.ModuleCAResults() { Name = "Semester1", StudentName = "Daniel", Credits = 60};
            for (int i = 0; i < CAResults.Length; i++)
            {
                m[i+1] = CAResults[i];
            }
            Assert.AreEqual("A", m[1]);
            Assert.AreEqual("B", m[3]);
        }
    }
}
