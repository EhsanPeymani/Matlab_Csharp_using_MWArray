using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using MatlabExportedFunctions;

namespace Matlab
{
    public class Plots
    {
        public MatlabPlottingFunctions MatlabPlot { get; set; }

        public Plots()
        {
            this.MatlabPlot = new MatlabPlottingFunctions();
        }

        public void DisplayPlotMesh(string plotTitle, string figureTitle)
        {
            var pTitle = (MWCharArray)plotTitle;
            var pFigureTitle = (MWCharArray)figureTitle;

            this.MatlabPlot.PlotMesh(pTitle, pFigureTitle);
        }

        public void DisplayPlot(double[] x, double[] y, string plotTitle, string xLabel, string yLabel, string figureTitle)
        {
            var x1 = (MWNumericArray) x;
            var y1 = (MWNumericArray) y;

            var pTitle = (MWCharArray) plotTitle;
            var pXTitle = (MWCharArray) xLabel;
            var pYTitle = (MWCharArray) yLabel;
            var pFigureTitle = (MWCharArray) figureTitle;

            this.MatlabPlot.DisplayPlot(x1, y1, pTitle, pXTitle, pYTitle, pFigureTitle);
        }
    }
}
