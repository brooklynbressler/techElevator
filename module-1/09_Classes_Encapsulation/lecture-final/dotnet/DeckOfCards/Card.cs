using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Card
    {

         public string Suit { get;  }
         public int Value { get; }
        //only can be changed in this class
         public bool FaceUp { get; private set; }
        //color TODO
        public Card(string suit, int value)
        {
            //'this' references the property for the current instance 
            this.Suit = suit;
            this.Value = value;
            //setting face up default false
            this.FaceUp = false; 

        }
        //derived
        public string FaceValue
        {
            get
            {
                //where the logic happens
                return faceValue[Value];
            }
        }

        public void Flip()
        {
            //if Faceup is true set to false
            //if faceup is false set to true
            /*
            if (FaceUp)
            {
                FaceUp = false;
            } 
            else
            {
                FaceUp = true;
            }
            */

            // FaceUp = (FaceUp == true) ? false : true;

            FaceUp = !FaceUp;
        }


        public static List<string> suits = new List<string>()
        {
            "Hearts","Diamonds", "Spades", "Clubs"
        };

        //static values are true for ALL instances of a class
        //dont need an instance of the class to access it
        private static Dictionary<int, string> faceValue = new Dictionary<int, string>()
        {
            {1, "Ace" },
            {2, "Two" },
            {3, "Three"}
        };
    }
}
