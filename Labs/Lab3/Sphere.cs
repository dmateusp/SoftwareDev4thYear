using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Sphere : IHasVolume
    {
        public double Radius { get; set; }
        public double volume()
        {
            return Radius * Radius * Math.PI;
        }
        public Sphere(double radius)
        {
            this.Radius = radius;
        }
        public override string ToString()
        {
            return "Sphere(" + Radius.ToString() + "), volume: " + this.volume();
        }
    }
}
