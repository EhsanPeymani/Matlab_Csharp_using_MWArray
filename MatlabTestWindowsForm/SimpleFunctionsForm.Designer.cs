namespace MatlabTestWindowsForm
{
    partial class SimpleFunctionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleFunctionsForm));
            this.num2TextBox = new System.Windows.Forms.TextBox();
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.num2Llabel = new System.Windows.Forms.Label();
            this.num1Llabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addVectorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dimTextBox = new System.Windows.Forms.TextBox();
            this.colTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rowTextBox = new System.Windows.Forms.TextBox();
            this.rowDimLabel = new System.Windows.Forms.Label();
            this.PlotMeshbutton = new System.Windows.Forms.Button();
            this.plot2DBbutton = new System.Windows.Forms.Button();
            this.MWStructToNETbutton = new System.Windows.Forms.Button();
            this.addMatricesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.resultTextBox3 = new System.Windows.Forms.RichTextBox();
            this.resultTextBox2 = new System.Windows.Forms.RichTextBox();
            this.resultTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.makeMagicSquareFullButton = new System.Windows.Forms.Button();
            this.makeMagicSquareButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // num2TextBox
            // 
            this.num2TextBox.Location = new System.Drawing.Point(120, 49);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(50, 20);
            this.num2TextBox.TabIndex = 3;
            this.num2TextBox.Text = "4,6";
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(120, 23);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(50, 20);
            this.num1TextBox.TabIndex = 3;
            this.num1TextBox.Text = "3";
            // 
            // num2Llabel
            // 
            this.num2Llabel.AutoSize = true;
            this.num2Llabel.Location = new System.Drawing.Point(15, 47);
            this.num2Llabel.Name = "num2Llabel";
            this.num2Llabel.Size = new System.Drawing.Size(53, 13);
            this.num2Llabel.TabIndex = 2;
            this.num2Llabel.Text = "Number 2";
            // 
            // num1Llabel
            // 
            this.num1Llabel.AutoSize = true;
            this.num1Llabel.Location = new System.Drawing.Point(15, 23);
            this.num1Llabel.Name = "num1Llabel";
            this.num1Llabel.Size = new System.Drawing.Size(53, 13);
            this.num1Llabel.TabIndex = 2;
            this.num1Llabel.Text = "Number 1";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 66);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Scalars";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addVectorButton
            // 
            this.addVectorButton.Location = new System.Drawing.Point(13, 44);
            this.addVectorButton.Name = "addVectorButton";
            this.addVectorButton.Size = new System.Drawing.Size(75, 23);
            this.addVectorButton.TabIndex = 2;
            this.addVectorButton.Text = "Add Vectors";
            this.addVectorButton.UseVisualStyleBackColor = true;
            this.addVectorButton.Click += new System.EventHandler(this.addVectorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dimension";
            // 
            // dimTextBox
            // 
            this.dimTextBox.Location = new System.Drawing.Point(120, 22);
            this.dimTextBox.Name = "dimTextBox";
            this.dimTextBox.Size = new System.Drawing.Size(50, 20);
            this.dimTextBox.TabIndex = 0;
            this.dimTextBox.Text = "4";
            // 
            // colTextBox
            // 
            this.colTextBox.Location = new System.Drawing.Point(120, 45);
            this.colTextBox.Name = "colTextBox";
            this.colTextBox.Size = new System.Drawing.Size(50, 20);
            this.colTextBox.TabIndex = 3;
            this.colTextBox.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Column Dimension";
            // 
            // rowTextBox
            // 
            this.rowTextBox.Location = new System.Drawing.Point(120, 23);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(50, 20);
            this.rowTextBox.TabIndex = 3;
            this.rowTextBox.Text = "3";
            // 
            // rowDimLabel
            // 
            this.rowDimLabel.AutoSize = true;
            this.rowDimLabel.Location = new System.Drawing.Point(15, 26);
            this.rowDimLabel.Name = "rowDimLabel";
            this.rowDimLabel.Size = new System.Drawing.Size(81, 13);
            this.rowDimLabel.TabIndex = 2;
            this.rowDimLabel.Text = "Row Dimension";
            // 
            // PlotMeshbutton
            // 
            this.PlotMeshbutton.Location = new System.Drawing.Point(13, 19);
            this.PlotMeshbutton.Name = "PlotMeshbutton";
            this.PlotMeshbutton.Size = new System.Drawing.Size(75, 23);
            this.PlotMeshbutton.TabIndex = 3;
            this.PlotMeshbutton.Text = "Plot Mesh";
            this.PlotMeshbutton.UseVisualStyleBackColor = true;
            this.PlotMeshbutton.Click += new System.EventHandler(this.PlotMeshbutton_Click);
            // 
            // plot2DBbutton
            // 
            this.plot2DBbutton.Location = new System.Drawing.Point(109, 19);
            this.plot2DBbutton.Name = "plot2DBbutton";
            this.plot2DBbutton.Size = new System.Drawing.Size(75, 23);
            this.plot2DBbutton.TabIndex = 4;
            this.plot2DBbutton.Text = "2D Plot";
            this.plot2DBbutton.UseVisualStyleBackColor = true;
            this.plot2DBbutton.Click += new System.EventHandler(this.plot2DBbutton_Click);
            // 
            // MWStructToNETbutton
            // 
            this.MWStructToNETbutton.Location = new System.Drawing.Point(12, 110);
            this.MWStructToNETbutton.Name = "MWStructToNETbutton";
            this.MWStructToNETbutton.Size = new System.Drawing.Size(175, 23);
            this.MWStructToNETbutton.TabIndex = 5;
            this.MWStructToNETbutton.Text = "MATLAB Structor to .NET";
            this.MWStructToNETbutton.UseVisualStyleBackColor = true;
            this.MWStructToNETbutton.Click += new System.EventHandler(this.makeMagicSquareStructOutputButton_Click);
            // 
            // addMatricesButton
            // 
            this.addMatricesButton.Location = new System.Drawing.Point(19, 67);
            this.addMatricesButton.Name = "addMatricesButton";
            this.addMatricesButton.Size = new System.Drawing.Size(75, 23);
            this.addMatricesButton.TabIndex = 7;
            this.addMatricesButton.Text = "Add Matrices";
            this.addMatricesButton.UseVisualStyleBackColor = true;
            this.addMatricesButton.Click += new System.EventHandler(this.addMatricesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlotMeshbutton);
            this.groupBox1.Controls.Add(this.plot2DBbutton);
            this.groupBox1.Location = new System.Drawing.Point(12, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 55);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MATLAB Plots";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rowDimLabel);
            this.groupBox2.Controls.Add(this.addMatricesButton);
            this.groupBox2.Controls.Add(this.rowTextBox);
            this.groupBox2.Controls.Add(this.colTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adding 2D Arrays";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dimTextBox);
            this.groupBox3.Controls.Add(this.addVectorButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 76);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adding 1D Arrays";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.num2TextBox);
            this.groupBox4.Controls.Add(this.addButton);
            this.groupBox4.Controls.Add(this.num1TextBox);
            this.groupBox4.Controls.Add(this.num1Llabel);
            this.groupBox4.Controls.Add(this.num2Llabel);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adding Scalars";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.descriptionLabel);
            this.groupBox5.Controls.Add(this.resultTextBox3);
            this.groupBox5.Controls.Add(this.resultTextBox2);
            this.groupBox5.Controls.Add(this.resultTextBox1);
            this.groupBox5.Location = new System.Drawing.Point(219, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(524, 527);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Results";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(8, 22);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // resultTextBox3
            // 
            this.resultTextBox3.Location = new System.Drawing.Point(11, 388);
            this.resultTextBox3.Name = "resultTextBox3";
            this.resultTextBox3.Size = new System.Drawing.Size(507, 128);
            this.resultTextBox3.TabIndex = 0;
            this.resultTextBox3.Text = "";
            // 
            // resultTextBox2
            // 
            this.resultTextBox2.Location = new System.Drawing.Point(11, 254);
            this.resultTextBox2.Name = "resultTextBox2";
            this.resultTextBox2.Size = new System.Drawing.Size(507, 128);
            this.resultTextBox2.TabIndex = 0;
            this.resultTextBox2.Text = "";
            // 
            // resultTextBox1
            // 
            this.resultTextBox1.Location = new System.Drawing.Point(11, 120);
            this.resultTextBox1.Name = "resultTextBox1";
            this.resultTextBox1.Size = new System.Drawing.Size(507, 128);
            this.resultTextBox1.TabIndex = 0;
            this.resultTextBox1.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.makeMagicSquareFullButton);
            this.groupBox6.Controls.Add(this.makeMagicSquareButton);
            this.groupBox6.Controls.Add(this.MWStructToNETbutton);
            this.groupBox6.Location = new System.Drawing.Point(13, 367);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 173);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Complex Data Marshalling";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Make Magic Matrix Struct In/Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.makeMagicSquareStructInOutButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Make Magic Matrix - Vector In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.makeMagicSquareVectorInputButton_Click);
            // 
            // makeMagicSquareFullButton
            // 
            this.makeMagicSquareFullButton.Location = new System.Drawing.Point(12, 51);
            this.makeMagicSquareFullButton.Name = "makeMagicSquareFullButton";
            this.makeMagicSquareFullButton.Size = new System.Drawing.Size(175, 23);
            this.makeMagicSquareFullButton.TabIndex = 6;
            this.makeMagicSquareFullButton.Text = "Make Magic Matrix with info";
            this.makeMagicSquareFullButton.UseVisualStyleBackColor = true;
            this.makeMagicSquareFullButton.Click += new System.EventHandler(this.makeMagicSquareFullButton_Click);
            // 
            // makeMagicSquareButton
            // 
            this.makeMagicSquareButton.Location = new System.Drawing.Point(12, 22);
            this.makeMagicSquareButton.Name = "makeMagicSquareButton";
            this.makeMagicSquareButton.Size = new System.Drawing.Size(175, 23);
            this.makeMagicSquareButton.TabIndex = 5;
            this.makeMagicSquareButton.Text = "Make Magic Matrix";
            this.makeMagicSquareButton.UseVisualStyleBackColor = true;
            this.makeMagicSquareButton.Click += new System.EventHandler(this.makeMagicSquareButton_Click);
            // 
            // SimpleFunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 552);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimpleFunctionsForm";
            this.Text = "MATLAB Compiler SDK .NET Assembly - Simple Functions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox num2TextBox;
        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.Label num2Llabel;
        private System.Windows.Forms.Label num1Llabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button addVectorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dimTextBox;
        private System.Windows.Forms.TextBox colTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rowTextBox;
        private System.Windows.Forms.Label rowDimLabel;
        private System.Windows.Forms.Button PlotMeshbutton;
        private System.Windows.Forms.Button plot2DBbutton;
        private System.Windows.Forms.Button MWStructToNETbutton;
        private System.Windows.Forms.Button addMatricesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox resultTextBox3;
        private System.Windows.Forms.RichTextBox resultTextBox2;
        private System.Windows.Forms.RichTextBox resultTextBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button makeMagicSquareButton;
        private System.Windows.Forms.Button makeMagicSquareFullButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

