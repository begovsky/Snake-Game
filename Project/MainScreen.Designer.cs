namespace Project
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any Appearances being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.panelUC = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pbSound = new System.Windows.Forms.PictureBox();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pbMyRecord = new System.Windows.Forms.PictureBox();
            this.pbInstructions = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUC
            // 
            this.panelUC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelUC.BackgroundImage")));
            this.panelUC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUC.Location = new System.Drawing.Point(205, -1);
            this.panelUC.Name = "panelUC";
            this.panelUC.Size = new System.Drawing.Size(595, 564);
            this.panelUC.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(741, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 46);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // pbSound
            // 
            this.pbSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSound.Image = ((System.Drawing.Image)(resources.GetObject("pbSound.Image")));
            this.pbSound.Location = new System.Drawing.Point(215, 47);
            this.pbSound.Name = "pbSound";
            this.pbSound.Size = new System.Drawing.Size(46, 46);
            this.pbSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSound.TabIndex = 12;
            this.pbSound.TabStop = false;
            // 
            // pbSettings
            // 
            this.pbSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSettings.Image = global::Project.Properties.Resources.btnSettings;
            this.pbSettings.Location = new System.Drawing.Point(370, 468);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(264, 67);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSettings.TabIndex = 3;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            // 
            // pbMyRecord
            // 
            this.pbMyRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMyRecord.Image = global::Project.Properties.Resources.btnMyRecord;
            this.pbMyRecord.Location = new System.Drawing.Point(370, 385);
            this.pbMyRecord.Name = "pbMyRecord";
            this.pbMyRecord.Size = new System.Drawing.Size(264, 67);
            this.pbMyRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMyRecord.TabIndex = 4;
            this.pbMyRecord.TabStop = false;
            this.pbMyRecord.Click += new System.EventHandler(this.pbMyRecord_Click);
            // 
            // pbInstructions
            // 
            this.pbInstructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInstructions.Image = global::Project.Properties.Resources.btnInstr;
            this.pbInstructions.Location = new System.Drawing.Point(370, 301);
            this.pbInstructions.Name = "pbInstructions";
            this.pbInstructions.Size = new System.Drawing.Size(264, 67);
            this.pbInstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInstructions.TabIndex = 2;
            this.pbInstructions.TabStop = false;
            this.pbInstructions.Click += new System.EventHandler(this.pbInstructions_Click);
            // 
            // pbPlay
            // 
            this.pbPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlay.Image = global::Project.Properties.Resources.btnPlay;
            this.pbPlay.Location = new System.Drawing.Point(370, 218);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(264, 67);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlay.TabIndex = 5;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.pbPlay_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Project.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(329, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(340, 196);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // pbForm
            // 
            this.pbForm.Image = ((System.Drawing.Image)(resources.GetObject("pbForm.Image")));
            this.pbForm.Location = new System.Drawing.Point(0, -1);
            this.pbForm.Name = "pbForm";
            this.pbForm.Size = new System.Drawing.Size(1004, 564);
            this.pbForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbForm.TabIndex = 0;
            this.pbForm.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.panelUC);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbSound);
            this.Controls.Add(this.pbSettings);
            this.Controls.Add(this.pbMyRecord);
            this.Controls.Add(this.pbInstructions);
            this.Controls.Add(this.pbPlay);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Click += new System.EventHandler(this.MainScreen_Click);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbForm;
        private System.Windows.Forms.PictureBox pbInstructions;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.PictureBox pbMyRecord;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbSound;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panelUC;
    }
}