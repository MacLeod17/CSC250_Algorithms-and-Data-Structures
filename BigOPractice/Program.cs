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
            Random random = new Random();

            // long[] useMe = gen
            List<int> match1 = GenerateArray(250000).ToList();
            List<int> match2 = GenerateArray(250000).ToList();

            match1.Sort();
            match2.Sort();
            //watch.Start();
            //var highestValue = Algorithims.Algorithim(useMe);
            //Algorithims.Algorithim(useMe);

            watch.Start();
            var matchingArray = Algorithms.MatchMe(match1, match2);
            watch.Stop();

            Console.WriteLine("[" + String.Join(", ", matchingArray) + "]");

            //Console.WriteLine("Highest Value: " + highestValue);

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