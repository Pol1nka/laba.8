using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagramms
{
    class Program
    {
        public static void Main()
        {
            string[] array = { "code","doce", "ecod", "framer", "frame" };
            Console.WriteLine($"Массив до: {string.Join(", ", array)}");
            Console.WriteLine($"Массив после: {string.Join(", ", DeletedAnagrams.RemoveAnagrams(array.ToList()))}");
        }
    }
}