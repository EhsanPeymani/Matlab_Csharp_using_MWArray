using MatlabExportedFunctions;
using MathWorks.MATLAB.NET.Arrays;


namespace Matlab
{
    public class Functions
    {
        public MatlabFunctions Matlab { get; set; }

        public Functions()
        {
            this.Matlab = new MatlabFunctions();
        }

        public double[,] MakeSquare_basic(int dim)
        {
            var result = this.Matlab.makesquare((MWArray) dim);
            return Utility.MWArrayToMatrix(result);
        }

        public double[,] MakeSquare_complexOutput(int dim, out double determinant, out double[] eigenvalues)
        {
            var result = this.Matlab.makesquare_full(3, (MWArray)dim);

            determinant = Utility.MWArrayToDouble(result[1]);
            eigenvalues = Utility.MWArrayToVector(result[2]);

            return Utility.MWArrayToMatrix(result[0]);
        }

        public double[,] MakeSquare_vectorInput(double[] dimArray)
        {
            var input = new MWNumericArray(dimArray);
            var result = this.Matlab.makesquare_in_vector(input);

            return Utility.MWArrayToMatrix(result);
        }

        public MagicMatrixOutput MakeSquare_structOutput(int dim)
        {
            //remember the cast from System.Int to MWArray is necessary 
            //so this overloaded function is not interpreted as funciton(int numberofoutputs)
            var result = this.Matlab.makesquare_structure((MWArray)dim);
            var output = new MagicMatrixOutput(Utility.GetMWStructureFields(result));
            return output;
        }

        public MagicMatrixOutputInput MakeSquare_structInputOutput(MagicMatrixInput input)
        {
            // the MATLAB function requires structure
            // the input is passed into MATLAB as an object with identical properties 
            var inputMatlab = new MWObjectArray(input);
            var result = this.Matlab.makesquare_in_out_structure(inputMatlab);
            var output = new MagicMatrixOutputInput(Utility.GetMWStructureFields(result));
            return output;
        }
    }
}
