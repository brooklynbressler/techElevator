namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return the count of the number of times that a substring length 2 appears in the string and
        also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
        Last2("hixxhi") → 1
        Last2("xaxxaxaxx") → 1
        Last2("axxxaaxx") → 2
        */
        public int Last2(string str)
        {
            int outOfBoundsCheck = str.Length - 2;
            int count = 0;
            string comparisonString = "";
            if (str.Length >= 4) {
                string lastCompare = str.Substring(str.Length - 2);
                for (int i = 0; i < str.Length; i++)
                {
                    if (i < outOfBoundsCheck)
                    {
                        comparisonString = str.Substring(i, 2);
                        if (comparisonString == lastCompare)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
