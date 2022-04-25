using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode.Utils;

namespace AdventOfCode._21_01
{
    public class DepthAnalysis
    {
        private Utils.Utils _utils = new Utils.Utils();

        private int[] PrepareEntries()
        {
            string[] Entries = _utils.ReadInputFile("C:\\Dev\\AdventOfCode\\21_01\\input.txt");
            int[] DepthEntries = Array.ConvertAll(Entries, s => int.Parse(s));
            return DepthEntries;
        }

        public int depthComparison()
        {
            int[] DepthEntries = PrepareEntries();
            int DepthIncreasedCounter = 0;
            for (int i = 1; i < DepthEntries.Length; i++)
            {
                if (DepthEntries[i] > DepthEntries[i - 1])
                {
                    DepthIncreasedCounter++;
                }
            }
            return DepthIncreasedCounter;
        }

        public int DepthGroupedComparison()
        {
            int[] DepthEntries = PrepareEntries();
            int DepthIncreasedCounter = 0;
            for (int i = 0;i+3 < DepthEntries.Length; i++)
            {
                int FirstGroup = DepthEntries[i] + DepthEntries[i + 1] + DepthEntries[i + 2];
                int SecondGroup = DepthEntries[i + 1] + DepthEntries[i + 2] + DepthEntries[i + 3];
                if (FirstGroup < SecondGroup)
                {

                    DepthIncreasedCounter++;
                }
            }
            return DepthIncreasedCounter;
        }
    }
}
