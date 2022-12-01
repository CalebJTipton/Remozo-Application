namespace Remozo_Application
{
    partial class locate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locate));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_disable = new System.Windows.Forms.Button();
            this.btn_displayLog = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 1141);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_disable
            // 
            this.btn_disable.Location = new System.Drawing.Point(100, 966);
            this.btn_disable.Name = "btn_disable";
            this.btn_disable.Size = new System.Drawing.Size(327, 60);
            this.btn_disable.TabIndex = 1;
            this.btn_disable.Text = "Disable Vehicle";
            this.btn_disable.UseVisualStyleBackColor = true;
            // 
            // btn_displayLog
            // 
            this.btn_displayLog.Location = new System.Drawing.Point(174, 915);
            this.btn_displayLog.Name = "btn_displayLog";
            this.btn_displayLog.Size = new System.Drawing.Size(190, 30);
            this.btn_displayLog.TabIndex = 2;
            this.btn_displayLog.Text = "View Activity Log";
            this.btn_displayLog.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(0, 154);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(110, 37);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // locate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 1102);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_displayLog);
            this.Controls.Add(this.btn_disable);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(523, 1141);
            this.MinimumSize = new System.Drawing.Size(523, 1141);
            this.Name = "locate";
            this.Text = "Locate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_disable;
        private Button btn_displayLog;
        private Button btn_back;
    }
}