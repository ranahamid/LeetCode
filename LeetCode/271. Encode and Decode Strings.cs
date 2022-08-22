using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Codec_271
    {
        char separator = (char)257; //outside ASCII range
        // Encodes a list of strings to a single string.
        public string encode(IList<string> strs)
        {
            string s1 = String.Join(separator.ToString(), strs);
            return s1;
        }

        // Decodes a single string to a list of strings.
        public IList<string> decode(string s)
        {
            var data = s.Split(separator);
            return data;
        }
    }
}
