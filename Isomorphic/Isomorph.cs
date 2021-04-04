using System;
using System.Collections.Generic;
using System.IO;

namespace Isomorphic
{
    public class Letter
    {
        public char _Letter { get; set; }
        public int Value { get; set; }

        public Letter(char let, int val)
        {
            this._Letter = let;
            this.Value = val;
        }
    }

    public class Isomorph
    {
        public static Dictionary<string, List<string>> exactIsomorphs = new Dictionary<string, List<string>>();
        public static Dictionary<string, List<string>> looseIsomorphs = new Dictionary<string, List<string>>();

        public static List<string> nonIsomorphs = new List<string>();

        public static void GenerateIsomorphs(string path)
        {
            // Separate file into list of words
            IEnumerable<string> results = File.ReadLines(path);

            // Add each word to it's respective exact and loose isomorph groups
            foreach (var word in results)
            {
                //Console.WriteLine(word);

                ExactIsomorph(word);
                LooseIsomorph(word);
            }

            // Separate non-isomorphs from the rest
            NonIsomorphs();

            // Delete non-isomorphs from the isomorph lists
            RemoveNonIsomorphs();

            // Print isomorphs to Console
            DisplayIsomorphs();

            // Save output to file
            SaveOutput();

            Console.WriteLine("\nOutput.txt is located in the TextFiles folder.");
        }

        public static void ExactIsomorph(string word)
        {
            // Stores every unique character, i.e. 'g' and 'a' stored from gag, not 'g' 'a' 'g'
            List<Letter> letters = new List<Letter>();

            // Stores the exact isomorphic frequency of the word, i.e. "0 1 0" for "gag"
            string exactFrequency = string.Empty;

            // Iterate over each letter in the given word
            for (int i = 0; i < word.Length; i++)
            {
                Letter let = new Letter(word[i], i);

                // Iterate over every previously encountered letter
                foreach (var letter in letters)
                {
                    // Check if current letter has already been encountered
                    if (letter._Letter == let._Letter)
                    {
                        let = letter;
                        break;
                    }
                }

                exactFrequency += $"{let.Value} ";
                letters.Add(let);
            }

            exactFrequency = exactFrequency.Trim();
            //Console.WriteLine(exactFrequency);

            if (exactIsomorphs.ContainsKey(exactFrequency))
            {
                exactIsomorphs.GetValueOrDefault(exactFrequency).Add(word);
            }
            else
            {
                exactIsomorphs.Add(exactFrequency, new List<string> { word });
            }
            exactIsomorphs.GetValueOrDefault(exactFrequency).Sort();
        }

        public static void LooseIsomorph(string word)
        {
            // Stores every unique character, i.e. 'g' and 'a' stored from gag, not 'g' 'a' 'g'
            List<Letter> letters = new List<Letter>();

            // Iterate over each letter in the given word
            for (int i = 0; i < word.Length; i++)
            {
                Letter let = new Letter(word[i], 1);
                bool letterEncountered = false;

                // Iterate over every previously encountered letter
                foreach (var letter in letters)
                {
                    // Check if current letter has already been encountered
                    if (letter._Letter == word[i])
                    {
                        // Increment # of times letter has been used
                        letter.Value++;
                        letterEncountered = true;
                        break;
                    }
                }
                if (!letterEncountered)
                {
                    letters.Add(let);
                }
            }

            List<int> letterCounts = new List<int>();
            foreach (var letter in letters)
            {
                letterCounts.Add(letter.Value);
            }
            letterCounts.Sort();

            // Stores the loose isomorphic frequency of the word, i.e. "1 2" for "gag"
            string looseFrequency = string.Empty;

            foreach (var count in letterCounts)
            {
                looseFrequency += $"{count} ";
            }

            looseFrequency = looseFrequency.Trim();
            //Console.WriteLine(looseFrequency);

            if (looseIsomorphs.ContainsKey(looseFrequency))
            {
                looseIsomorphs.GetValueOrDefault(looseFrequency).Add(word);
            }
            else
            {
                looseIsomorphs.Add(looseFrequency, new List<string> { word });
            }
            looseIsomorphs.GetValueOrDefault(looseFrequency).Sort();
        }

        public static void NonIsomorphs()
        {
            // Iterate over all isomorph groups
            foreach (var key in looseIsomorphs.Keys)
            {
                var group = looseIsomorphs.GetValueOrDefault(key);

                // Identify if the group is a single word (non-isomorphic)
                if (group.Count == 1)
                {
                    // Add word to list of non-isomorphs
                    nonIsomorphs.Add(group[0]);
                }
            }

            // Sort non-isomorphs alphabetically
            nonIsomorphs.Sort();
        }

        public static void RemoveNonIsomorphs()
        {
            foreach (var key in exactIsomorphs.Keys)
            {
                var group = exactIsomorphs.GetValueOrDefault(key);

                // Identify if the group is a single word (non-isomorphic)
                if (group.Count <= 1)
                {
                    // Remove the group from exactIsomorphs
                    group.Clear();
                    exactIsomorphs.Remove(key);
                }
            }
            
            foreach (var key in looseIsomorphs.Keys)
            {
                var group = looseIsomorphs.GetValueOrDefault(key);

                // Identify if the group is a single word (non-isomorphic)
                if (group.Count <= 1)
                {
                    // Remove the group from loose Isomorphs
                    group.Clear();
                    looseIsomorphs.Remove(key);
                }
            }

            // Sort loose and exact isomorphs by frequency
            SortedDictionary<string, List<string>> tempExact = new SortedDictionary<string, List<string>>(exactIsomorphs);
            exactIsomorphs = new Dictionary<string, List<string>>(tempExact);

            SortedDictionary<string, List<string>> tempLoose = new SortedDictionary<string, List<string>>(looseIsomorphs);
            looseIsomorphs = new Dictionary<string, List<string>>(tempLoose);
        }

        public static void DisplayIsomorphs()
        {
            // Print exact isomorphs to console
            Console.WriteLine("Exact Isomorphs");
            foreach (var key in exactIsomorphs.Keys)
            {
                string words = string.Empty;
                foreach (var word in exactIsomorphs.GetValueOrDefault(key))
                {
                    words += $"{word} ";
                }
                words = words.Trim();
                Console.WriteLine($"{key}: {words}");
            }
            Console.WriteLine();

            // Print loose isomorphs to console
            Console.WriteLine("Loose Isomorphs");
            foreach (var key in looseIsomorphs.Keys)
            {
                string words = string.Empty;
                foreach (var word in looseIsomorphs.GetValueOrDefault(key))
                {
                    words += $"{word} ";
                }
                words = words.Trim();
                Console.WriteLine($"{key}: {words}");
            }
            Console.WriteLine();

            // Print non-isomorphs to console
            Console.WriteLine("Non-isomorphs");
            string nonIsos = string.Empty;
            foreach (var word in nonIsomorphs)
            {
                nonIsos += $"{word} ";
            }
            nonIsos = nonIsos.Trim();
            Console.WriteLine(nonIsos);
        }

        public static void SaveOutput()
        {
            string output = string.Empty;

            output += "Exact Isomorphs\n";
            foreach (var key in exactIsomorphs.Keys)
            {
                string words = string.Empty;
                foreach (var word in exactIsomorphs.GetValueOrDefault(key))
                {
                    words += $"{word} ";
                }
                words = words.Trim();
                output += $"{key}: {words}\n";
            }

            output += "\nLoose Isomorphs\n";
            foreach (var key in looseIsomorphs.Keys)
            {
                string words = string.Empty;
                foreach (var word in looseIsomorphs.GetValueOrDefault(key))
                {
                    words += $"{word} ";
                }
                words = words.Trim();
                output += $"{key}: {words}\n";
            }

            output += "\nNon-isomorphs\n";
            string nonIsos = string.Empty;
            foreach (var word in nonIsomorphs)
            {
                nonIsos += $"{word} ";
            }
            nonIsos = nonIsos.Trim();
            output += nonIsos;

            File.WriteAllText("../../../TextFiles/Output.txt", output);
        }
    }
}
