namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.BackToGame = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(509, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1007, 223);
            this.label1.TabIndex = 0;
            this.label1.Text = "High Scores";
            // 
            // Score
            // 
            this.Score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Score.Location = new System.Drawing.Point(899, 420);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(272, 112);
            this.Score.TabIndex = 1;
            this.Score.Text = "label2";
            // 
            // BackToGame
            // 
            this.BackToGame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BackToGame.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToGame.Location = new System.Drawing.Point(72, 1054);
            this.BackToGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackToGame.Name = "BackToGame";
            this.BackToGame.Size = new System.Drawing.Size(331, 126);
            this.BackToGame.TabIndex = 3;
            this.BackToGame.Text = "Back";
            this.BackToGame.UseVisualStyleBackColor = true;
            this.BackToGame.Click += new System.EventHandler(this.BackToGame_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(1422, 465);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(135, 46);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(2091, 1338);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.BackToGame);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button BackToGame;
        private System.Windows.Forms.Button refresh;
    }
}