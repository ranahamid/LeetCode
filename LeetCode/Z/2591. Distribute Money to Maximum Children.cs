using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2591
    {
        public int DistMoney(int money, int children)
        {
            if (money == children * 8)
                return children;
            var counter = 0;
            if (money < children)
                return -1;
            if (money > children * 8)
                return children - 1;

            while (money > 0 && money - 8 >= children - 1)
            {
                counter++;
                money -= 8;
                children--;
            }
            if (money == 4 && children == 1)
                counter--;
            return counter;

        }
    }
}
