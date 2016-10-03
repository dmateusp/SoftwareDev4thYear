using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabsUnitTesting
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestVertex()
        {
            Lab2.Vertex v1 = new Lab2.Vertex(1, 2);
            Lab2.Vertex v2 = new Lab2.Vertex(2, 1);
            Lab2.Vertex v3 = new Lab2.Vertex(1, 2);

            Assert.AreNotEqual(v1, v2);
            Assert.AreEqual(v1, v3);
        }
        [TestMethod]
        public void TestShape()
        {
            Lab2.Shape s1 = new Lab2.Shape(Lab2.Color.Red);
            Lab2.Shape s2 = new Lab2.Shape(Lab2.Color.Green);

            Assert.AreNotEqual(s1.getColor(), s2.getColor());
        }
        [TestMethod]
        public void TestLine()
        {
            Lab2.Line l1 = new Lab2.Line(Lab2.Color.Red,new Lab2.Vertex(1,2), new Lab2.Vertex(2,1));
            // same but different color
            Lab2.Line l2 = new Lab2.Line(Lab2.Color.Green, new Lab2.Vertex(1, 2), new Lab2.Vertex(2, 1));
            // same
            Lab2.Line l3 = new Lab2.Line(Lab2.Color.Green, new Lab2.Vertex(1, 2), new Lab2.Vertex(2, 1));


            Assert.AreNotEqual(l1.ToString(), l2.ToString());
            Assert.AreEqual(l2.ToString(), l3.ToString());

            // Test Translate
            l1.Translate(new Lab2.Vertex(1, 1));
            Assert.AreEqual(l1.X1, 2);
            Assert.AreEqual(l1.X2, 3);
        }

        [TestMethod]
        public void TestTranslate()
        {
            Lab2.Line l1 = new Lab2.Line(Lab2.Color.Red, new Lab2.Vertex(1, 2), new Lab2.Vertex(2, 1));
            // Test Translate
            l1.Translate(new Lab2.Vertex(1, 1));
            Assert.AreEqual(l1.X1, 2);
            Assert.AreEqual(l1.X2, 3);
        }
        [TestMethod]
        public void TestCircle()
        {
            Lab2.Circle c = new Lab2.Circle(Lab2.Color.Blue, 1, 2, 2);
            double area = Math.Round(c.Area(),1);
            Assert.AreEqual(12.6, area);
        }
    }
}
