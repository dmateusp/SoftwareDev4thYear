using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    // defining possible types
    public enum Color : int { Red, Blue, Green }

    public class Shape
    {
        // property
        public Color Color
        {
            get; set;
        }

        // getter
        public Color getColor()
        {
            return this.Color;
        }

        // override
        public override string ToString()
        {
            switch (this.Color)
            {
                case Color.Red:
                    return "Shape(Red)";
                case Color.Blue:
                    return "Shape(Blue)";
                case Color.Green:
                    return "Shape(Green)";
                default:
                    return "Shape()";
            }
        }

        // constructor
        public Shape(Color color)
        {
            this.Color = color;
        }
    }
}
