using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    /// <summary>
    /// Runtime: 842 ms, faster than 100.00% of C# online submissions for Design SQL.
    /// Memory Usage: 64.8 MB, less than 100.00% of C# online submissions for Design SQL.
    /// </summary>
    public class SQL
    {
        Dictionary<string, List<IList<string>>> dic;
        public SQL(IList<string> names, IList<int> columns)
        {
            dic = new Dictionary<string, List<IList<string>>>();
        }

        public void InsertRow(string name, IList<string> row)
        {
            dic.TryAdd(name, new List<IList<string>>());
            dic[name].Add(row);
        }

        public void DeleteRow(string name, int rowId)
        {

        }

        public string SelectCell(string name, int rowId, int columnId)
        {
            return dic[name][rowId - 1][columnId - 1];
        }
    }
}
