using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given two lists of Integers, interleave them beginning with the first element in the first list followed
         by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
         Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
         list to the new list before returning it.
		 DIFFICULTY: HARD
         InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
         */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            List<int> newList = new List<int>();
            //find longer list
            int listOneCount = listOne.Count;
            int listTwoCount = listTwo.Count;
            bool longerOneLonger = listOne.Count > listTwo.Count;

            //first of listOne and added to new list
            if (listTwoCount>listOneCount)
            {
                while (listOne.Count > 0)
                {
                    newList.Add(listOne[0]);
                    listOne.RemoveAt(0);
                    newList.Add(listTwo[0]);
                    listTwo.RemoveAt(0);
                }
                newList.AddRange(listTwo);
            }


            else
            {
                while (listTwo.Count > 0)
                {
                    newList.Add(listOne[0]);
                    listOne.RemoveAt(0);
                    newList.Add(listTwo[0]);
                    listTwo.RemoveAt(0);
                }
                newList.AddRange(listOne);
            }
            
            return newList;
        }
    }
}
