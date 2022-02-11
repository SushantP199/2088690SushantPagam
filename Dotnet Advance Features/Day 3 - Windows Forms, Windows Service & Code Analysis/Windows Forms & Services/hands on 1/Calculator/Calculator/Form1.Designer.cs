namespace Calculator
{
    partial class Form1
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
            this.input2 = new System.Windows.Forms.TextBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnAddition = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplication = new System.Windows.Forms.RadioButton();
            this.rbtnSubstraction = new System.Windows.Forms.RadioButton();
            this.rbtnDivision = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(241, 61);
            this.input2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(87, 20);
            this.input2.TabIndex = 0;
            this.input2.Text = "\r\n";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(90, 30);
            this.lblNumber1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(91, 13);
            this.lblNumber1.TabIndex = 2;
            this.lblNumber1.Text = "Enter first Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Second Number";
            // 
            // rbtnAddition
            // 
            this.rbtnAddition.AutoSize = true;
            this.rbtnAddition.Location = new System.Drawing.Point(83, 99);
            this.rbtnAddition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnAddition.Name = "rbtnAddition";
            this.rbtnAddition.Size = new System.Drawing.Size(63, 17);
            this.rbtnAddition.TabIndex = 4;
            this.rbtnAddition.TabStop = true;
            this.rbtnAddition.Text = "Addition";
            this.rbtnAddition.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiplication
            // 
            this.rbtnMultiplication.AutoSize = true;
            this.rbtnMultiplication.Location = new System.Drawing.Point(260, 99);
            this.rbtnMultiplication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnMultiplication.Name = "rbtnMultiplication";
            this.rbtnMultiplication.Size = new System.Drawing.Size(86, 17);
            this.rbtnMultiplication.TabIndex = 5;
            this.rbtnMultiplication.TabStop = true;
            this.rbtnMultiplication.Text = "Multiplication";
            this.rbtnMultiplication.UseVisualStyleBackColor = true;
            // 
            // rbtnSubstraction
            // 
            this.rbtnSubstraction.AutoSize = true;
            this.rbtnSubstraction.Location = new System.Drawing.Point(155, 99);
            this.rbtnSubstraction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnSubstraction.Name = "rbtnSubstraction";
            this.rbtnSubstraction.Size = new System.Drawing.Size(82, 17);
            this.rbtnSubstraction.TabIndex = 6;
            this.rbtnSubstraction.TabStop = true;
            this.rbtnSubstraction.Text = "substraction";
            this.rbtnSubstraction.UseVisualStyleBackColor = true;
            // 
            // rbtnDivision
            // 
            this.rbtnDivision.AutoSize = true;
            this.rbtnDivision.Location = new System.Drawing.Point(360, 99);
            this.rbtnDivision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnDivision.Name = "rbtnDivision";
            this.rbtnDivision.Size = new System.Drawing.Size(62, 17);
            this.rbtnDivision.TabIndex = 7;
            this.rbtnDivision.TabStop = true;
            this.rbtnDivision.Text = "Division";
            this.rbtnDivision.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(212, 148);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 27);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Operation";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.Calculate_Result);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(241, 26);
            this.input1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(87, 20);
            this.input1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbtnDivision);
            this.Controls.Add(this.rbtnSubstraction);
            this.Controls.Add(this.rbtnMultiplication);
            this.Controls.Add(this.rbtnAddition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.input2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnAddition;
        private System.Windows.Forms.RadioButton rbtnMultiplication;
        private System.Windows.Forms.RadioButton rbtnSubstraction;
        private System.Windows.Forms.RadioButton rbtnDivision;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox input1;
    }
}

