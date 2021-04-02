using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Isomorphic
{
    public static class Extensions
    {
        public static Letter GetLetter(this List<Letter> lettersList, char findMe)
        {
            foreach (Letter let in lettersList)
            {
                if (let._Letter == findMe)
                {
                    return let;
                }
            }

            return null;
        }

        public static IsomorphObj GetIso(this List<IsomorphObj> isoList, string findMe)
        {
            for (int i = 0; i < isoList.Count; i++)
            {
                if (isoList[i].IsomorphString == findMe)
                {
                    return isoList[i];
                }
            }

            return null;
        }
    }

    public class Letter : IComparable
    {
        public char _Letter { get; set; }
        public int Value { get; set; }

        public Letter(char let, int val)
        {
            this._Letter = let;
            this.Value = val;
        }

        public int CompareTo(object obj)
        {
            return string.Compare(_Letter.ToString(), ((Letter)obj)._Letter.ToString());
        }
    }

    public class IsomorphObj
    {
        // "1 2" : ["egg", "add"]

        public string IsomorphString { get; set; }

        public List<string> WordList { get; set; }

        public IsomorphObj(string isoString, string word)
        {
            this.IsomorphString = isoString;
            this.WordList = new List<string> { word };
        }
    }

    public class Isomorph
    {
        public static void GenerateIsomorphs(string path)
        {
            #region Learner's Code
                /*
                List<IsomorphObj> exactIsomorphs = new List<IsomorphObj>();
                exactIsomorphs.Add(new IsomorphObj("1 2", "egg"));

                var found = exactIsomorphs.GetIso("1 2");
                if (found != null)
                {
                    found.WordList.Add("add");
                }
                else
                {
                    exactIsomorphs.Add(new IsomorphObj("1 2", "add"));
                }

                List<Letter> letterList = new List<Letter>();
                letterList.Add(new Letter('c', 0));
                var letterFound = letterList.GetLetter('c');

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
                */
            #endregion
        }

        public static void ExactIsomorph(string word)
        {
            
        }
    }
}
