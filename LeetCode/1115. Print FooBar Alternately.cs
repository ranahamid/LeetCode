using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FooBar
    {
        private int n;
        bool isFooDone = false;
        public FooBar(int n)
        {
            isFooDone = false;
            this.n = n;
        }
        public void Foo(Action printFoo)
        {
            for (int i = 0; i < n; i++)
            {
                while (isFooDone)
                    System.Threading.Thread.Sleep(1);
                // printFoo() outputs "foo". Do not change or remove this line.
                printFoo();
                isFooDone = !isFooDone;
            }
        }
        public void Bar(Action printBar)
        {
            for (int i = 0; i < n; i++)
            {
                while (!isFooDone)
                    System.Threading.Thread.Sleep(1);

                // printBar() outputs "bar". Do not change or remove this line.
                printBar();
                isFooDone = !isFooDone;
            }
        }
    }
}
