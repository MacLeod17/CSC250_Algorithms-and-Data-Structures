using System;
using System.Collections.Generic;
using System.Text;

namespace BigOPractice
{
    public class Algorithms
    {
        public static int[] MatchMe(int[] a1, int[] a2)
        {
            List<int> matchingNumbers = new List<int>();
            long operationCount = 0;

            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a2.Length; j++)
                {
                    operationCount++;
                    //If first item in a1 equal to item in second (a2) list
                    if (a2[i] == a2[j])
                    {
                        // Add matching number
                        matchingNumbers.Add(a1[i]);
                        break;
                    }
                }
            }
            Console.WriteLine("Operations: " + operationCount);
            return matchingNumbers.ToArray();
        }

        public static int Algorithm(int[] A)
        {
            long operationCount = 0;
            if (A.Length > 0)
            {
                // Last item in the array
                int x = A.Length - 1;

                //first item in the Array / largest Number
                int y = A[0];

                //for i q to x d
                //Is current index value greater than stored
                for (int i = 1; i <= x; i++)
                {
                    operationCount++;
                    if (A[i] > y)
                    {
                        //y = a[i]
                        //We found a new high value, set it!
                        y = A[i];
                    }
                }
                Console.WriteLine("Operations: " + operationCount);

                // return the largest number
                return y;
            }
            return -1;
        }

        public static bool Palindrome(string phrase)
        {
            bool success = false;

            string reverse = string.Empty;

            // Makes spaces and character case irrelevant ("nurses run" and "mAdam" are palindromes)
            string tempPhrase = phrase.Replace(" ", "").ToLower();

            for (int i = tempPhrase.Length-1; i >= 0; i--)
            {
                reverse += tempPhrase[i];
            }

            if (reverse == tempPhrase)
            {
                success = true;
            }

            Console.WriteLine($"{phrase} Is Palindrome: {success}");

            return success;
        }
    }
}