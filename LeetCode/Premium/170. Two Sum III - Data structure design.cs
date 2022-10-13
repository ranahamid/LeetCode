using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    //Runtime 282 ms Beats 85.71% Memory 59.5 MB Beats 50%
    public class TwoSum
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        public TwoSum()
        {
        }
        public void Add(int number)
        {
            dic.TryAdd(number, 0);
            dic[number]++;
        }
        public bool Find(int value)
        {
            foreach (var item in dic)
            {
                var comp = value - item.Key;
                if (comp != item.Key)
                {
                    if (dic.ContainsKey(comp))
                        return true;
                }
                else if (item.Value > 1)
                {
                    return true;
                }
            }
            return false;
        }
    }

    /**
     * Your TwoSum object will be instantiated and called as such:
     * TwoSum obj = new TwoSum();
     * obj.Add(number);
     * bool param_2 = obj.Find(value);
     */
 
}
