namespace lab2;

	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        labelResult = new Label();
        btnCalculateSum = new Button();
        txtArrayInput = new TextBox();
        label1 = new Label();
        lblSumResult = new Label();
        btnCalculateFibonacci = new Button();
        lblFibonacciResult = new Label();
        txtFibonacciInput = new TextBox();
        txtBaseInput = new TextBox();
        lblRecursiveResult = new Label();
        btnCalculatePower = new Button();
        txtExponentInput = new TextBox();
        label2 = new Label();
        label3 = new Label();
        SuspendLayout();
        // 
        // labelResult
        // 
        labelResult.AutoSize = true;
        labelResult.Location = new Point(79, 82);
        labelResult.Name = "labelResult";
        labelResult.Size = new Size(0, 15);
        labelResult.TabIndex = 2;
        // 
        // btnCalculateSum
        // 
        btnCalculateSum.Location = new Point(79, 101);
        btnCalculateSum.Name = "btnCalculateSum";
        btnCalculateSum.Size = new Size(82, 37);
        btnCalculateSum.TabIndex = 3;
        btnCalculateSum.Text = "Calculate";
        btnCalculateSum.UseVisualStyleBackColor = true;
        btnCalculateSum.Click += btnCalculateSum_Click;
        // 
        // txtArrayInput
        // 
        txtArrayInput.Location = new Point(79, 72);
        txtArrayInput.Name = "txtArrayInput";
        txtArrayInput.Size = new Size(100, 23);
        txtArrayInput.TabIndex = 4;
        // 
        // label1
        // 
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(100, 23);
        label1.TabIndex = 7;
        // 
        // lblSumResult
        // 
        lblSumResult.AutoSize = true;
        lblSumResult.Location = new Point(167, 112);
        lblSumResult.Name = "lblSumResult";
        lblSumResult.Size = new Size(52, 15);
        lblSumResult.TabIndex = 6;
        lblSumResult.Text = "Factorial";
        // 
        // btnCalculateFibonacci
        // 
        btnCalculateFibonacci.Location = new Point(79, 171);
        btnCalculateFibonacci.Name = "btnCalculateFibonacci";
        btnCalculateFibonacci.Size = new Size(82, 37);
        btnCalculateFibonacci.TabIndex = 8;
        btnCalculateFibonacci.Text = "Calculate";
        btnCalculateFibonacci.UseVisualStyleBackColor = true;
        btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
        // 
        // lblFibonacciResult
        // 
        lblFibonacciResult.AutoSize = true;
        lblFibonacciResult.Location = new Point(167, 182);
        lblFibonacciResult.Name = "lblFibonacciResult";
        lblFibonacciResult.Size = new Size(58, 15);
        lblFibonacciResult.TabIndex = 9;
        lblFibonacciResult.Text = "Fibonacci";
        // 
        // txtFibonacciInput
        // 
        txtFibonacciInput.Location = new Point(79, 144);
        txtFibonacciInput.Name = "txtFibonacciInput";
        txtFibonacciInput.Size = new Size(100, 23);
        txtFibonacciInput.TabIndex = 10;
        // 
        // txtBaseInput
        // 
        txtBaseInput.Location = new Point(79, 233);
        txtBaseInput.Name = "txtBaseInput";
        txtBaseInput.Size = new Size(100, 23);
        txtBaseInput.TabIndex = 13;
        // 
        // lblRecursiveResult
        // 
        lblRecursiveResult.AutoSize = true;
        lblRecursiveResult.Location = new Point(167, 273);
        lblRecursiveResult.Name = "lblRecursiveResult";
        lblRecursiveResult.Size = new Size(57, 15);
        lblRecursiveResult.TabIndex = 12;
        lblRecursiveResult.Text = "Recursive";
        // 
        // btnCalculatePower
        // 
        btnCalculatePower.Location = new Point(79, 262);
        btnCalculatePower.Name = "btnCalculatePower";
        btnCalculatePower.Size = new Size(82, 37);
        btnCalculatePower.TabIndex = 11;
        btnCalculatePower.Text = "Calculate";
        btnCalculatePower.UseVisualStyleBackColor = true;
        btnCalculatePower.Click += btnCalculatePower_Click;
        // 
        // txtExponentInput
        // 
        txtExponentInput.Location = new Point(185, 233);
        txtExponentInput.Name = "txtExponentInput";
        txtExponentInput.Size = new Size(100, 23);
        txtExponentInput.TabIndex = 14;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(79, 215);
        label2.Name = "label2";
        label2.Size = new Size(51, 15);
        label2.TabIndex = 15;
        label2.Text = "Number";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(185, 215);
        label3.Name = "label3";
        label3.Size = new Size(56, 15);
        label3.TabIndex = 16;
        label3.Text = "Exponent";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(txtExponentInput);
        Controls.Add(txtBaseInput);
        Controls.Add(lblRecursiveResult);
        Controls.Add(btnCalculatePower);
        Controls.Add(txtFibonacciInput);
        Controls.Add(lblFibonacciResult);
        Controls.Add(btnCalculateFibonacci);
        Controls.Add(lblSumResult);
        Controls.Add(label1);
        Controls.Add(txtArrayInput);
        Controls.Add(btnCalculateSum);
        Controls.Add(labelResult);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label labelResult;
    private Button btnCalculateSum;
    private TextBox txtArrayInput;
    private Label label1;
    private Label lblSumResult;
    private Button btnCalculateFibonacci;
    private Label lblFibonacciResult;
    private TextBox txtFibonacciInput;
    private TextBox txtBaseInput;
    private Label lblRecursiveResult;
    private Button btnCalculatePower;
    private TextBox txtExponentInput;
    private Label label2;
    private Label label3;
}
