﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an int n, return the absolute difference between n and 21, except return double the absolute
         difference if n is over 21.
         Diff21(19) → 2
         Diff21(10) → 11
         Diff21(21) → 0
         */
        public int Diff21(int n)
        {
            if (n > 21)
            {
                return 2 * (n - 21);
            }
            int y = n - 21;
            if (y < 0)
            {
                return y * (-1);
            }
            return y;
        }
    }
}