using System.Collections.Generic;

namespace LeetCode
{
    public class _929__Unique_Email_Addresses {
        
        
        /// <summary>
        /// Runtime: 136 ms, faster than 46.83% of C# online submissions for Unique Email Addresses.
        /// Memory Usage: 40.6 MB, less than 26.12% of C# online submissions for Unique Email Addresses.
        /// </summary>
        /// <param name="emails"></param>
        /// <returns></returns>
        public static int NumUniqueEmails(string[] emails)
        {
            HashSet<string> result = new HashSet<string>();
            foreach (var email in emails)
            {
                var words = email.Split('@');
                var w=words[0].Replace(".","");
                words[0] = w;
                var index = words[0].IndexOf("+");
                if (index > 0)
                {
                    var substring = words[0].Substring(0, index);
                    words[0] = substring;
                }
             
                var data = string.Join("@", words);
                result.Add(data);
            }

            return result.Count;
        }

    }
    }
 