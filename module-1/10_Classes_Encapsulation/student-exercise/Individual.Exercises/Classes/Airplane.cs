using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.PlaneNumber = planeNumber;
            this.TotalFirstClassSeats = totalFirstClassSeats;
            this.TotalCoachSeats = totalCoachSeats;
        }
        public string PlaneNumber { get; }
        public int BookedFirstClassSeats { get; private set; }

        public int AvailableFirstClassSeats
        {
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }


        public int TotalFirstClassSeats { get; }

        public int BookedCoachSeats { get; private set; }

        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }


        public int TotalCoachSeats { get; }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {

            if (!forFirstClass && AvailableCoachSeats >= totalNumberOfSeats)
            {
                BookedCoachSeats = BookedCoachSeats + totalNumberOfSeats;
                return true;
            }
            else if (forFirstClass && AvailableFirstClassSeats >= totalNumberOfSeats)
            {
                BookedFirstClassSeats = totalNumberOfSeats + BookedFirstClassSeats;
                return true;
            }
            else
            {
                return false;
            }

        }
    } }




