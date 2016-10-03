using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Sphere : ThreeDShape
    {
        // properties
        private double radius;

        // getters
        public double getRadius()
        {
            return this.radius;
        }

        // setters
        public bool setRadius(double radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
            }

            return radius > 0;
        }

        // methods
        public override double volume()
        {
            return (4.0/3)*Math.PI*(this.radius * this.radius * this.radius);
        }

        public Sphere(Shapes type) : base(type)
        {
        }
    }
}
