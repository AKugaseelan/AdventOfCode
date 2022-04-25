using System;
using AdventOfCode.Utils;

namespace AdventOfCode._21_02
{
    public class PositionFinding
    {
        private Utils.Utils _utils = new Utils.Utils();

        public int CalculatePosition()
        {
            int Depth = 0;
            int x = 0;
            string[] PositionData = _utils.ReadInputFile("C:\\Dev\\AdventOfCode\\21_02\\input.txt");
            foreach (var item in PositionData)
            {
                string[] split = item.Split(' ');
                switch (split[0])
                {
                    case "forward":
                        x = x + int.Parse(split[1]);
                        break;
                    case "down":
                        Depth = Depth + int.Parse(split[1]);
                        break;
                    case "up":
                        Depth = Depth - int.Parse(split[1]);
                        break;
                }
            }
            return x * Depth;
        }

        public int CalculateAim()
        {
            int Depth = 0;
            int x = 0;
            int Aim = 0;
            string[] PositionData = _utils.ReadInputFile("C:\\Dev\\AdventOfCode\\21_02\\input.txt");
            foreach (var item in PositionData)
            {
                string[] split = item.Split(' ');
                switch (split[0])
                {
                    case "forward":
                        x = x + int.Parse(split[1]);
                        Depth = Depth + (int.Parse(split[1]) * Aim);
                        break;
                    case "down":
                        Aim = Aim + int.Parse(split[1]);
                        break;
                    case "up":
                        Aim = Aim - int.Parse(split[1]);
                        break;
                }
            }
            return x * Depth;
        }
    }
}