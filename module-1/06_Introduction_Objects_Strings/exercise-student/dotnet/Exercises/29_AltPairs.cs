namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
        AltPairs("kitten") → "kien"
        AltPairs("Chocolate") → "Chole"
        AltPairs("CodingHorror") → "Congrr"
        */
        public string AltPairs(string str)
        {
            string answerString = "";
            int outOfBounds = str.Length - 2;
            int outOfBoundsByOne = str.Length - 1;
            answerString = str.Substring(0);
            int count = 0;
            if (str.Length >=2) {
                for (int i = 0; i < str.Length; i++)
                {
                    if (i == 0)
                    {
                        count = 4;
                        answerString = str.Substring(i, 2);
                    }
                    else if (i <= outOfBounds)
                    {
                        if (i == count)
                        {
                            count += 4;
                            answerString += str.Substring(i, 2);
                        }
                    }
                    else if (i == outOfBoundsByOne)
                    {
                        if (i == count)
                        {
                            count += 4;
                            answerString += str.Substring(i);
                        }
                    }
                }

            }
            return answerString;
        }
    }
}
