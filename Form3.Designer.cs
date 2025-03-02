namespace OyunProje
{
    partial class Form3
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(225, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(294, 59);
            label1.TabIndex = 0;
            label1.Text = "SKOR TABLOSU";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cornsilk;
            button1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(274, 536);
            button1.Name = "button1";
            button1.Size = new Size(232, 54);
            button1.TabIndex = 1;
            button1.Text = "Yeniden Oyna";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Cornsilk;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1 });
            listView1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listView1.ForeColor = Color.Black;
            listView1.Location = new Point(225, 113);
            listView1.Name = "listView1";
            listView1.Size = new Size(333, 401);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 1;
            columnHeader2.Text = "Kullanıcı Adı";
            columnHeader2.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 0;
            columnHeader1.Text = "Skor";
            columnHeader1.Width = 180;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 611);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        public ColumnHeader columnHeader1;
    }
}