using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class Codec_535
    {
        /// <summary>
        /// Runtime: 125 ms, faster than 45.10% of C# online submissions for Encode and Decode TinyURL.
        /// Memory Usage: 38.3 MB, less than 27.45% of C# online submissions for Encode and Decode TinyURL.
        /// </summary>
        Dictionary<int, string> list = new Dictionary<int, string>();
        int id = 0;
        public string encode(string longUrl)
        {
            list.Add(id, longUrl);
            return "https://leetcode.com/" + id++;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            var number = shortUrl.Replace("https://leetcode.com/", "");
            var id = int.Parse(number);
            return list[id];
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.decode(codec.encode(url));
}
