using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class H2O
    {
        AutoResetEvent hydrogen1ResetEvent = new AutoResetEvent(true);
        AutoResetEvent oxygenResetEvent = new AutoResetEvent(false);
        public int hydrogenCount;
        public H2O()
        {
            hydrogen1ResetEvent = new AutoResetEvent(true);
            hydrogenCount = 0;
            oxygenResetEvent = new AutoResetEvent(false);
        }

        public void Hydrogen(Action releaseHydrogen)
        {
            hydrogen1ResetEvent.WaitOne();
            // releaseHydrogen() outputs "H". Do not change or remove this line.
            releaseHydrogen();

            hydrogenCount++;
            if (hydrogenCount == 1)
                hydrogen1ResetEvent.Set();
            else
                oxygenResetEvent.Set();
        }

        public void Oxygen(Action releaseOxygen)
        {
            oxygenResetEvent.WaitOne();
            // releaseOxygen() outputs "O". Do not change or remove this line.
            releaseOxygen();

            hydrogenCount = 0;
            hydrogen1ResetEvent.Set();

        }
    }

    #region some times working, some time not working
    public class H2O_N
    {

        public int hydrogenCount;
        public H2O_N()
        {
            hydrogenCount = 0;
        }

        public void Hydrogen(Action releaseHydrogen)
        {
            while (hydrogenCount > 1)
                System.Threading.Thread.Sleep(1);
            // releaseHydrogen() outputs "H". Do not change or remove this line.
            releaseHydrogen();
            hydrogenCount++;
        }

        public void Oxygen(Action releaseOxygen)
        {

            while (hydrogenCount <= 1)
                System.Threading.Thread.Sleep(1);

            // releaseOxygen() outputs "O". Do not change or remove this line.
            releaseOxygen();
            hydrogenCount = 0;
        }
    }
    #endregion


}
