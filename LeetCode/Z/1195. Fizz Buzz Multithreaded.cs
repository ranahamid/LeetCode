using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class FizzBuzz
    {
        private int n;
        int i = 1;
        public FizzBuzz(int n)
        {
            this.n = n;
            i = 1;
        }

        // printFizz() outputs "fizz".
        public void Fizz(Action printFizz)
        {
            while (i <= n)
            {
                while (!(i % 3 == 0 && i % 5 != 0) && i <= n)
                    Thread.Sleep(1);
                if (i <= n)
                {
                    printFizz();
                    i++;
                }
            }

        }

        // printBuzzz() outputs "buzz".
        public void Buzz(Action printBuzz)
        {
            while (i <= n)
            {
                while (!(i % 5 == 0 && i % 3 != 0) && i <= n)
                    Thread.Sleep(1);
                if (i <= n)
                {
                    printBuzz();
                    i++;
                }
            }

        }

        // printFizzBuzz() outputs "fizzbuzz".
        public void Fizzbuzz(Action printFizzBuzz)
        {
            while (i <= n)
            {
                while (!(i % 3 == 0 && i % 5 == 0) && i <= n)
                    Thread.Sleep(1);
                if (i <= n)
                {
                    printFizzBuzz();
                    i++;
                }
            }

        }

        // printNumber(x) outputs "x", where x is an integer.
        public void Number(Action<int> printNumber)
        {
            while (i <= n)
            {
                while (!(i % 3 != 0 && i % 5 != 0) && i <= n)
                    Thread.Sleep(1);
                if (i <= n)
                {
                    printNumber(i);
                    i++;
                }
            }

        }
    }
}
