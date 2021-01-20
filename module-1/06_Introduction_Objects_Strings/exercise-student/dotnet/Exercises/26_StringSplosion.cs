namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a non-empty string like "Code" return a string like "CCoCodCode".
        StringSplosion("Code") → "CCoCodCode"
        StringSplosion("abc") → "aababc"
        StringSplosion("ab") → "aab"
        */
        public string StringSplosion(string str)
        {
            string newString = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length-1)
                {
                        newString += str.Substring(0, i +1);

                }
                else
                {
                    newString += str;
                   
                }
            }
            return newString;
        }
    }
}
