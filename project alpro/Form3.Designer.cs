namespace ProjectAlpro
{
    partial class FormGameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameOver));
            this.buttonBackToStart = new System.Windows.Forms.Button();
            this.buttonTryAgain = new System.Windows.Forms.Button();
            this.labelJawabanBenar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToStart
            // 
            this.buttonBackToStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBackToStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBackToStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToStart.Location = new System.Drawing.Point(12, 487);
            this.buttonBackToStart.Name = "buttonBackToStart";
            this.buttonBackToStart.Size = new System.Drawing.Size(98, 56);
            this.buttonBackToStart.TabIndex = 1;
            this.buttonBackToStart.Text = "Back to start";
            this.buttonBackToStart.UseVisualStyleBackColor = false;
            this.buttonBackToStart.Click += new System.EventHandler(this.buttonBackToStart_Click);
            // 
            // buttonTryAgain
            // 
            this.buttonTryAgain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTryAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTryAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTryAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTryAgain.Location = new System.Drawing.Point(398, 487);
            this.buttonTryAgain.Name = "buttonTryAgain";
            this.buttonTryAgain.Size = new System.Drawing.Size(103, 56);
            this.buttonTryAgain.TabIndex = 2;
            this.buttonTryAgain.Text = "Try Again";
            this.buttonTryAgain.UseVisualStyleBackColor = false;
            this.buttonTryAgain.Click += new System.EventHandler(this.buttonTryAgain_Click);
            // 
            // labelJawabanBenar
            // 
            this.labelJawabanBenar.AutoSize = true;
            this.labelJawabanBenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJawabanBenar.Location = new System.Drawing.Point(110, 34);
            this.labelJawabanBenar.Name = "labelJawabanBenar";
            this.labelJawabanBenar.Size = new System.Drawing.Size(0, 32);
            this.labelJawabanBenar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 554);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 6;
            // 
            // FormGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelJawabanBenar);
            this.Controls.Add(this.buttonTryAgain);
            this.Controls.Add(this.buttonBackToStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver";
            this.Load += new System.EventHandler(this.FormGameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBackToStart;
        private System.Windows.Forms.Button buttonTryAgain;
        private System.Windows.Forms.Label labelJawabanBenar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}