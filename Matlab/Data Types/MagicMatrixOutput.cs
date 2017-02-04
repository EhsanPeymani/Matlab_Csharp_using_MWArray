using MathWorks.MATLAB.NET.Arrays;

namespace Matlab
{
    /// <summary>
    /// This class is used as .NET equivalent for the output of the following method
    /// Matlab.Functions.MakeSquare_structOutput
    /// </summary>
    public class MagicMatrixOutput
    {
        public double[,] Matrix { get; internal set; }
        public double Determinant { get; internal set; }
        public double[] Eigenvalues { get; internal set; }
        public double[,] Eigenvectors { get; internal set; }

        public MagicMatrixOutput(MWArray[] input)
        {
            this.Matrix = Utility.MWArrayToMatrix(input[0]);
            this.Determinant = Utility.MWArrayToDouble(input[1]);
            this.Eigenvalues = Utility.MWArrayToVector(input[2]);
            this.Eigenvectors = Utility.MWArrayToMatrix(input[3]);
        }
    }
}
