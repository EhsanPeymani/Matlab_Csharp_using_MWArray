using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MathWorks.MATLAB.NET.Arrays;
using MatlabExportedFunctions;

namespace Matlab
{
    public class SimpleFunctions
    {
        public MatlabSimpleFunctions Matlab { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public SimpleFunctions()
        {
            this.Matlab = new MatlabSimpleFunctions();
        }

        /// <summary>
        /// Summing up two double scalars
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double AddScalars(double num1, double num2)
        {
            var result = this.Matlab.add((MWArray) num1, (MWArray) num2);
            return Utility.MWArrayToDouble(result);
        }

        /// <summary>
        /// Sums two vectors (1-dim array)
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double[] AddVectors(double[] num1, double[] num2)
        {
            MWNumericArray number1 = (MWNumericArray) num1;
            MWNumericArray number2 = (MWNumericArray) num2;

            var result = this.Matlab.add(number1, number2);
            return Utility.MWArrayToVector(result);
        }

        /// <summary>
        /// Summing up two matrices (2-dim array)
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double[,] AddMatrices(double[,] num1, double[,] num2)
        {
            MWNumericArray number1 = (MWNumericArray)num1;
            MWNumericArray number2 = (MWNumericArray)num2;

            var result = this.Matlab.add((MWArray)number1, (MWArray)number2);
            return Utility.MWArrayToMatrix(result);
        }
    }
}
