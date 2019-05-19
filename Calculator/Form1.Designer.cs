namespace Calculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnBackspace = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.Btn1byX = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnX2 = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.TextBox_Result = new System.Windows.Forms.TextBox();
            this.plusminus_operator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOne
            // 
            this.BtnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOne.Location = new System.Drawing.Point(16, 87);
            this.BtnOne.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(68, 41);
            this.BtnOne.TabIndex = 0;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = true;
            this.BtnOne.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThree.Location = new System.Drawing.Point(189, 87);
            this.BtnThree.Margin = new System.Windows.Forms.Padding(4);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(68, 41);
            this.BtnThree.TabIndex = 1;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = true;
            this.BtnThree.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTwo.Location = new System.Drawing.Point(105, 87);
            this.BtnTwo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(68, 41);
            this.BtnTwo.TabIndex = 2;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(357, 87);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(68, 41);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.operator_click);
            // 
            // BtnBackspace
            // 
            this.BtnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackspace.Location = new System.Drawing.Point(272, 87);
            this.BtnBackspace.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBackspace.Name = "BtnBackspace";
            this.BtnBackspace.Size = new System.Drawing.Size(68, 41);
            this.BtnBackspace.TabIndex = 5;
            this.BtnBackspace.Text = "←";
            this.BtnBackspace.UseVisualStyleBackColor = true;
            this.BtnBackspace.Click += new System.EventHandler(this.button_Backspace);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(272, 158);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(68, 41);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.Button_clear);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtract.Location = new System.Drawing.Point(357, 158);
            this.BtnSubtract.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(68, 41);
            this.BtnSubtract.TabIndex = 9;
            this.BtnSubtract.Text = "-";
            this.BtnSubtract.UseVisualStyleBackColor = true;
            this.BtnSubtract.Click += new System.EventHandler(this.operator_click);
            // 
            // BtnFive
            // 
            this.BtnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFive.Location = new System.Drawing.Point(105, 158);
            this.BtnFive.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(68, 41);
            this.BtnFive.TabIndex = 8;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = true;
            this.BtnFive.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSix
            // 
            this.BtnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSix.Location = new System.Drawing.Point(189, 158);
            this.BtnSix.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(68, 41);
            this.BtnSix.TabIndex = 7;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = true;
            this.BtnSix.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnFour
            // 
            this.BtnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFour.Location = new System.Drawing.Point(16, 158);
            this.BtnFour.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(68, 41);
            this.BtnFour.TabIndex = 6;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = true;
            this.BtnFour.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn1byX
            // 
            this.Btn1byX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1byX.Location = new System.Drawing.Point(272, 228);
            this.Btn1byX.Margin = new System.Windows.Forms.Padding(4);
            this.Btn1byX.Name = "Btn1byX";
            this.Btn1byX.Size = new System.Drawing.Size(68, 41);
            this.Btn1byX.TabIndex = 15;
            this.Btn1byX.Text = "1/x";
            this.Btn1byX.UseVisualStyleBackColor = true;
            this.Btn1byX.Click += new System.EventHandler(this.operator_click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiply.Location = new System.Drawing.Point(357, 228);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(68, 41);
            this.BtnMultiply.TabIndex = 14;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.operator_click);
            // 
            // BtnEight
            // 
            this.BtnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEight.Location = new System.Drawing.Point(105, 228);
            this.BtnEight.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(68, 41);
            this.BtnEight.TabIndex = 13;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = true;
            this.BtnEight.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnNine
            // 
            this.BtnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNine.Location = new System.Drawing.Point(189, 228);
            this.BtnNine.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(68, 41);
            this.BtnNine.TabIndex = 12;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = true;
            this.BtnNine.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeven.Location = new System.Drawing.Point(16, 228);
            this.BtnSeven.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(68, 41);
            this.BtnSeven.TabIndex = 11;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = true;
            this.BtnSeven.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnX2
            // 
            this.BtnX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnX2.Location = new System.Drawing.Point(272, 298);
            this.BtnX2.Margin = new System.Windows.Forms.Padding(4);
            this.BtnX2.Name = "BtnX2";
            this.BtnX2.Size = new System.Drawing.Size(68, 41);
            this.BtnX2.TabIndex = 20;
            this.BtnX2.Text = "x²";
            this.BtnX2.UseVisualStyleBackColor = true;
            this.BtnX2.Click += new System.EventHandler(this.operator_click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivide.Location = new System.Drawing.Point(357, 298);
            this.BtnDivide.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(68, 41);
            this.BtnDivide.TabIndex = 19;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.operator_click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPoint.Location = new System.Drawing.Point(105, 298);
            this.BtnPoint.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(68, 41);
            this.BtnPoint.TabIndex = 18;
            this.BtnPoint.Text = ".";
            this.BtnPoint.UseVisualStyleBackColor = true;
            this.BtnPoint.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquals.Location = new System.Drawing.Point(189, 298);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(68, 41);
            this.BtnEquals.TabIndex = 17;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = true;
            this.BtnEquals.Click += new System.EventHandler(this.operator_click);
            // 
            // BtnZero
            // 
            this.BtnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZero.Location = new System.Drawing.Point(16, 298);
            this.BtnZero.Margin = new System.Windows.Forms.Padding(4);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(68, 41);
            this.BtnZero.TabIndex = 16;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = true;
            this.BtnZero.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox_Result
            // 
            this.TextBox_Result.Location = new System.Drawing.Point(16, 39);
            this.TextBox_Result.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Result.Multiline = true;
            this.TextBox_Result.Name = "TextBox_Result";
            this.TextBox_Result.Size = new System.Drawing.Size(408, 29);
            this.TextBox_Result.TabIndex = 21;
            this.TextBox_Result.Text = "0";
            this.TextBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox_Result.TextChanged += new System.EventHandler(this.TextBox_Result_TextChanged);
            // 
            // plusminus_operator
            // 
            this.plusminus_operator.Location = new System.Drawing.Point(16, 346);
            this.plusminus_operator.Name = "plusminus_operator";
            this.plusminus_operator.Size = new System.Drawing.Size(409, 30);
            this.plusminus_operator.TabIndex = 22;
            this.plusminus_operator.Text = "+/-";
            this.plusminus_operator.UseVisualStyleBackColor = true;
            this.plusminus_operator.Click += new System.EventHandler(this.plusminus_click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(447, 388);
            this.Controls.Add(this.plusminus_operator);
            this.Controls.Add(this.TextBox_Result);
            this.Controls.Add(this.BtnX2);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnPoint);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnZero);
            this.Controls.Add(this.Btn1byX);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnEight);
            this.Controls.Add(this.BtnNine);
            this.Controls.Add(this.BtnSeven);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSubtract);
            this.Controls.Add(this.BtnFive);
            this.Controls.Add(this.BtnSix);
            this.Controls.Add(this.BtnFour);
            this.Controls.Add(this.BtnBackspace);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnThree);
            this.Controls.Add(this.BtnOne);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnBackspace;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSubtract;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button Btn1byX;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.Button BtnX2;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnPoint;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.TextBox TextBox_Result;
        private System.Windows.Forms.Button plusminus_operator;
    }
}

