using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Biweekly_Contest_88
{
    /// <summary>
    /// Runtime 1196 ms Beats 100%
    /// </summary>
    public class LUPrefix
    {
        int currentPosition = 1;
        bool[] answer;
        public LUPrefix(int n)
        {
            answer = new bool[n + 2];
            answer[0] = true;
            currentPosition = 1;
        }
        public void Upload(int video)
        {
            answer[video] = true;
            while (answer[currentPosition])
                currentPosition++;
        }
        public int Longest()
        {
            return currentPosition - 1;
        }
    }


    /**
     * Your LUPrefix object will be instantiated and called as such:
     * LUPrefix obj = new LUPrefix(n);
     * obj.Upload(video);
     * int param_2 = obj.Longest();
     */
}
