using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    #region AutoResetEvent
    public class ZeroEvenOdd
    {
        private int n;
        AutoResetEvent zeroResetEvent = new AutoResetEvent(true);
        AutoResetEvent oddResetEvent = new AutoResetEvent(false);
        AutoResetEvent evenResetEvent = new AutoResetEvent(false);
        public ZeroEvenOdd(int n)
        {
            this.n = n;
        }

        // printNumber(x) outputs "x", where x is an integer.
        public void Zero(Action<int> printNumber)
        {
            for (int i = 1; i <= n; i++)
            {
                zeroResetEvent.WaitOne();
                printNumber(0);
                if (i % 2 == 0)
                    evenResetEvent.Set();
                else
                    oddResetEvent.Set();
            }
        }

        public void Even(Action<int> printNumber)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenResetEvent.WaitOne();
                    printNumber(i);
                    zeroResetEvent.Set();
                }

            }
        }

        public void Odd(Action<int> printNumber)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    oddResetEvent.WaitOne();
                    printNumber(i);
                    zeroResetEvent.Set();
                }

            }
        }
    }
    #endregion
    #region Thread
    /// <summary>
    /// Runtime 151 ms Beats 68.6% Memory 38.1 MB Beats 70.83%
    /// </summary>
    public class ZeroEvenOdd_Thread
    {
        private int n;
        public bool printOdd = false;
        public bool printEven = true;
        public bool printZero = true;
        public int counter = 1;

        public ZeroEvenOdd_Thread(int n)
        {
            this.n = n;
            counter = 1;
            printZero = false;
            printEven = true;
            printOdd = true;
        }

        // printNumber(x) outputs "x", where x is an integer.
        public void Zero(Action<int> printNumber)
        {
            while (counter <= n)
            {
                while (printZero && counter <= n) //true
                    Thread.Sleep(1);

                if (counter > n)
                    break;

                printNumber(0);
                printZero = !printZero;//true


                if (counter % 2 == 0)
                    printEven = false;
                else
                    printOdd = false;
            }
        }
        public void Odd(Action<int> printNumber)
        {
            while (counter <= n)
            {

                while (printOdd && counter <= n)
                    Thread.Sleep(1);
                if (counter > n)
                    break;

                printNumber(counter);
                counter++;

                printZero = !printZero;
                printOdd = !printOdd;//false 
            }

        }
        public void Even(Action<int> printNumber)
        {
            while (counter <= n)
            {

                while (printEven && counter <= n)
                    Thread.Sleep(1);
                if (counter > n)
                    break;

                printNumber(counter);
                counter++;

                printZero = !printZero;
                printEven = !printEven;
            }
        }
    }
    #endregion
}
