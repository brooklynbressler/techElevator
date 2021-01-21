using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");
			//list of ints called numbers = new empty list of ints
			List<int> numbers = new List<int>() { 1, 2, 100 };
			numbers.Add(5);
			numbers.Add(4);

			numbers.Sort();
			numbers.Reverse();


            List<string> adventureTimeCharacters = new List<string>() {"Marceline", "Finn", "Jake" };
			adventureTimeCharacters.Add("Princess Bubblegum");
			adventureTimeCharacters.Add("marceline jr");
			//init		//condition //iterator
			//for(int i = 0; i < adventureTimeCharacters.Count ; i++)
			//{
			//	Console.WriteLine(adventureTimeCharacters[i]);
			//}
			//		//type of elements in collection

			//foreach (int number in numbers)
			//{
			//    Console.WriteLine(number);
			//}

			foreach (string character in adventureTimeCharacters)
            {
				Console.WriteLine(character);
            }

			Console.WriteLine("After Sort");
			adventureTimeCharacters.Sort();

			foreach (string character in adventureTimeCharacters)
			{
				Console.WriteLine(character);
			}
			

			adventureTimeCharacters = adventureTimeCharacters;


			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");



			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");
			adventureTimeCharacters.Add("Finn");

			foreach (string character in adventureTimeCharacters)
			{
			Console.WriteLine(character);
			}

			//return;//bad code remove when done

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			adventureTimeCharacters.Insert(2, "Ice King");

			foreach (string character in adventureTimeCharacters)
			{
				Console.WriteLine(character);
			}

			//return;//bad code remove when done

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");


			adventureTimeCharacters.RemoveAt(2);
			foreach (string character in adventureTimeCharacters)
			{
				Console.WriteLine(character);
			}
			//using string<type>
			//Case-sensitive
			//adventureTimeCharacters.RemoveAll("Finn");
			//Don't modify collections as you're looping, unpredictable
			List<string> adventureTimeCharactersWithoutFinn = new List<string>();
			foreach (string character in adventureTimeCharacters)
			{
				if(character != "Finn")
                {
					adventureTimeCharactersWithoutFinn.Add(character);
                }
			}

			//return;//bad code remove when done

			Console.WriteLine("#################### Removing All Finns ####################");
			foreach (string character in adventureTimeCharactersWithoutFinn)
			{
				Console.WriteLine(character);
			}

			//return;//bad code remove when done

			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

			bool isJakeInList = adventureTimeCharactersWithoutFinn.Contains("Jake");

            Console.WriteLine($"Is Jake in list: {isJakeInList}");

			//return;//bad code remove when done

			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			int jakesIndex = adventureTimeCharactersWithoutFinn.IndexOf("Jake");
            Console.WriteLine($"Jake's location is at index: {adventureTimeCharactersWithoutFinn.IndexOf("Jake")}");

			//return;//bad code remove when done

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			string[] charactersAsArray = adventureTimeCharactersWithoutFinn.ToArray();

			//create list from array
			List<string> backToList = new List<string>(charactersAsArray);

			//
			adventureTimeCharactersWithoutFinn.AddRange(backToList);
			//backToList = backToList;

		}
	}
}
