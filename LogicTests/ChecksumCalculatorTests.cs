using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace LogicTests
{
    /// <summary>
    /// Summary description for ChecksumCalculatorTests
    /// </summary>
    [TestClass]
    public class ChecksumCalculatorTests
    {
        private ChecksumCalculator _calculator;
        public ChecksumCalculatorTests()
        {
            _calculator = new ChecksumCalculator();
        }



        [TestMethod]
        public void ChecksumCalculator_returns_0_for_equal_numbers()
        {
            var example = new int[3][] {
                new int[]{ 3, 3, 3 },
                new int[]{ 3, 3, 3 },
                new int[]{ 3, 3, 3 }
            };

            var result = _calculator.CalculateChecksum(example);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void ChecksumCalculator_returns_row_diff_between_smallest_and_largest_number()
        {
            var example = new int[1][] {
                new int[]{ 0, 3, 8},
            };

            var result = _calculator.CalculateChecksum(example);

            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void ChecksumCalculator_returns_sum_of_row_diffs_between_smallest_and_largest_number_in_each_row()
        {
            var example = new int[2][] {
                new int[]{ 0, 3, 8},
                new int[]{ 5, 3, 8},
            };

            var result = _calculator.CalculateChecksum(example);

            Assert.AreEqual(13, result);
        }
    }
}
