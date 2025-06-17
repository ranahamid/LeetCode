using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3582
    {
        public string GenerateTag(string caption)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("#");
            var words = caption.Split(' ');
            int i = 0;
            foreach (var word in words)
            {

                if (word.Length > 0)
                {
                    i++;
                    if (i == 1)
                    {
                        sb.Append(word[0].ToString().ToLower() + word.Substring(1).ToLower());
                    }
                    else
                    {
                        sb.Append(word[0].ToString().ToUpper() + word.Substring(1).ToLower());
                    }
                }

                if (sb.Length >= 100)
                {
                    sb = new StringBuilder(sb.ToString().Substring(0, 100));
                    break;
                }


            }

            return sb.ToString();
        }
    }
}
