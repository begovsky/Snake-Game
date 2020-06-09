namespace Project.User_Controls
{
    partial class ucRecord
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any Resources being used.
        /// </summary>
        /// <param name="disposing">true if managed Resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRecord));
            this.pbAnimation = new System.Windows.Forms.PictureBox();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReseted = new System.Windows.Forms.Label();
            this.btnResetScore = new System.Windows.Forms.Button();
            this.pbBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAnimation
            // 
            this.pbAnimation.Image = ((System.Drawing.Image)(resources.GetObject("pbAnimation.Image")));
            this.pbAnimation.Location = new System.Drawing.Point(53, 150);
            this.pbAnimation.Name = "pbAnimation";
            this.pbAnimation.Size = new System.Drawing.Size(188, 167);
            this.pbAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimation.TabIndex = 0;
            this.pbAnimation.TabStop = false;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(374, 236);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(31, 36);
            this.lblRecord.TabIndex = 1;
            this.lblRecord.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "YOUR RECORD :";
            // 
            // lblReseted
            // 
            this.lblReseted.AutoSize = true;
            this.lblReseted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReseted.Location = new System.Drawing.Point(190, 493);
            this.lblReseted.Name = "lblReseted";
            this.lblReseted.Size = new System.Drawing.Size(224, 20);
            this.lblReseted.TabIndex = 3;
            this.lblReseted.Text = "Your record has been reseted.";
            // 
            // btnResetScore
            // 
            this.btnResetScore.Location = new System.Drawing.Point(201, 394);
            this.btnResetScore.Name = "btnResetScore";
            this.btnResetScore.Size = new System.Drawing.Size(189, 73);
            this.btnResetScore.TabIndex = 4;
            this.btnResetScore.Text = "RESET YOUR RECORD";
            this.btnResetScore.UseVisualStyleBackColor = true;
            this.btnResetScore.Click += new System.EventHandler(this.btnResetScore_Click);
            // 
            // pbBack
            // 
            this.pbBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBack.BackgroundImage")));
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(27, 51);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(63, 38);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 5;
            this.pbBack.TabStop = false;
            // 
            // ucRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.btnResetScore);
            this.Controls.Add(this.lblReseted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.pbAnimation);
            this.DoubleBuffered = true;
            this.Name = "ucRecord";
            this.Size = new System.Drawing.Size(595, 564);
            this.Load += new System.EventHandler(this.ucRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnimation;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblRecord;
        public System.Windows.Forms.Button btnResetScore;
        public System.Windows.Forms.PictureBox pbBack;
        public System.Windows.Forms.Label lblReseted;
    }
}
