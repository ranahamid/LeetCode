using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 184 ms, faster than 74.75% of C# online submissions for Find Common Characters.
    /// Memory Usage: 44.5 MB, less than 53.54% of C# online submissions for Find Common Characters.
    /// </summary>
    public class _1002__Find_Common_Characters {
        
        public static List<string> CommonChars(string[] words)
        {
            var common = words[0].ToCharArray();
            for (int i = 1; i < words.Length; i++)
            {
                var word = words[i].ToCharArray();
                common = IntersectWithDuplicate(common,word).ToArray();
            }

            var result = new List<string>();
            foreach (var ch in common)
            {
                result.Add(ch.ToString());
            }
            return result;
        }
        
        public static IEnumerable<T> IntersectWithDuplicate<T>( IEnumerable<T> source, IEnumerable<T> target)
        {
            List<T> list = target.ToList();
            foreach (T item in source)
            {
                if (list.Contains(item))
                {
                    list.Remove(item);
                    yield return item;
                }
            }
        }


    }
}