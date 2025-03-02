namespace OyunProje
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            TableLayoutPanel = new TableLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            timerLabel = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            LabelHamle = new Label();
            button1 = new Button();
            labelSkor = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.BackColor = Color.Cornsilk;
            TableLayoutPanel.ColumnCount = 1;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.ForeColor = SystemColors.ButtonHighlight;
            TableLayoutPanel.Location = new Point(29, 99);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 1;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48.25046F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 51.74954F));
            TableLayoutPanel.Size = new Size(848, 543);
            TableLayoutPanel.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(16, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 42);
            label1.TabIndex = 1;
            label1.Text = "SAYAÇ";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            timerLabel.ForeColor = Color.DarkSlateGray;
            timerLabel.Location = new Point(66, 42);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(0, 32);
            timerLabel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(timerLabel);
            panel1.Location = new Point(741, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 84);
            panel1.TabIndex = 4;
          
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(13, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 42);
            label3.TabIndex = 1;
            label3.Text = "HAMLE";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cornsilk;
            panel3.Controls.Add(LabelHamle);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(32, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 84);
            panel3.TabIndex = 6;
            // 
            // LabelHamle
            // 
            LabelHamle.AutoSize = true;
            LabelHamle.Location = new Point(51, 51);
            LabelHamle.Name = "LabelHamle";
            LabelHamle.Size = new Size(0, 20);
            LabelHamle.TabIndex = 0;
            LabelHamle.Click += label2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(324, 9);
            button1.Name = "button1";
            button1.Size = new Size(280, 42);
            button1.TabIndex = 7;
            button1.Text = "SKOR TABLOSU";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // labelSkor
            // 
            labelSkor.AutoSize = true;
            labelSkor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelSkor.Location = new Point(425, 60);
            labelSkor.Name = "labelSkor";
            labelSkor.Size = new Size(0, 28);
            labelSkor.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(929, 654);
            Controls.Add(labelSkor);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(TableLayoutPanel);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        public Label timerLabel;
        private Panel panel1;
        private Label label3;
        private Panel panel3;
        private Button button1;
        private Label LabelHamle;
        public Label labelSkor;
    }
}