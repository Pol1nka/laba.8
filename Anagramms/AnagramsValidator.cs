using System;
using System.Linq;

namespace Anagramms
{
    public class AnagramsValidator
    {
        public static bool IsAnagram(string item1, string item2)
        {
            char[] splitItem1 = item1.ToCharArray();
            Array.Sort(splitItem1);
            char[] splitItem2 = item2.ToCharArray();
            Array.Sort(splitItem2);
            
            return splitItem1.SequenceEqual(splitItem2);
        }
    }
}