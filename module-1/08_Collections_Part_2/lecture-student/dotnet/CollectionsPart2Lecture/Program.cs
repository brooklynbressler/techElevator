using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {
			//lists and arrays are ordered, dictionaries are UNORDERED
			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();
			//keys are unique, values are not
			//unordered
			//key	value
			Dictionary<string, string> stateCapitols = new Dictionary<string, string>()
			{
				{"IN", "Indianapolis" },
				{"FL", "Tallahase" }
			};

			stateCapitols.Add("KY", "Frankfort");

			//insert OR update
			stateCapitols["KY"] = "Frankfort";
						//key		//value
			stateCapitols["OH"] = "Columbus";

			string floridaKey = "FL";
			string floridaCapitolValue = stateCapitols[floridaKey];

            Console.WriteLine($"The capitol of Florida is: {floridaCapitolValue}");
					//holds the key and value for each entry
 

			bool kyIsInDictionary = stateCapitols.ContainsKey("KY");
            Console.WriteLine($"Is Kentucky in the dictionary: {kyIsInDictionary}");

            if (!kyIsInDictionary)
            {
				stateCapitols.Add("KY", "Frankfort");
            }
            else
            {
				//update KY value to the current value concat with current value
				string kyValue = stateCapitols["KY"];
				string updatedValue = stateCapitols["KY"] + stateCapitols["KY"];
				stateCapitols["KY"] = updatedValue;

			}
			foreach (KeyValuePair<string, string> kvp in stateCapitols)
			{
				Console.WriteLine($"The key is {kvp.Key} and the value {kvp.Value}");
			}

			//simplified data structure that we can loop through
			IEnumerable<string> stateKeys = stateCapitols.Keys;
			IEnumerable<string> stateValues = stateCapitols.Values;

			foreach (string stateKey in stateKeys)
            {
                Console.WriteLine($"Key: {stateKey}");


                Console.WriteLine($"The value is: { stateCapitols[stateKey] }");
            }
            Console.WriteLine("Removing KY from dictionary");
			stateCapitols.Remove("KY");

			foreach (KeyValuePair<string, string> kvp in stateCapitols)
			{
				Console.WriteLine($"The key is {kvp.Key} and the value {kvp.Value}");
			}

			stateCapitols = stateCapitols;
			//create 2 dictionaries of key int value is string
			//add 4 rows to each dictionary
			//if key exists concat two values together
			//combines them into a single dictionary

			Dictionary<int, string> classmatesNames = new Dictionary<int, string>()
			{
				{1, "Christianna" },
				{2, "Wesley"},
				{3, "Brian"},
				{4, "Brooklyn"}
			};
			Dictionary<int, string> classmatesNames2 = new Dictionary<int, string>()
			{
				{4, "Kat" },
				{5, "Maddy"},
				{6, "Chris"},
				{7, "Brooklyn"}
			};

            foreach (KeyValuePair<int, string> numberKeyAndValue in classmatesNames)
            {
				int key = numberKeyAndValue.Key;
				string value = numberKeyAndValue.Value;

                if (classmatesNames2.ContainsKey(key))
                {
					classmatesNames2[key] = classmatesNames[key] + classmatesNames2[key];  
                }
                else
                {
					classmatesNames2[key] = value;
                }
                foreach (KeyValuePair<int, string> kvp in classmatesNames2)
                {
                    Console.WriteLine($"Key is {kvp.Key} value is {kvp.Value}");
                }
            }




		}
	}
}
