namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
        DoubleX("axxbb") → true
        DoubleX("axaxax") → false
        DoubleX("xxxxx") → true
        */
        public bool DoubleX(string str)
        {
            int outOfBoundsCheck = str.Length - 1;
            int index = str.IndexOf('x');
            bool flag = false;
            string comparisonString = "";
            if(index < str.Length - 1 && index >= 0)
            {
                comparisonString = str.Substring(index, 2);
                if (comparisonString == "xx")
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}
