using System;

namespace Isomorphic
{
    public class Program
    {
        #region My Input Paths
        // C:\Users\Garrick Kilpack\source\repos\Algorithms & Data Structures\ALGO\Isomorphic\TextFiles\IsomorphInput1.txt
        // C:\Users\Garrick Kilpack\source\repos\Algorithms & Data Structures\ALGO\Isomorphic\TextFiles\IsomorphInput2.txt
        #endregion

        #region My Output Paths
        // C:\Users\Garrick Kilpack\source\repos\Algorithms & Data Structures\ALGO\Isomorphic\TextFiles\IsomorphOutput1.txt
        // C:\Users\Garrick Kilpack\source\repos\Algorithms & Data Structures\ALGO\Isomorphic\TextFiles\IsomorphOutput2.txt
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Path to File?");
            var path = Console.ReadLine();
            Console.WriteLine();
            Isomorph.GenerateIsomorphs(path);
        }
    }
}
