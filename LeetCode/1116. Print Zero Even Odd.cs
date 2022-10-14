using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    public class ZeroEvenOdd
    {
        private int n;
        public bool printOdd = false;
        public bool printEven = true;
        public bool printZero = true;
        public int counter = 1;

        public ZeroEvenOdd(int n)
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
                    System.Threading.Thread.Sleep(1);

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
                    System.Threading.Thread.Sleep(1);
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
                    System.Threading.Thread.Sleep(1);
                if (counter > n)
                    break;

                printNumber(counter);
                counter++;

                printZero = !printZero;
                printEven = !printEven;
            }
        }
    }
}
