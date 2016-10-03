using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Vertex
    {
        // properties
        public int X { get; set; }
        public int Y { get; set; }

        // constructor
        public Vertex(int x, int y)
        {
            X = x;
            Y = y;
        }

        // overiding equals
        public override bool Equals(object other)
        {
            var toCompareWith = other as Vertex;
            if (toCompareWith == null)
                return false;
            return X == toCompareWith.X &&
                Y == toCompareWith.Y;
        }
        
    }
}
