using System;

namespace Lecture.Farming
{
    public class Chicken : FarmAnimal, IEggProducer
    {
        public Chicken() : base("Chicken")
        {
        }

        public void LayEgg()
        {
            Console.WriteLine("Chicken laid an egg!");
        }

        public override string MakeSound()
        {
            return "cluck";
        }
    }
}
