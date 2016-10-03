using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Line : Shape
    {
        // properties
        private Vertex v1, v2;

        public int X1
        {
            get
            {
                return v1.X;
            }
            set
            {
                v1.X = value;
            }
        }
        public int X2
        {
            get
            {
                return v2.X;
            }
            set
            {
                v2.X = value;
            }
        }
        public int Y1
        {
            get
            {
                return v1.Y;
            }
            set
            {
                v1.Y = value;
            }
        }
        public int Y2
        {
            get
            {
                return v2.Y;
            }
            set
            {
                v2.Y = value;
            }
        }
        // constructor
        public Line(Color color, Vertex v1, Vertex v2) : base(color)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        // overriding
        public override string ToString()
        {
            switch (this.getColor())
            {
                case Color.Red:
                    return "Line(Red, "+ v1.ToString() +", "+ v2.ToString() +")";
                case Color.Blue:
                    return "Line(Blue, " + v1.ToString() + ", " + v2.ToString() + ")";
                case Color.Green:
                    return "Line(Green, " + v1.ToString() + ", " + v2.ToString() + ")";
                default:
                    return "Line(None, " + v1.ToString() + ", " + v2.ToString() + ")";
            }
        }

        // methods
        public void Translate(Vertex translationVertex)
        {
            v1.X += translationVertex.X;
            v2.X += translationVertex.X;
            v1.Y += translationVertex.Y;
            v2.Y += translationVertex.Y;
        }
    }
}
