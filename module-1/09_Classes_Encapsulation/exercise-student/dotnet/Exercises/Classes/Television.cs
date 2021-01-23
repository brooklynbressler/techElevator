namespace Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }

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
            CurrentChannel = 3;
            CurrentVolume = 2;
        }
        public void ChangeChannel(int newChannel)
        {
            if(IsOn == true && newChannel >= 3 && newChannel <= 18)
            {
                CurrentChannel = newChannel;
            }
        }
        public void ChannelUp()
        {
            if(IsOn == true && CurrentChannel < 18)
            {
                CurrentChannel = CurrentChannel + 1;
            }
            else if(IsOn == true && CurrentChannel == 18)
            {
                CurrentChannel = 3;
            }
        }
        public void ChannelDown()
        {
            if (IsOn == true && CurrentChannel > 3 && CurrentChannel < 18)
            {
                CurrentChannel = CurrentChannel - 1;
            }
            else if (IsOn == true && CurrentChannel == 3)
            {
                CurrentChannel = 18;
            }
        }
        public void RaiseVolume()
        {
            if(IsOn == true && CurrentVolume < 10)
            {
                CurrentVolume = CurrentVolume + 1;
            }
            
        }
        public void LowerVolume()
        {
            if (IsOn == true && CurrentVolume > 0)
            {
                CurrentVolume = CurrentVolume - 1;
            }
        }

    }
}
