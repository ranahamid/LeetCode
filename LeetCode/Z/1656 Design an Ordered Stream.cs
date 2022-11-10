using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1656_Design_an_Ordered_Stream
    {
        /// <summary>
        /// Runtime: 471 ms, faster than 60.00% of C# online submissions for Design an Ordered Stream.
        /// Memory Usage: 50.8 MB, less than 21.05% of C# online submissions for Design an Ordered Stream.
        /// </summary>
        public class OrderedStream
        {
            private int pointer;
            private string[] array;
            public OrderedStream(int n)
            {
                array = new string[n];
            }

            public IList<string> Insert(int idKey, string value)
            {
                array[idKey - 1] = value;
                var result = new List<string>();
                while (pointer < array.Length && array[pointer] != null)
                {
                    result.Add(array[pointer]);
                    pointer++;
                }
                return result;
            }
        }

    }
}
