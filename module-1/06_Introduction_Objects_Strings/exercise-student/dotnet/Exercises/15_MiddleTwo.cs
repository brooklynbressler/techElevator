namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string of even length, return a string made of the middle two chars, so the string "string"
        yields "ri". The string length will be at least 2.
        MiddleTwo("string") → "ri"
        MiddleTwo("code") → "od"
        MiddleTwo("Practice") → "ct"
        */
        public string MiddleTwo(string str)
        {
            int startingPosition = (str.Length / 2) - 1;
           
            if (str.Length % 2 == 0)
            {
                string middleChars = str.Substring(startingPosition, 2);
                return middleChars;
            }
            else
            {
                return "";
            }
        }
    }
}
