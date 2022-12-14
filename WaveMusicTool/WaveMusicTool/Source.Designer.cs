namespace WaveMusicTool
{
    partial class Source
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Source));
            this.OpenFolderButton = new System.Windows.Forms.Button();
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StopButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenFolderButton.BackgroundImage")));
            this.OpenFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFolderButton.Location = new System.Drawing.Point(24, 24);
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Size = new System.Drawing.Size(40, 40);
            this.OpenFolderButton.TabIndex = 0;
            this.OpenFolderButton.UseVisualStyleBackColor = true;
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.Location = new System.Drawing.Point(88, 32);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.ReadOnly = true;
            this.DirectoryTextBox.Size = new System.Drawing.Size(628, 25);
            this.DirectoryTextBox.TabIndex = 1;
            this.DirectoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.PlayButton);
            this.panel1.Location = new System.Drawing.Point(24, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 119);
            this.panel1.TabIndex = 2;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(264, 28);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(181, 61);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(43, 28);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(181, 61);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(541, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 243);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DirectoryTextBox);
            this.Controls.Add(this.OpenFolderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wave Music  |  Noten";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFolderButton;
        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

