using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {

        //properties up above, then constructors, then methods
        //put methods with least arguments first

        public int CurrentLevel { get; private set; }

        public int NumberOfLevels { get; }

        public bool DoorIsOpen { get; private set; }

        //constructor
       public  Elevator(int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
            CurrentLevel = 1;
            DoorIsOpen = false;

        }
        public Elevator(int numberOfLevels, bool doorIsOpen)
        {
            NumberOfLevels = numberOfLevels;
            CurrentLevel = 1;
            DoorIsOpen = doorIsOpen;

        }
        public void OpenDoor()
        {
            DoorIsOpen = true;
        }
        public void CloseDoor()
            {
            DoorIsOpen = false;
        }
        public void GoUp(int desiredFloor)
        {
            if (!DoorIsOpen && desiredFloor <= NumberOfLevels)
            {
                if (desiredFloor > CurrentLevel)
                {
                    CurrentLevel = desiredFloor;
                }
                else
                {
                    Console.WriteLine("You cannot go up");
                }


            }
        }
        public void GoDown(int desiredFloor)
            {
             if(!DoorIsOpen && desiredFloor >= 1)
            {
                if (desiredFloor<CurrentLevel)
                {
                    CurrentLevel = desiredFloor;
                }
                else
                {
                    Console.WriteLine("You cannot go down");
                }
            }
            }
    }
}
