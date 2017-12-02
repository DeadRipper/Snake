namespace Snake
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
            this.libScore = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblGameOver1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // libScore
            // 
            this.libScore.AutoSize = true;
            this.libScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.libScore.Location = new System.Drawing.Point(744, 37);
            this.libScore.Name = "libScore";
            this.libScore.Size = new System.Drawing.Size(0, 37);
            this.libScore.TabIndex = 6;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score.Location = new System.Drawing.Point(638, 37);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(115, 37);
            this.Score.TabIndex = 5;
            this.Score.Text = "Result:";
            // 
            // pbCanvas
            // 
            this.pbCanvas.Location = new System.Drawing.Point(101, 37);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(520, 454);
            this.pbCanvas.TabIndex = 4;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameOver.Location = new System.Drawing.Point(138, 71);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(100, 37);
            this.lblGameOver.TabIndex = 7;
            this.lblGameOver.Text = "label1";
            this.lblGameOver.Visible = false;
            // 
            // lblGameOver1
            // 
            this.lblGameOver1.AutoSize = true;
            this.lblGameOver1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameOver1.Location = new System.Drawing.Point(138, 71);
            this.lblGameOver1.Name = "lblGameOver1";
            this.lblGameOver1.Size = new System.Drawing.Size(100, 37);
            this.lblGameOver1.TabIndex = 8;
            this.lblGameOver1.Text = "label1";
            this.lblGameOver1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 511);
            this.Controls.Add(this.lblGameOver1);
            this.Controls.Add(this.libScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.lblGameOver);
            this.Name = "Form2";
            this.Text = "Змейка лёгкая";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label libScore;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblGameOver1;
    }
}