﻿namespace Space_Invaders
{
    partial class FrmGameScreen
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
            this.PcbGameScreen = new System.Windows.Forms.PictureBox();
            this.BtnGameStart = new System.Windows.Forms.Button();
            this.BtnGameClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGameScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbGameScreen
            // 
            this.PcbGameScreen.Location = new System.Drawing.Point(12, 12);
            this.PcbGameScreen.Name = "PcbGameScreen";
            this.PcbGameScreen.Size = new System.Drawing.Size(1160, 710);
            this.PcbGameScreen.TabIndex = 0;
            this.PcbGameScreen.TabStop = false;
            // 
            // BtnGameStart
            // 
            this.BtnGameStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGameStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGameStart.ForeColor = System.Drawing.Color.Red;
            this.BtnGameStart.Location = new System.Drawing.Point(12, 728);
            this.BtnGameStart.Name = "BtnGameStart";
            this.BtnGameStart.Size = new System.Drawing.Size(75, 25);
            this.BtnGameStart.TabIndex = 0;
            this.BtnGameStart.TabStop = false;
            this.BtnGameStart.Text = "Start";
            this.BtnGameStart.UseVisualStyleBackColor = false;
            this.BtnGameStart.Click += new System.EventHandler(this.BtnGameStart_Click);
            // 
            // BtnGameClose
            // 
            this.BtnGameClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGameClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGameClose.ForeColor = System.Drawing.Color.Red;
            this.BtnGameClose.Location = new System.Drawing.Point(1097, 728);
            this.BtnGameClose.Name = "BtnGameClose";
            this.BtnGameClose.Size = new System.Drawing.Size(75, 25);
            this.BtnGameClose.TabIndex = 0;
            this.BtnGameClose.TabStop = false;
            this.BtnGameClose.Text = "Close";
            this.BtnGameClose.UseVisualStyleBackColor = false;
            this.BtnGameClose.Click += new System.EventHandler(this.BtnGameClose_Click);
            // 
            // FrmGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.BtnGameClose);
            this.Controls.Add(this.BtnGameStart);
            this.Controls.Add(this.PcbGameScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGameScreen";
            this.Text = "Space Invaders";
            ((System.ComponentModel.ISupportInitialize)(this.PcbGameScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbGameScreen;
        private System.Windows.Forms.Button BtnGameStart;
        private System.Windows.Forms.Button BtnGameClose;
    }
}

