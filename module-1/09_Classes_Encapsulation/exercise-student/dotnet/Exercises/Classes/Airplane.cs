namespace Exercises.Classes
{
    public class Airplane
    {
        public string PlaneNumber { get; private set; }
        public int TotalFirstClassSeats { get; private set; }
        public int BookedFirstClassSeats { get; private set; }
        public int AvailableFirstClassSeats
        {


            get
            {


                return TotalFirstClassSeats - BookedFirstClassSeats;


            }
        }
        public int TotalCoachSeats { get; private set; }
        public int BookedCoachSeats { get; private set; }
        public int AvailableCoachSeats
        {
            get
            {

                return TotalCoachSeats - BookedCoachSeats;

            }
        }
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            bool flag = false;

            if (forFirstClass == true && totalNumberOfSeats <= AvailableFirstClassSeats)
            {
                BookedFirstClassSeats = BookedFirstClassSeats + totalNumberOfSeats;
                flag = true;
            }
            else if (forFirstClass == false && totalNumberOfSeats <= AvailableCoachSeats)
            {
                BookedCoachSeats = BookedCoachSeats + totalNumberOfSeats;
                flag = true;
            }
            return flag;
        }

    }

}
