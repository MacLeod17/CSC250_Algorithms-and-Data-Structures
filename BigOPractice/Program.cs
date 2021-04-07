using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace BigOPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            //Random random = new Random();

            // long[] useMe = gen
            //List<int> bigInt = GenerateArray(1000).ToList();
            //List<int> match1 = GenerateArray(250000).ToList();
            //List<int> match2 = GenerateArray(250000).ToList();

            //match1.Sort();
            //match2.Sort();

            watch.Start();

            //var matchingArray = Algorithms.MatchMe(match1.ToArray(), match2.ToArray());
            //var highInt = Algorithms.Algorithm(bigInt.ToArray());
            Algorithms.Palindrome("bruh");
            Algorithms.Palindrome("mAdam");
            Algorithms.Palindrome("nurses run");

            watch.Stop();

            // This was commented out when I was getting the operation count because there were so many ints
            //    that the operation count could not be found in the console
            //Console.WriteLine("[" + string.Join(", ", matchingArray) + "]");

            //Console.WriteLine("Highest Value: " + highInt);

            var elapsedTime = watch.ElapsedMilliseconds != 0 ? watch.ElapsedMilliseconds : watch.ElapsedTicks;
            string milliOrTricks = watch.ElapsedMilliseconds == 0 ? "Ticks" : "ms";
            Console.WriteLine($"Execution Time {elapsedTime} " + milliOrTricks);
        }

        public static int[] GenerateArray(int numberOfItems)
        {
            int[] returnArray = new int[numberOfItems];

            Random rand = new Random();

            for (int i = 0; i < numberOfItems; i++)
            {
                returnArray[i] = rand.Next(0, numberOfItems);
            }
            return returnArray;
        }
    }
}