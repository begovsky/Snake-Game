namespace Project
{
    partial class SnakeGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any Resources being used.
        /// </summary>
        /// <param name="disposing">true if managed Appearances should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeGame));
            this.lblGameOver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pbScoreIcon = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.timerRedSnakeEffect = new System.Windows.Forms.Timer(this.components);
            this.pbPause = new System.Windows.Forms.PictureBox();
            this.pbGameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScoreIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(456, 174);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(60, 24);
            this.lblGameOver.TabIndex = 7;
            this.lblGameOver.Text = "label2";
            this.lblGameOver.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 6;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(504, 52);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(115, 37);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Points:";
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Transparent;
            this.pbCanvas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCanvas.BackgroundImage")));
            this.pbCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCanvas.Location = new System.Drawing.Point(12, 12);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(432, 400);
            this.pbCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCanvas.TabIndex = 4;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // pbScoreIcon
            // 
            this.pbScoreIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbScoreIcon.Image")));
            this.pbScoreIcon.Location = new System.Drawing.Point(452, 40);
            this.pbScoreIcon.Name = "pbScoreIcon";
            this.pbScoreIcon.Size = new System.Drawing.Size(60, 46);
            this.pbScoreIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScoreIcon.TabIndex = 8;
            this.pbScoreIcon.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(456, 126);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 24);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "label2";
            this.lblUsername.Visible = false;
            // 
            // pbPause
            // 
            this.pbPause.BackColor = System.Drawing.Color.Transparent;
            this.pbPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPause.BackgroundImage")));
            this.pbPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPause.Image = ((System.Drawing.Image)(resources.GetObject("pbPause.Image")));
            this.pbPause.Location = new System.Drawing.Point(458, 334);
            this.pbPause.Name = "pbPause";
            this.pbPause.Size = new System.Drawing.Size(239, 91);
            this.pbPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPause.TabIndex = 10;
            this.pbPause.TabStop = false;
            // 
            // pbGameOver
            // 
            this.pbGameOver.Image = ((System.Drawing.Image)(resources.GetObject("pbGameOver.Image")));
            this.pbGameOver.Location = new System.Drawing.Point(60, 115);
            this.pbGameOver.Name = "pbGameOver";
            this.pbGameOver.Size = new System.Drawing.Size(329, 179);
            this.pbGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGameOver.TabIndex = 11;
            this.pbGameOver.TabStop = false;
            this.pbGameOver.Visible = false;
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(719, 424);
            this.Controls.Add(this.pbGameOver);
            this.Controls.Add(this.pbPause);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbScoreIcon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SnakeGame_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SnakeGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScoreIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pbScoreIcon;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Timer timerRedSnakeEffect;
        private System.Windows.Forms.PictureBox pbPause;
        public System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.PictureBox pbGameOver;
    }
}

