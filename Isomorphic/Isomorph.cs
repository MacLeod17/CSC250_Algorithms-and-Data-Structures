using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Isomorphic
{
    public class Isomorph
    {
        public static void GenerateIsomorphs(string path)
        {
            IEnumerable<string> result = File.ReadLines(path);

            // "0 0 1", List<string>
            Dictionary<string, List<string>> exactIsoList = new Dictionary<string, List<string>>();

            exactIsoList.Add("0 0 1", new List<string> { "egg" });
            foreach (var item in exactIsoList)
            {
                string key = item.Key;
                List<string> value = item.Value;

                var words = String.Join(" ", value);
            }

            List<string> funWords = new List<string> { "Dog", "cat", "frog", "duck" };
            Console.WriteLine(String.Join(", ", funWords));
        }

        public static void ExactIsomorph(string word)
        {
            
        }
    }
}
