using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Search
{
    internal class Minimum_Loss
    {
        public static int minimumLoss(List<long> price)
        {

            var minValue = long.MaxValue;
            var newPrice = new List<long>();
            foreach (var item in price)
            {
                newPrice.Add(item);
            }
            newPrice.Sort();

            for (int i = 0; i < newPrice.Count - 1; i++)
            {
                if (newPrice[i + 1] - newPrice[i] < minValue && price.IndexOf(newPrice[i + 1]) < price.IndexOf(newPrice[i]))
                {
                    minValue = newPrice[i + 1] - newPrice[i];
                }
            }
            return (int)minValue;
        }
    }
}
