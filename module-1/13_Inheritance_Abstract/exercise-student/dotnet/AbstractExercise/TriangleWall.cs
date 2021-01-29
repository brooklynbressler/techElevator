using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    class TriangleWall : Wall
    {
        public int Base { get; }

        public int Height { get; }
        public int totalAreaOfTheWall { get; set; }

        public TriangleWall(string name, string color, int @base, int height)
            : base (name, color)
        {
            Base = @base;
            Height = height;
        }
        public override int GetArea()
        {
            this.totalAreaOfTheWall = ((Base * Height) / 2);

            return this.totalAreaOfTheWall;
        }
        public override string ToString()
        {
            return $"{Name} ({Base + "x" + Height}) triangle";
        }

    }
}
