using MathWorks.MATLAB.NET.Arrays;

namespace Matlab
{
    /// <summary>
    /// This class is used for marshalling MATLAB struct to the following functions
    /// Matlab.Functions.MakeSquare_structInputOutput
    /// </summary>
    public class MagicMatrixOutputInput
    {
        public double[,] Matrix { get; internal set; }
        public double Determinant { get; internal set; }
        public double[] Eigenvalues { get; internal set; }
        public double[,] Eigenvectors { get; internal set; }
        public MagicMatrixInput InputDetails { get; internal set; }

        public MagicMatrixOutputInput(MWArray[] input)
        {
            this.Matrix = Utility.MWArrayToMatrix(input[0]);
            this.Determinant = Utility.MWArrayToDouble(input[1]);
            this.Eigenvalues = Utility.MWArrayToVector(input[2]);
            this.Eigenvectors = Utility.MWArrayToMatrix(input[3]);
            this.InputDetails = Utility.ConvertMWObjectToClass<MagicMatrixInput>(input[4]);
        }
    }
}
