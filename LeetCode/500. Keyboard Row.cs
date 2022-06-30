using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _500__Keyboard_Row {
        /// <summary>
        /// Runtime: 258 ms, faster than 19.59% of C# online submissions for Keyboard Row.
        /// Memory Usage: 43.3 MB, less than 42.27% of C# online submissions for Keyboard Row.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string[] FindWords(string[] words)
        {
            var result = new List<string>();
            var firstRow=new string[] { "q","w","e","r" , "t","y","u","i", "o","p"};
            var secondRow=new string[] { "a","s","d","f" , "g","h","j","k", "l"};
            var thirdRow=new string[] { "z","x","c","v" , "b","n","m"};
            foreach (var word in words)
            {
                var sChars = word.ToCharArray().Select(x=> char.ToLower(x) .ToString()).ToList();
                var yes = sChars.All(x => firstRow.Contains(x));
                if(!yes)
                    yes = sChars.All(x => secondRow.Contains(x));
                if(!yes) 
                    yes = sChars.All(x => thirdRow.Contains(x));
                if(yes)
                    result.Add(word);
            }

            return result.ToArray();
        }


    }
}