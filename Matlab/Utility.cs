using MathWorks.MATLAB.NET.Arrays;

namespace Matlab
{
    public class Utility
    {
        /// <summary>
        /// Converts MATLAB numeric type to one-dimensional array (vector)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double MWArrayToDouble(MWArray input)
        {
            return (double)((MWNumericArray)input);
        }
        
        /// <summary>
        /// Converts MWArray to one-dimensional array (vector)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double[] MWArrayToVector(MWArray input)
        {
            return (double[]) ((MWNumericArray) input).ToVector(MWArrayComponent.Real);
        }

        /// <summary>
        /// Converts MWArray to two-dimensional array (Matrix)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double[,] MWArrayToMatrix(MWArray input)
        {
            return (double[,])((MWNumericArray) input).ToArray(MWArrayComponent.Real);
        }
        
        /// <summary>
        /// Converts MWArray input, which is a MATLAB structure, to an array of MWArray
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static MWArray[] GetMWStructureFields(MWArray input)
        {
            var castInput = (MWStructArray) input;
            
            var fields = castInput.FieldNames;
            MWArray[] result = new MWArray[fields.Length];

            for (int i = 0; i < fields.Length; i++)
            {
                result[i] = castInput.GetField(fields[i]);
            }

            return result;
        }

        public static T ConvertMWObjectToClass<T>(MWArray input)
        {
            var castInput = (MWObjectArray)input;

            return (T) castInput.Object;
        }
         
    }
}
