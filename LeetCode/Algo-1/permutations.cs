using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Permutations
    {
        /* Permutation function @param 
       str string to calculate permutation 
       for @param l starting index @param 
       r end index */
        public static  void permute(String str,
                                    int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                   // str = swap(str, l, i);
                }
            }
        }

        /* Swap Characters at position 
           @param a string value @param 
           i position 1 @param j position 2 
           @return swapped string */
        public  static String swap(String a,
                                int i, int j)
        {
            
            char[] charArray = a.ToCharArray();

            (charArray[i], charArray[j]) = (charArray[j], charArray[i]);
            //char temp;
            //temp = charArray[i];
            //charArray[i] = charArray[j];
            //charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
