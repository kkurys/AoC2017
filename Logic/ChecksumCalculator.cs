using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class ChecksumCalculator
    {
        public int[][] LoadMatrixFromFile(string fileName)
        {
            string[] rows = System.IO.File.ReadAllText(fileName).Split('\n');
            int[][] matrix = new int[rows.Length][];
            for (int i = 0; i < rows.Length; i++)
            {
                var row = rows[i].Split('\t');
                matrix[i] = new int[row.Length];
                for (int j = 0; j < row.Length; j++)
                {
                    matrix[i][j] = int.Parse(row[j].Trim());
                }
            }
            return matrix;
        }
        public int CalculateChecksum(int [][] matrix)
        {
            int checksum = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                checksum += CalculateRowDiff(matrix[i]);
            }
            return checksum;
        }
        private int CalculateRowDiff(int[] row)
        {
            return row.Max() - row.Min();
        }
    }
}
