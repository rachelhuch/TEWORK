using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        public Television()
        {
            IsOn = false;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }
        public void TurnOff()
        {
            IsOn = false;
        }
        public void TurnOn()
        {
            IsOn = true;
            ChangeChannel(3);

        }
        public void ChangeChannel(int newChannel)
        {
            if (IsOn)
            {
                CurrentChannel = newChannel;
            }
        }
        public void ChannelUp()
        {
            if (IsOn)
            {
                if (CurrentChannel == 18)
                {
                    CurrentChannel = 3;
                }
                else if (CurrentChannel >= 3 && CurrentChannel <= 17)
                {
                    CurrentChannel++;
                }

            }
        }

        public void ChannelDown()
        {
            if (IsOn)
            {
                if (CurrentChannel == 3)
                {
                    CurrentChannel = 18;
                }
                else if (CurrentChannel > 3 && CurrentChannel <= 18)
                {
                    CurrentChannel--;
                }

            }
        }
        public void RaiseVolume()
        {
            if (IsOn)
            {
                if (CurrentVolume < 10)
                {
                    CurrentVolume++;
                }
                else if (CurrentVolume == 10)
                {
                    CurrentVolume = CurrentVolume;
                }
            }


        }

        public void LowerVolume()
        {
            if (IsOn)
            {
                if (CurrentVolume > 0)
                {
                    CurrentVolume--;
                }
                else if(CurrentVolume==0)
                {
                    CurrentVolume = CurrentVolume;
                }

            }
        }

        //default for boolean is false
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }
    }
    }


