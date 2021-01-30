using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
        WordCount wordCount = new WordCount();

        [TestMethod]
        public void TestWordCount()
        {
            string[] array1 = new string[] { "ba", "ba", "black", "sheep" };
            string[] array2 = new string[] { "a", "b", "a", "c", "b" };
            string[] array3 = new string[] { };
            string[] array4 = new string[] { "c", "b", "a" };

            Dictionary<string, int> dictionary1 = new Dictionary<string, int>();
            dictionary1.Add("a", 2);
            dictionary1.Add("b", 2);
            dictionary1.Add("c", 1);
            

            Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
            dictionary2.Add("c", 1);
            dictionary2.Add("b", 1);
            dictionary2.Add("a", 1);

            Dictionary<string, int> dictionary3 = new Dictionary<string, int>();

            Dictionary<string, int> dictionary4 = new Dictionary<string, int>();
            dictionary4.Add("ba", 2);
            dictionary4.Add("black", 1);
            dictionary4.Add("sheep", 1);

            Dictionary<string, int> actual = wordCount.GetCount(array1);
            Dictionary<string, int> actual2 = wordCount.GetCount(array2);
            Dictionary<string, int> actual3 = wordCount.GetCount(array3);
            Dictionary<string, int> actual4 = wordCount.GetCount(array4);

            //*GetCount(["ba", "ba", "black", "sheep"]) → { "ba" : 2, "black": 1, "sheep": 1 }
            //*GetCount(["a", "b", "a", "c", "b"]) → { "a": 2, "b": 2, "c": 1}
            //*GetCount([]) → { }
            //*GetCount(["c", "b", "a"]) → { "c": 1, "b": 1, "a": 1}

            CollectionAssert.AreEqual(dictionary4, actual);
            CollectionAssert.AreEqual(dictionary1, actual2);
            CollectionAssert.AreEqual(dictionary3, actual3);
            CollectionAssert.AreEqual(dictionary2, actual4);


        }

    }
}
