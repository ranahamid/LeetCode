using System.Collections.Generic;

namespace LeetCode
{
    public class _824__Goat_Latin {
        
        /// <summary>
        /// Runtime: 89 ms, faster than 93.02% of C# online submissions for Goat Latin.
        /// Memory Usage: 36.4 MB, less than 58.14% of C# online submissions for Goat Latin.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static string ToGoatLatin(string sentence)
        {
            var words = sentence.Split(' ');
            var vowel = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                var st = words[i].ToCharArray();
          
                bool isRemoveFirst = !vowel.Contains(st[0]);
                var newWord = new List<char>();
                for (int j = 0; j < st.Length; j++)
                {
                    if (j == 0)
                    {
                        if (!isRemoveFirst)
                        {
                            newWord.Add(st[j]);
                        }
                    }
                    else
                    {
                        newWord.Add(st[j]);
                    }
                }
                if(isRemoveFirst)
                    newWord.Add(st[0]);
                newWord.Add('m');
                newWord.Add('a');
                for (int k = 0; k < i + 1; k++)
                {
                    newWord.Add('a');
                }
                result.Add(new string(newWord.ToArray()));
            } 
            return string.Join(" ", result);
        }

    }
}