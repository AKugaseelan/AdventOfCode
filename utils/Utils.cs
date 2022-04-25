using System;

namespace AdventOfCode.Utils
{
    public class Utils
    {
        //function to read file and return string array
        public string[] ReadInputFile(string filePath)
        {
            string[] lines;
            try
            {
                lines = System.IO.File.ReadAllLines(filePath);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File could not be found!");
                lines = new string[0];
                Environment.Exit(9990);
            }

            return lines;
        }
    }
}