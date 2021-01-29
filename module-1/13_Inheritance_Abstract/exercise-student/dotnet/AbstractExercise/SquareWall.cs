using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class SquareWall : RectangleWall
    {
        public int SideLength { get; set; }


        public SquareWall(string name, string color, int sideLength)
            : base (name, color)
        {
            SideLength = sideLength;
            this.Height = sideLength;
            this.Length = sideLength;
        }

        public override int GetArea()
        {
            int totalAreaOfTheWall = SideLength * SideLength;

            return totalAreaOfTheWall;
        }
        public override string ToString()
        {
            return $"{Name} ({SideLength + "x" + SideLength}) square";
        }


    }
}
