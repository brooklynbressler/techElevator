namespace Exercises
{
    public partial class Exercises
    {
        /*
      Given 2 int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            if (((a >= 10) && (a <= 20)) && ((b < 10) || (b > 20)))
            {
                return a;
            }
            if (((b >= 10) && (b <= 20)) && ((a < 10) || (a > 20)))
            {
                return b;
            }
            if ((b >= 10) && (b <= 20) && (a >= 10) && (a <= 20))
            {
                if (a >= b)
                {
                    return a;
                }
                if (b > a)
                {
                    return b;
                }
            }
            return 0;
            
            
        }
    }
}
