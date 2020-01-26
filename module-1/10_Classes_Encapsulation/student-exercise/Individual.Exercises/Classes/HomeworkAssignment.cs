using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }

        public int PossibleMarks { get; }

        public string SubmitterName { get; }

        public string LetterGrade
        {
            get
            {
                double percentage = (double)EarnedMarks / PossibleMarks;
                if (percentage >= .90)
                {
                    return "A";
                }
                else if (percentage > .80)
                {
                    return "B";
                }
                else if (percentage > .70)
                {
                    return "C";
                }
                else if (percentage > .60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }

            }
        }
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.PossibleMarks = possibleMarks;
            this.SubmitterName = submitterName;

        }

    }
}
