namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string answerString = "";
            string characterComparison = "";
            for (int i = 0; i < str.Length; i++)
            {
                if(i < str.Length)
                {
                    characterComparison = str.Substring(i, 1);
                if (i == 0 || i == str.Length - 1 || characterComparison != "x")
                    {
                        answerString += str.Substring(i, 1);
                    }
                }
                
            }
            return answerString;
        }
    }
}
