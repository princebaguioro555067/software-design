namespace lab3;

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
        btnShowInfo = new Button();
        listBoxBooks = new ListBox();
        btnProcessBooks = new Button();
        btnTextbook = new Button();
        btnAudiobook = new Button();
        SuspendLayout();
        // 
        // btnShowInfo
        // 
        btnShowInfo.Location = new Point(26, 24);
        btnShowInfo.Name = "btnShowInfo";
        btnShowInfo.Size = new Size(147, 48);
        btnShowInfo.TabIndex = 0;
        btnShowInfo.Text = "Show";
        btnShowInfo.UseVisualStyleBackColor = true;
        btnShowInfo.Click += btnShow_Click;
        // 
        // listBoxBooks
        // 
        listBoxBooks.FormattingEnabled = true;
        listBoxBooks.ItemHeight = 15;
        listBoxBooks.Location = new Point(218, 24);
        listBoxBooks.Name = "listBoxBooks";
        listBoxBooks.Size = new Size(505, 229);
        listBoxBooks.TabIndex = 1;
        // 
        // btnProcessBooks
        // 
        btnProcessBooks.Location = new Point(26, 78);
        btnProcessBooks.Name = "btnProcessBooks";
        btnProcessBooks.Size = new Size(147, 49);
        btnProcessBooks.TabIndex = 2;
        btnProcessBooks.Text = "Show Library";
        btnProcessBooks.UseVisualStyleBackColor = true;
        btnProcessBooks.Click += btnProcessBooks_Click;
        // 
        // btnTextbook
        // 
        btnTextbook.Location = new Point(26, 133);
        btnTextbook.Name = "btnTextbook";
        btnTextbook.Size = new Size(147, 47);
        btnTextbook.TabIndex = 3;
        btnTextbook.Text = "Textbooks";
        btnTextbook.UseVisualStyleBackColor = true;
        btnTextbook.Click += btnTextbook_Click;
        // 
        // btnAudiobook
        // 
        btnAudiobook.Location = new Point(26, 186);
        btnAudiobook.Name = "btnAudiobook";
        btnAudiobook.Size = new Size(147, 47);
        btnAudiobook.TabIndex = 4;
        btnAudiobook.Text = "Audiobooks";
        btnAudiobook.UseVisualStyleBackColor = true;
        btnAudiobook.Click += btnAudiobook_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnAudiobook);
        Controls.Add(btnTextbook);
        Controls.Add(btnProcessBooks);
        Controls.Add(listBoxBooks);
        Controls.Add(btnShowInfo);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button btnShowInfo;
    private ListBox listBoxBooks;
    private Button btnProcessBooks;
    private Button btnTextbook;
    private Button btnAudiobook;
}
