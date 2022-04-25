using System;
using AdventOfCode._21_01;
using AdventOfCode._21_02;

namespace AdventOfCode
{
    internal class Program
    {

        private static void Main()
        {
            _21_01.DepthAnalysis DepthAnalysis = new DepthAnalysis();
            Console.WriteLine("Number of times depth increased: " + DepthAnalysis.depthComparison());
            Console.WriteLine("Number of times depth increased after grouping: " + DepthAnalysis.DepthGroupedComparison());

            _21_02.PositionFinding PositionFinding = new PositionFinding();
            Console.WriteLine("Position multiplication is: " + PositionFinding.CalculatePosition());
            Console.WriteLine("Position multiplication with aim is: " + PositionFinding.CalculateAim());
        }
    }
}