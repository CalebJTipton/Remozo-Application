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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_diableVehicle = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_viewActivityLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.Locate;
            this.pictureBox1.Location = new System.Drawing.Point(0, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 1111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_diableVehicle
            // 
            this.btn_diableVehicle.BackColor = System.Drawing.Color.Red;
            this.btn_diableVehicle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_diableVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diableVehicle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_diableVehicle.ForeColor = System.Drawing.Color.White;
            this.btn_diableVehicle.Location = new System.Drawing.Point(91, 955);
            this.btn_diableVehicle.Name = "btn_diableVehicle";
            this.btn_diableVehicle.Size = new System.Drawing.Size(347, 73);
            this.btn_diableVehicle.TabIndex = 5;
            this.btn_diableVehicle.Text = "Disable Vehicle";
            this.btn_diableVehicle.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(43, 148);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 36);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_viewActivityLog
            // 
            this.btn_viewActivityLog.BackColor = System.Drawing.Color.White;
            this.btn_viewActivityLog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_viewActivityLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewActivityLog.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_viewActivityLog.Location = new System.Drawing.Point(171, 906);
            this.btn_viewActivityLog.Name = "btn_viewActivityLog";
            this.btn_viewActivityLog.Size = new System.Drawing.Size(199, 33);
            this.btn_viewActivityLog.TabIndex = 7;
            this.btn_viewActivityLog.Text = "View Activity Log";
            this.btn_viewActivityLog.UseVisualStyleBackColor = false;
            // 
            // locate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 1102);
            this.Controls.Add(this.btn_viewActivityLog);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_diableVehicle);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(538, 1141);
            this.MinimumSize = new System.Drawing.Size(538, 1141);
            this.Name = "locate";
            this.Text = "locate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_diableVehicle;
        private Button btn_back;
        private Button btn_viewActivityLog;
    }
}