using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // defining possible types
    public enum Shapes : int { Sphere, Cylinder, Cone }

    public class ThreeDShape
    {

        // type of ThreeDShape
        private Shapes type;

        // methods
        public virtual double volume()
        {
            return 1;
        }

        public override string ToString()
        {
            switch (this.type)
            {
                case Shapes.Cone: return "This is a cone";
                case Shapes.Sphere: return "This is a sphere";
                case Shapes.Cylinder: return "This is a cylinder";
                default: return "Unknown type!";
            }
        }

        // constructor
        public ThreeDShape(Shapes type)
        {
            this.type = type;
        }

        // getters
        public Shapes getType() {
            return type;
        }
    }
}
