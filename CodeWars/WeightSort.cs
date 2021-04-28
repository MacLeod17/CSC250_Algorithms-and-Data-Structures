using System;
using System.Collections.Generic;

namespace CodeWars
{
	public class Number : IComparable<Number>
    {
        public string Num { get; set; }
        public int Weight { get; set; }

		public Number(string n, int w)
        {
			Num = n;
			Weight = w;
        }

		// Compares the Weight first (sum of every digit of the Num); if Weight is equal, compares Num
        public int CompareTo(Number num)
        {
			int compareValue = Weight.CompareTo(num.Weight);

			if (compareValue == 0) compareValue = Num.CompareTo(num.Num);

			return compareValue;
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
				// Sum of digits
				int numWeight = 0;

				foreach(char c in w)
                {
					int n = int.Parse(c.ToString());
					numWeight += n;
                }

				// Ties the Weight of the number to the number itself
				Number num = new Number(w, numWeight);

				// Adds the Tied Number-Weight to a list
				numWeights.Add(num);
            }

			// Selection Sort
			for (int i = 0; i < numWeights.Count; i++)
			{
				int lowestIndex = i;

				for (int j = i; j < numWeights.Count; j++)
				{
					if (numWeights[j].CompareTo(numWeights[lowestIndex]) < 0)
					{
						lowestIndex = j;
					}
				}

				var temp = numWeights[i];
				numWeights[i] = numWeights[lowestIndex];
				numWeights[lowestIndex] = temp;
			}
			//

			string output = string.Empty;
			foreach (var num in numWeights)
            {
				output += $"{num.Num} ";
            }
			output = output.Trim();

			return output;
		}
	}
}
