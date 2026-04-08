namespace Exam_1___Set_A___BAGUIORO
{
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btnItem3 = new Button();
            btnItem2 = new Button();
            btnItem1 = new Button();
            label1 = new Label();
            txtQuantity = new TextBox();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            label6 = new Label();
            txtTotal = new TextBox();
            label5 = new Label();
            txtVATable = new TextBox();
            label4 = new Label();
            txtVAT = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txtDiscount = new TextBox();
            txtPrice = new TextBox();
            panel3 = new Panel();
            btnClear = new Button();
            btnCompute = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 461);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnItem3);
            groupBox1.Controls.Add(btnItem2);
            groupBox1.Controls.Add(btnItem1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 461);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
            // 
            // btnItem3
            // 
            btnItem3.Location = new Point(130, 188);
            btnItem3.Name = "btnItem3";
            btnItem3.Size = new Size(123, 62);
            btnItem3.TabIndex = 7;
            btnItem3.Text = "Item 3";
            btnItem3.UseVisualStyleBackColor = true;
            btnItem3.Click += btnItem3_Click;
            // 
            // btnItem2
            // 
            btnItem2.Location = new Point(130, 120);
            btnItem2.Name = "btnItem2";
            btnItem2.Size = new Size(123, 62);
            btnItem2.TabIndex = 6;
            btnItem2.Text = "Item 2";
            btnItem2.UseVisualStyleBackColor = true;
            btnItem2.Click += btnItem2_Click;
            // 
            // btnItem1
            // 
            btnItem1.Location = new Point(130, 52);
            btnItem1.Name = "btnItem1";
            btnItem1.Size = new Size(123, 62);
            btnItem1.TabIndex = 5;
            btnItem1.Text = "Item 1";
            btnItem1.UseVisualStyleBackColor = true;
            btnItem1.Click += btnItem1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(68, 331);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "Qty:";
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtQuantity.Location = new Point(130, 328);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(123, 23);
            txtQuantity.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(443, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(439, 461);
            panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtTotal);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtVATable);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtVAT);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 223);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(439, 242);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Computation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 97);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 14;
            label6.Text = "Total Amount:";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTotal.Location = new Point(176, 94);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(115, 23);
            txtTotal.TabIndex = 13;
            txtTotal.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 39);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 12;
            label5.Text = "VATable Amount:";
            // 
            // txtVATable
            // 
            txtVATable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtVATable.Location = new Point(176, 36);
            txtVATable.Name = "txtVATable";
            txtVATable.ReadOnly = true;
            txtVATable.Size = new Size(115, 23);
            txtVATable.TabIndex = 11;
            txtVATable.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 68);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 10;
            label4.Text = "VAT - 12%:";
            // 
            // txtVAT
            // 
            txtVAT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtVAT.Location = new Point(176, 65);
            txtVAT.Name = "txtVAT";
            txtVAT.ReadOnly = true;
            txtVAT.Size = new Size(115, 23);
            txtVAT.TabIndex = 7;
            txtVAT.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtDiscount);
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(439, 223);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(31, 123);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Discount:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(31, 68);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Price:";
            // 
            // txtDiscount
            // 
            txtDiscount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDiscount.Location = new Point(93, 120);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(115, 23);
            txtDiscount.TabIndex = 5;
            txtDiscount.TabStop = false;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPrice.Location = new Point(93, 65);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(115, 23);
            txtPrice.TabIndex = 4;
            txtPrice.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnCompute);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 461);
            panel3.Name = "panel3";
            panel3.Size = new Size(884, 100);
            panel3.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(456, 29);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(355, 29);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(75, 23);
            btnCompute.TabIndex = 0;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click_1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(259, 331);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 8;
            label7.Text = "/pc";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Sales Computation";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox txtQuantity;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox txtDiscount;
        private TextBox txtPrice;
        private TextBox txtVAT;
        private Label label1;
        private Label label6;
        private TextBox txtTotal;
        private Label label5;
        private TextBox txtVATable;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnClear;
        private Button btnCompute;
        private Button btnItem3;
        private Button btnItem2;
        private Button btnItem1;
        private Label label7;
    }
}
