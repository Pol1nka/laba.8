using System.Collections.Generic;

namespace Anagramms
{
    public class DeletedAnagrams
    {
        public static string[] RemoveAnagrams(List<string> list)
        {
            while (true)
            {
                int indexToRemove = -1;
                for (int i = 0; i < list.Count; i++)
                {
                    if (indexToRemove >= 0) break;
                    
                    for (int j = i; j > 0; j--)
                        if (AnagramsValidator.IsAnagram(list[j-1], list[i])) indexToRemove = i;
                }

                if (indexToRemove == -1) return list.ToArray();

                list.RemoveAt(indexToRemove);
            }
        }
    }
}