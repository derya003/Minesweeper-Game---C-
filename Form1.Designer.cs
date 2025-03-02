namespace OyunProje
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            MayintextBox = new TextBox();
            AlantextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            IsimtextBox = new TextBox();
            button1 = new Button();
            SonucLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(28, 16);
            label1.Name = "label1";
            label1.Size = new Size(505, 98);
            label1.TabIndex = 0;
            label1.Text = "MAYIN TARLASI";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.AppWorkspace;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 125);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cornsilk;
            panel2.Controls.Add(MayintextBox);
            panel2.Controls.Add(AlantextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(IsimtextBox);
            panel2.Location = new Point(40, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 238);
            panel2.TabIndex = 1;
            // 
            // MayintextBox
            // 
            MayintextBox.Location = new Point(178, 200);
            MayintextBox.Name = "MayintextBox";
            MayintextBox.Size = new Size(136, 27);
            MayintextBox.TabIndex = 5;
            // 
            // AlantextBox
            // 
            AlantextBox.Location = new Point(178, 120);
            AlantextBox.Name = "AlantextBox";
            AlantextBox.Size = new Size(136, 27);
            AlantextBox.TabIndex = 4;
            AlantextBox.TextChanged += AlantextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(124, 162);
            label4.Name = "label4";
            label4.Size = new Size(247, 24);
            label4.TabIndex = 3;
            label4.Text = "Mayın Sayısı (En az 10)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(111, 83);
            label3.Name = "label3";
            label3.Size = new Size(275, 48);
            label3.TabIndex = 2;
            label3.Text = "Alan Boyutu (En fazla 30)\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(176, 9);
            label2.Name = "label2";
            label2.Size = new Size(145, 24);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı";
            // 
            // IsimtextBox
            // 
            IsimtextBox.Location = new Point(178, 36);
            IsimtextBox.Name = "IsimtextBox";
            IsimtextBox.Size = new Size(136, 27);
            IsimtextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Cornsilk;
            button1.Font = new Font("Impact", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(211, 456);
            button1.Name = "button1";
            button1.Size = new Size(150, 75);
            button1.TabIndex = 2;
            button1.Text = "BAŞLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SonucLabel
            // 
            SonucLabel.AutoSize = true;
            SonucLabel.Font = new Font("Georgia", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            SonucLabel.ForeColor = Color.AliceBlue;
            SonucLabel.ImageAlign = ContentAlignment.MiddleRight;
            SonucLabel.Location = new Point(60, 420);
            SonucLabel.Name = "SonucLabel";
            SonucLabel.Size = new Size(0, 21);
            SonucLabel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(592, 543);
            Controls.Add(SonucLabel);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Mayın Tarlası";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox IsimtextBox;
        private TextBox MayintextBox;
        private TextBox AlantextBox;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label SonucLabel;
        private Label label5;
    }
}
