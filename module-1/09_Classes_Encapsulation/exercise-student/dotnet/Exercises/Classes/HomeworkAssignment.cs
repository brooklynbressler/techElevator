namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }
        public string LetterGrade
        {
            get
            {
                double grade = ((double)EarnedMarks / PossibleMarks) * 100;
                string result = "";
                
                if(grade >= 90)
                {
                    result = "A";
                }
                else if(grade >= 80)
                {
                    result = "B";
                }
                else if(grade >= 70)
                {
                    result = "C";
                }
                else if(grade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                return result;

            }
        }
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName; 
        }

    }
}
