using System;
using System.Text;

namespace CommonSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var sc = new SubstringChecks();
            Console.WriteLine(sc.LongestCommonSubstring("AABCCCC", "BACCCCA"));
        }
    }
}