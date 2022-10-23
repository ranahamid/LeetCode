using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest__83
{

    public class NumberContainers
    {
        private SortedList<int, int> sortedList;
        public NumberContainers()
        {
            sortedList = new SortedList<int, int>();
        }
        public void Change(int index, int number)
        {
            if (sortedList.ContainsKey(index))
                sortedList[index] = number;
            else
                sortedList.Add(index, number);

        }

        public int Find(int number)
        {
            if (sortedList.ContainsValue(number))
            {
                return sortedList.Where(x => x.Value == number).FirstOrDefault().Key;
            }
            return -1;
        }
    }

}
