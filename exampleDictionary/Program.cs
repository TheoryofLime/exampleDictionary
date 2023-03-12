using System;
using System.Collections.Generic;

namespace exampleDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> newDictionary = new Dictionary<string, int>();
            // add stuff
            newDictionary.Add("A", 1);
            newDictionary.Add("B", 2);
            newDictionary.Add("C", 3);
            newDictionary.Add("D", 4);
            newDictionary.Add("E", 5);
            // display all the keys
            foreach (KeyValuePair<string, int> input in newDictionary) Console.WriteLine(input.Key);
            // display all the values
            foreach (KeyValuePair<string, int> input in newDictionary) Console.WriteLine(input.Value);
            // both i guess
            foreach (KeyValuePair<string, int> input in newDictionary) Console.WriteLine(input.Key, input.Value);
            // remove
            newDictionary.Remove("A");
            // display count
            Console.WriteLine(newDictionary.Count);
        }
    }
}