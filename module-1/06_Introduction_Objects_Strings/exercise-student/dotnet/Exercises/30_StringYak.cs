namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed.
        The "yak" strings will not overlap.
        StringYak("yakpak") → "pak"
        StringYak("pakyak") → "pak"
        StringYak("yak123ya") → "123ya"
        */
        public string StringYak(string str)
        {
            int index = 0;
            string answerString = str;
            for (int i = 0; i < answerString.Length; i++)
            {
                if (answerString.Contains("yak"))
                {
                    index = answerString.IndexOf("yak");
                    answerString = answerString.Remove(index, 3);
                }
            }
               
            return answerString;
        }
    }
}
