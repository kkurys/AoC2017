using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new ChecksumCalculator();
            var matrix = calculator.LoadMatrixFromFile("day2_in.txt");

            Console.WriteLine(calculator.CalculateChecksum(matrix));

            Console.ReadKey();
        }
    }
}
