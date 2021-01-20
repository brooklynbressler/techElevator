namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if it ends in "ly".
        EndsLy("oddly") → true
        EndsLy("y") → false
        EndsLy("oddy") → false
        */
        public bool EndsLy(string str)
        {
            bool flag = false;
        
            if (str.Length > 1)
            {
                string conditionString = str.Substring(str.Length - 2, 2);
                if (conditionString == "ly")
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}
