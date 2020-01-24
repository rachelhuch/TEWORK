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

        public string LetterGrade {
            get
            {
                return "A";//come back
            }
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;

        }

    }
}
