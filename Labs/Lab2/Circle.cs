using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Circle : Shape
    {
        // properties
        private Vertex v;

        // Color from base
        public int X
        {
            get
            {
                return this.v.X;
            }
            set
            {
                this.v.X = value;
            }
        }
        public int Y
        {
            get
            {
                return this.v.Y;
            }
            set
            {
                this.v.Y = value;
            }
        }
        public double Radius { get; set; }

        public Circle(Color color, int x, int y, double radius): base(color)
        {
            this.Color = color;
            this.v = new Lab2.Vertex(x, y);
            this.Radius = radius;
        }

        public double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}
