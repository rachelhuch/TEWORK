using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        public string TypeOfFruit { get; }
        public int PiecesOfFruitLeft { get; private set; }
        //Fruit Tree is the constructor. Name same as class. If there are parameters
        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            this.TypeOfFruit = typeOfFruit;
            this.PiecesOfFruitLeft = startingPiecesOfFruit;
        }
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            int remainingFruit = PiecesOfFruitLeft - numberOfPiecesToRemove;
            if (remainingFruit<0)
            {
                return false;
            }
            else
            {
                this.PiecesOfFruitLeft = remainingFruit;
                return true;
            }
            
        }
    }
    
}
