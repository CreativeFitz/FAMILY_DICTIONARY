using System;
using System.Collections.Generic;

namespace Chapter7_FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Krista"},
                {"age", "42"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Henry"},
                {"age", "28"}
            });
            myFamily.Add("dad", new Dictionary<string, string>(){
                {"name", "David"},
                {"age", "62"}
            });

            foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old.");
            }
        }
    }
}
