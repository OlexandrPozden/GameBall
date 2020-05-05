namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ovalPictureBox1 = new OvalPictureBox();
            this.HighScores = new System.Windows.Forms.Button();
            this.Pause_Resume = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.Size = new System.Drawing.Size(2091, 1338);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(69, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 182);
            this.textBox1.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.SlateGray;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(575, 1338);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.ovalPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ovalPictureBox1.Location = new System.Drawing.Point(997, 353);
            this.ovalPictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(267, 238);
            this.ovalPictureBox1.TabIndex = 2;
            this.ovalPictureBox1.TabStop = false;
            this.ovalPictureBox1.Click += new System.EventHandler(this.ovalPictureBox1_Click);
            // 
            // HighScores
            // 
            this.HighScores.BackColor = System.Drawing.Color.MintCream;
            this.HighScores.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScores.ForeColor = System.Drawing.Color.LightSlateGray;
            this.HighScores.Location = new System.Drawing.Point(147, 353);
            this.HighScores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HighScores.Name = "HighScores";
            this.HighScores.Size = new System.Drawing.Size(259, 83);
            this.HighScores.TabIndex = 5;
            this.HighScores.Text = "Highscores";
            this.HighScores.UseVisualStyleBackColor = false;
            this.HighScores.Click += new System.EventHandler(this.HighScores_Click);
            // 
            // Pause_Resume
            // 
            this.Pause_Resume.BackColor = System.Drawing.Color.LightSlateGray;
            this.Pause_Resume.Enabled = false;
            this.Pause_Resume.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause_Resume.ForeColor = System.Drawing.Color.SlateGray;
            this.Pause_Resume.Location = new System.Drawing.Point(147, 479);
            this.Pause_Resume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pause_Resume.Name = "Pause_Resume";
            this.Pause_Resume.Size = new System.Drawing.Size(259, 100);
            this.Pause_Resume.TabIndex = 6;
            this.Pause_Resume.Text = "Pause";
            this.Pause_Resume.UseVisualStyleBackColor = false;
            this.Pause_Resume.Click += new System.EventHandler(this.Pause_Resume_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.MintCream;
            this.Start.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.LightSlateGray;
            this.Start.Location = new System.Drawing.Point(147, 584);
            this.Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(259, 181);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(171, 873);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 74);
            this.label1.TabIndex = 8;
            this.label1.Text = "00:00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2091, 1338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Pause_Resume);
            this.Controls.Add(this.HighScores);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ovalPictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button HighScores;
        private System.Windows.Forms.Button Pause_Resume;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
    }
}