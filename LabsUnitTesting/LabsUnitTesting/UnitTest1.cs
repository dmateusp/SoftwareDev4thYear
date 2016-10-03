using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabsUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        // initializing two instances
        Lab1.ThreeDShape cylindre = new Lab1.ThreeDShape(Lab1.Shapes.Cylinder);
        Lab1.ThreeDShape cone = new Lab1.ThreeDShape(Lab1.Shapes.Cone);

        [TestMethod]
        public void TestDifferentShapesCreation()
        {
            Assert.AreNotSame(cylindre, cone);
        }

        [TestMethod]
        public void TestDifferentToString()
        {
            Assert.AreNotEqual(cylindre.ToString(), cone.ToString());
        }
        [TestMethod]
        public void TestSphere()
        {
            Lab1.Sphere sphereInstance = new Lab1.Sphere(Lab1.Shapes.Sphere);
            sphereInstance.setRadius(1);
            Assert.AreEqual(4.19, Math.Round(sphereInstance.volume(), 2));
        }
        [TestMethod]
        public void TestMain()
        {
            Lab1.Sphere sphereInstance = new Lab1.Sphere(Lab1.Shapes.Sphere);
            sphereInstance.setRadius(1);

            Lab1.ThreeDShape[] shapes = { cylindre, cone, sphereInstance };

            Assert.AreEqual(cylindre.volume(), 1);
            Assert.AreEqual(4.19, Math.Round(sphereInstance.volume(), 2));
        }
    }
}
