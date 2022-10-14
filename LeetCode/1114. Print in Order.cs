using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Foo
    {
        int counter = 0;
        public Foo()
        {
            counter = 0;
        }

        public void First(Action printFirst)
        {
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            counter++;
        }

        public void Second(Action printSecond)
        {
            while (counter < 1)
                continue;
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            counter++;
        }

        public void Third(Action printThird)
        {
            while (counter < 2)
                continue;
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}
