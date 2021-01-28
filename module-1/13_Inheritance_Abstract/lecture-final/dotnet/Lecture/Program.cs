﻿using Lecture.Farming;
using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // OLD MACDONALD
            //
 
            //collection of type FarmAnimal - can include any type derived from FarmAnimal as well
            ISingable[] singingFarmCollection = new ISingable[] { new Cow(), new Chicken(), new Sheep() , new Tractor()};

          // RidingTractor johnDeere = new RidingTractor();
          //  johnDeere.Mow();
            //cant change because protected set
            //johnDeere.NumberOfTires = 4;

            //interfaces cant be instantiated
            //ISingable test = new ISingable();
            //
           //FarmAnimal animal1 = new FarmAnimal("generic animal");

            foreach (ISingable farmSinger in singingFarmCollection)
            {
                Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
                Console.WriteLine("And on his farm he had a " + farmSinger.Name + ", ee ay ee ay oh!"); //property from Base Class - not polymorphism
                Console.WriteLine("With a " + farmSinger.MakeSound() + " " + farmSinger.MakeSound() + " here");
                Console.WriteLine("And a " + farmSinger.MakeSound(2) + "there");//calling overloaded MakeSound method in FarmAnimal
                Console.WriteLine("Here a " + farmSinger.MakeSound() + " there a " + farmSinger.MakeSound() + " everywhere a " + farmSinger.MakeSound() + " " + farmSinger.MakeSound());
                Console.WriteLine();
            }

        }
    }
}