﻿namespace Remozo_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_moveToNextPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.App___Loading_Screen1;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 977);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btn_moveToNextPage
            // 
            this.btn_moveToNextPage.Location = new System.Drawing.Point(184, 156);
            this.btn_moveToNextPage.Name = "btn_moveToNextPage";
            this.btn_moveToNextPage.Size = new System.Drawing.Size(168, 23);
            this.btn_moveToNextPage.TabIndex = 1;
            this.btn_moveToNextPage.Text = "MoveToNextPage";
            this.btn_moveToNextPage.UseVisualStyleBackColor = true;
            this.btn_moveToNextPage.Click += new System.EventHandler(this.btn_moveToNextPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 974);
            this.Controls.Add(this.btn_moveToNextPage);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(526, 1013);
            this.MinimumSize = new System.Drawing.Size(526, 1013);
            this.Name = "Form1";
            this.Text = "Remozo Car Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_moveToNextPage;
    }
}