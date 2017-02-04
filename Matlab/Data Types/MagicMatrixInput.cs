using MathWorks.MATLAB.NET.Arrays;

namespace Matlab
{
    /// <summary>
    /// This class is used for marshalling MATLAB struct to the following functions
    /// Matlab.Functions.MakeSquare_structInputOutput
    /// </summary>
    public class MagicMatrixInput
    {
        public double Dimension { get; set; }
        public double Multiplier { get; set; }

        public MagicMatrixInput(double dim, double multiplier)
        {
            this.Dimension = dim;
            this.Multiplier = multiplier;
        }

        public MagicMatrixInput(MWArray[] input)
        {
            this.Dimension = Utility.MWArrayToDouble(input[0]);
            this.Multiplier = Utility.MWArrayToDouble(input[1]);
        }
    }
}
