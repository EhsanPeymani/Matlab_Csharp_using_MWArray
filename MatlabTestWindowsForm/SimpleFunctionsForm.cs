using System;
using System.Windows.Forms;
using Matlab;

namespace MatlabTestWindowsForm
{
    public partial class SimpleFunctionsForm : Form
    {
        readonly SimpleFunctions _simpleMatlab = new SimpleFunctions();
        readonly Plots _plots = new Plots();
        readonly Functions _matlab = new Functions();

        public SimpleFunctionsForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double num1, num2;
            
            if (Double.TryParse(num1TextBox.Text.Trim(), out num1) && Double.TryParse(num2TextBox.Text.Trim(), out num2))
            {
                descriptionLabel.Text = string.Format("This function adds up {0} and {1}.", num1, num2);
                resultTextBox1.Text = string.Empty;
                resultTextBox2.Text = string.Empty;
                resultTextBox3.Text = string.Empty;

                var result = _simpleMatlab.AddScalars(num1, num2);
                resultTextBox1.Text = string.Format("The sum of {0} and {1} is {2}", num1, num2, result);

                return;
            }
            
            resultTextBox1.Text = @"Wrong input";
            resultTextBox2.Text = string.Empty;
            resultTextBox3.Text = string.Empty;
        }

        private void addVectorButton_Click(object sender, EventArgs e)
        {
            descriptionLabel.Text = string.Format("Based on the selected dimension, 2 one-dimensional arrays are created, then summed.");
            resultTextBox1.Text = string.Empty;
            resultTextBox2.Text = string.Empty;
            resultTextBox3.Text = string.Empty;

            var formHelper = new FormHelper();
            int dim;

            if (!int.TryParse(dimTextBox.Text.Trim(), out dim))
                return;

            var num1 = formHelper.GeneratedRandomVector(dim);
            var num2 = formHelper.GeneratedRandomVector(dim);

            resultTextBox1.Text = string.Format("Vector 1:\n{0}", formHelper.FormatVector(num1, 10));
            resultTextBox2.Text = string.Format("Vector 2:\n{0}", formHelper.FormatVector(num2, 10));

            var result = _simpleMatlab.AddVectors(num1, num2);

            resultTextBox3.Text = string.Format("Result Vector:\n {0}", formHelper.FormatVector(result, 10));
        }

        private void addMatricesButton_Click(object sender, EventArgs e)
        {
            descriptionLabel.Text = string.Format("Based on the selected dimension, 2 two-dimensional arrays are created, then summed.");
            resultTextBox1.Text = string.Empty;
            resultTextBox2.Text = string.Empty;
            resultTextBox3.Text = string.Empty;

            var formHelper = new FormHelper();

            int rows, cols;

            if(!int.TryParse(rowTextBox.Text.Trim(), out rows) || !int.TryParse(colTextBox.Text.Trim(), out cols))
                return;

            var num1 = formHelper.GeneratedRandomMatrix(rows, cols);
            var num2 = formHelper.GeneratedRandomMatrix(rows, cols);

            resultTextBox1.Text = string.Format("Matrix 1:\n{0}", formHelper.FormatMatrix(num1, 10));
            resultTextBox2.Text = string.Format("Matrix 2:\n{0}", formHelper.FormatMatrix(num2, 10));

            var result = _simpleMatlab.AddMatrices(num1, num2);

            resultTextBox3.Text = string.Format("Result Matrix:\n{0}", formHelper.FormatMatrix(result, 15));
        }

        private void PlotMeshbutton_Click(object sender, EventArgs e)
        {
            descriptionLabel.Text =
                string.Format("This functions opens a MATLAB plot, generate data in the MATLAB runtime, and plots it in 3D.");

            resultTextBox1.Text = string.Empty;
            resultTextBox2.Text = string.Empty;
            resultTextBox3.Text = string.Empty;

            _plots.DisplayPlotMesh("MATLAB Logo - 3D Plot", "MATLAB 3D Plot");
        }

        private void plot2DBbutton_Click(object sender, EventArgs e)
        {
            descriptionLabel.Text =
                string.Format("This functions opens a MATLAB plot, generates 2 one-dimensional arrays and passes them for plotting.");

            resultTextBox1.Text = string.Empty;
            resultTextBox2.Text = string.Empty;
            resultTextBox3.Text = string.Empty;

            var formHelper = new FormHelper();

            int dim = 25;
            var num1 = formHelper.GenerateOrderedVector(dim);
            var num2 = formHelper.GeneratedRandomVector(dim);

            string figureTitle = "2D MATLAB Plot - MATLAB Compuiler SDK";
            string xLabel = "Sample";
            string yLabel = "Values [m]";
            string title = "Experiment Results";

            _plots.DisplayPlot(num1, num2, title, xLabel, yLabel, figureTitle);
        }

        private void makeMagicSquareButton_Click(object sender, EventArgs e)
        {
            descriptionLabel.Text =
                string.Format("This function receives the dimension (hardcoded as 4), and generates a magic matrix of the same order.\n" +
                                "The MATLAB function output is a ''matrix''");

            resultTextBox1.Text = string.Empty;
            resultTextBox2.Text = string.Empty;
            resultTextBox3.Text = string.Empty;

            var dim = 4;
            var magicMatrix = _matlab.MakeSquare_basic(dim);

            var formHelper = new FormHelper();

            resultTextBox1.Text = string.Format("The generated matrix:\n{0}",
                formHelper.FormatMatrix(magicMatrix, 10));

        }

        private void makeMagicSquareFullButton_Click(object sender, EventArgs e)
        {
            descriptionLabel.Text =
                string.Format("This function receives the dimension (hardcoded as 4), and generates a magic matrix of the same order.\n" +
                                "This also generates its determinant and its eigenvalues.\n" +
                                "The MATLAB function outputs are 3 elements: a matrix, a double scalar, and a vector.");

            resultTextBox1.Text = string.Empty;
            resultTextBox2.Text = string.Empty;
            resultTextBox3.Text = string.Empty;

            var dim = 4;
            double determinant;
            double[] eigenvalues;

            var magicMatrix = _matlab.MakeSquare_complexOutput(dim, out determinant, out eigenvalues);

            var formHelper = new FormHelper();

            resultTextBox1.Text = string.Format("The generated matrix:\n{0}", formHelper.FormatMatrix(magicMatrix, 10));

            resultTextBox2.Text = string.Format("The matrix determinant: {0}\n\n\n", determinant);

            resultTextBox2.Text += string.Format("The matrix eigenvalues: \n{0}", formHelper.FormatVector(eigenvalues, 10));
        }

        private void makeMagicSquareVectorInputButton_Click(object sender, EventArgs e)
        {
            descriptionLabel.Text =
                string.Format("This function receives the vector (hardcoded as [1,2,3]), and uses the sum of elements\n" + 
                                "as the dimension for the magic matrix.\n" +
                                "The MATLAB function output is a ''matrix''");

            resultTextBox1.Text = string.Empty;
            resultTextBox2.Text = string.Empty;
            resultTextBox3.Text = string.Empty;

            var dimArray = new double[]{1.0, 2.0, 3,0};
            var magicMatrix = _matlab.MakeSquare_vectorInput(dimArray);

            var formHelper = new FormHelper();

            resultTextBox1.Text = string.Format("The generated matrix:\n{0}", formHelper.FormatMatrix(magicMatrix, 10));
        }

        private void makeMagicSquareStructOutputButton_Click(object sender, EventArgs e)
        {
            descriptionLabel.Text =
                string.Format("This function receives the dimension (hardcoded as 4), and generates a magic matrix of the same order.\n" +
                                "It returns the matix as 2D array, its determinant, its 1D array of eigenvalues,\n and its 2D array of eigenvectors.\n" +
                                "The MATLAB function output is ''structrue''");

            resultTextBox1.Text = string.Empty;
            resultTextBox2.Text = string.Empty;
            resultTextBox3.Text = string.Empty;

            var dim = 4;
            var matlabInformation = _matlab.MakeSquare_structOutput(dim);

            var formHelper = new FormHelper();

            resultTextBox1.Text = string.Format("The generated matrix:\n{0}",
                formHelper.FormatMatrix(matlabInformation.Matrix, 10));

            resultTextBox2.Text = string.Format("The matrix determinant: {0}\n\n\n", matlabInformation.Determinant);

            resultTextBox2.Text += string.Format("The matrix eigenvalues: \n{0}",
                formHelper.FormatVector(matlabInformation.Eigenvalues, 10));

            resultTextBox3.Text = string.Format("The eigenvalues of the matrix:\n{0}",
                formHelper.FormatMatrix(matlabInformation.Eigenvectors, 10));
        }

        private void makeMagicSquareStructInOutButton_Click(object sender, EventArgs e)
        {
            descriptionLabel.Text =
                string.Format("This function receives a MATLAB structure (hardcoded as Dimension:5, and Multipiler:10).\n" +
                                "Then it generates the magic matrix, its determinant, and its eigenvalues and eigenvectors.\n" +
                                "The MATLAB function output is a ''structure''.");

            resultTextBox1.Text = string.Empty;
            resultTextBox2.Text = string.Empty;
            resultTextBox3.Text = string.Empty;

            var dim = 5.0;
            var multiplier = 10.0;

            MagicMatrixInput input = new MagicMatrixInput(dim, multiplier);

            var matlabInformation = _matlab.MakeSquare_structInputOutput(input);

            var formHelper = new FormHelper();

            resultTextBox1.Text = string.Format("The generated matrix:\n{0}",
                formHelper.FormatMatrix(matlabInformation.Matrix, 10));

            resultTextBox2.Text = string.Format("The matrix determinant: {0}\n\n\n", matlabInformation.Determinant);

            resultTextBox2.Text += string.Format("The matrix eigenvalues: \n{0}",
                formHelper.FormatVector(matlabInformation.Eigenvalues, 10));

            resultTextBox3.Text = string.Format("The eigenvalues of the matrix:\n{0}\n\n",
                formHelper.FormatMatrix(matlabInformation.Eigenvectors, 10));

            resultTextBox3.Text += string.Format("The MATLAB function has passed {0} and {1} as the used dimension and multuplier.", 
                                    matlabInformation.InputDetails.Dimension, matlabInformation.InputDetails.Multiplier);
        }
    }
}
