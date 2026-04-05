namespace Task5;

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
        listBoxResults = new ListBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        SuspendLayout();
        // 
        // listBoxResults
        // 
        listBoxResults.FormattingEnabled = true;
        listBoxResults.Location = new Point(180, 34);
        listBoxResults.Name = "listBoxResults";
        listBoxResults.Size = new Size(369, 214);
        listBoxResults.TabIndex = 0;
        listBoxResults.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // button1
        // 
        button1.Location = new Point(62, 34);
        button1.Name = "button1";
        button1.Size = new Size(112, 56);
        button1.TabIndex = 1;
        button1.Text = "Bubble Sort";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(62, 96);
        button2.Name = "button2";
        button2.Size = new Size(112, 56);
        button2.TabIndex = 2;
        button2.Text = "Decending Order";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(62, 158);
        button3.Name = "button3";
        button3.Size = new Size(112, 57);
        button3.TabIndex = 3;
        button3.Text = "Ascending Order";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(listBoxResults);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private ListBox listBoxResults;
    private Button button1;
    private Button button2;
    private Button button3;
}
