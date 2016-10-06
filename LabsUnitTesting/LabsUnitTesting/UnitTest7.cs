using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabsUnitTesting
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void TestStudents()
        {
            Lab7.Student s1 = new Lab7.Student("12345", "Daniel", Lab7.Gender.Male);
            Lab7.Student s2 = new Lab7.Student("54321", "Rafael", Lab7.Gender.Male);
            Lab7.StudentClass c1 = new Lab7.StudentClass();
            c1.addStudent(s1);
            c1.addStudent(s2);
            Assert.AreEqual("Daniel", c1[0].Name);
            Assert.AreEqual("Rafael", c1[1].Name);
            Assert.AreEqual("Rafael", c1["54321"].Name);
            try
            {
                Lab7.Student s3 = c1[5];
                Lab7.Student s4 = c1["askdakwd"];
                Assert.Fail();
            }
            catch (Exception e)
            {
                if(e is AssertFailedException)
                    Assert.Fail();
            }
        }
    }
}
