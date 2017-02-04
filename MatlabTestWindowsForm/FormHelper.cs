using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MatlabTestWindowsForm
{
    public class FormHelper
    {
        public Random random { get; set; }

        public FormHelper()
        {
            this.random = new Random();
        }

        /// <summary>
        /// Creates a random vector
        /// </summary>
        /// <param name="dim"></param>
        /// <returns></returns>
        public double[] GeneratedRandomVector(int dim)
        {
            var result = new double[dim];

            for (var i = 0; i < dim; i++)
                result[i] = this.random.NextDouble() * 10;

            return result;
        }

        /// <summary>
        /// Creates a random matrix
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public double[,] GeneratedRandomMatrix(int rows, int cols)
        {
            var result = new double[rows,cols];

            for (var i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i,j] = this.random.NextDouble() * 10;
                }  
            }

            return result;
        }

        /// <summary>
        /// Returns a formatted string for the vector
        /// </summary>
        /// <param name="input"></param>
        /// <param name="paddingSize"></param>
        /// <returns></returns>
        public string FormatVector(double[] input, int paddingSize)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                var temp = input[i].ToString("N2").PadLeft(paddingSize);
                sb.Append(temp);
            }

            return sb.ToString();
        }

        public string FormatMatrix(double[,] input, int paddingSize)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i <= input.GetUpperBound(0); i++)
            {
                var slicedVector = this.SliceRow(input, i);
                sb.Append(this.FormatVector(slicedVector, paddingSize));
                sb.Append("\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Slices a two-dimensional array in row
        /// </summary>
        /// <param name="input"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public double[] SliceRow(double[,] input, int row)
        {
            double[] result = new double[input.GetUpperBound(1)+1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = input[row, i];
            }

            return result;
        }

        /// <summary>
        /// Slices a two-dimensional array in column
        /// </summary>
        /// <param name="input"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public double[] SliceColumn(double[,] input, int col)
        {
            double[] result = new double[input.GetUpperBound(0)+1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = input[i, col];
            }

            return result;
        }

        /// <summary>
        /// Generates a one-dimensional array from 1 to <param name="dim"></param>>
        /// </summary>
        /// <param name="dim"></param>
        /// <returns></returns>
        public double[] GenerateOrderedVector(int dim)
        {
            double[] result = new double[dim];

            for (int i = 0; i < dim; i++)
            {
                result[i] = i;
            }

            return result;
        }
    }
}
