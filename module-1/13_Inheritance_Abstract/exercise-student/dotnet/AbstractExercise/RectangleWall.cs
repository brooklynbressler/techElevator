using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class RectangleWall : Wall
    {
        public int Length { get; set; }

        public int Height { get; set; }
        public int totalAreaOfTheWall { get; set; }


        public RectangleWall(string name, string color, int length, int height)
            : base (name, color)
        {
            Length = length;
            Height = height;
        }

        public RectangleWall(string name, string color)
            : base (name, color)
        {

        }

        public override int GetArea()
        {
            this.totalAreaOfTheWall = Length * Height;

            return this.totalAreaOfTheWall;
        }
        public override string ToString()
        {
            return $"{Name} ({Length + "x" + Height}) rectangle";
        }
    
    
    
    }
}
