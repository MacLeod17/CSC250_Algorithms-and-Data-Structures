using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
	public class Number
    {
        public string Num { get; set; }
        public int Weight { get; set; }

		public Number(string n, int w)
        {
			Num = n;
			Weight = w;
        }
    }

	public class WeightSort
	{

		public static string orderWeight(string strng)
		{
			// Separate weights into individual strings
			List<string> weights = new List<string>(strng.Split(" "));
			List<Number> numWeights = new List<Number>();
			
			foreach (string w in weights)
            {
				int numWeight = 0;

				foreach(char c in w)
                {
					int n = int.Parse(c.ToString());
					numWeight += n;
                }

				Number num = new Number(w, numWeight);

				numWeights.Add(num);
            }

			var sortWeight = numWeights.OrderBy(num => num.Weight).ThenBy(num => num.Num);

			string output = string.Empty;
			foreach (var num in sortWeight)
            {
				output += $"{num.Num} ";
            }
			output = output.Trim();

			return output;
		}
	}
}
