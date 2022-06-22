using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1678_Goal_Parser_Interpretation
    {

        /// <summary>
        /// Runtime: 156 ms, faster than 5.30% of C# online submissions for Goal Parser Interpretation.
        /// Memory Usage: 35.4 MB, less than 87.12% of C# online submissions for Goal Parser Interpretation.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static string Interpret(string command)
        {
            command = command.Replace("G", "G");
            command = command.Replace("()", "o");
            command = command.Replace("(al)", "al");
            return command;
        }
    }
}
