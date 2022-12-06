namespace Remozo_Application
{
    partial class activityLog
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
            this.btn_disableVehicle = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pb_scroll = new System.Windows.Forms.PictureBox();
            this.btn_lastWeek = new System.Windows.Forms.Button();
            this.btn_lastMonth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_scroll)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.App___Activity;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 1100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_disableVehicle
            // 
            this.btn_disableVehicle.BackColor = System.Drawing.Color.Red;
            this.btn_disableVehicle.FlatAppearance.BorderSize = 0;
            this.btn_disableVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disableVehicle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_disableVehicle.ForeColor = System.Drawing.Color.White;
            this.btn_disableVehicle.Location = new System.Drawing.Point(90, 976);
            this.btn_disableVehicle.Name = "btn_disableVehicle";
            this.btn_disableVehicle.Size = new System.Drawing.Size(345, 76);
            this.btn_disableVehicle.TabIndex = 1;
            this.btn_disableVehicle.Text = "Disable Vehicle";
            this.btn_disableVehicle.UseVisualStyleBackColor = false;
            this.btn_disableVehicle.Click += new System.EventHandler(this.btn_disableVehicle_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(43, 147);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(74, 38);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pb_scroll
            // 
            this.pb_scroll.BackColor = System.Drawing.Color.Black;
            this.pb_scroll.Location = new System.Drawing.Point(479, 384);
            this.pb_scroll.Name = "pb_scroll";
            this.pb_scroll.Size = new System.Drawing.Size(31, 69);
            this.pb_scroll.TabIndex = 4;
            this.pb_scroll.TabStop = false;
            this.pb_scroll.Click += new System.EventHandler(this.pb_scroll_Click);
            // 
            // btn_lastWeek
            // 
            this.btn_lastWeek.BackColor = System.Drawing.Color.White;
            this.btn_lastWeek.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_lastWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lastWeek.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_lastWeek.Location = new System.Drawing.Point(173, 276);
            this.btn_lastWeek.Name = "btn_lastWeek";
            this.btn_lastWeek.Size = new System.Drawing.Size(155, 41);
            this.btn_lastWeek.TabIndex = 5;
            this.btn_lastWeek.Text = "Last Week";
            this.btn_lastWeek.UseVisualStyleBackColor = false;
            this.btn_lastWeek.Click += new System.EventHandler(this.btn_lastWeek_Click);
            // 
            // btn_lastMonth
            // 
            this.btn_lastMonth.BackColor = System.Drawing.Color.White;
            this.btn_lastMonth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_lastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lastMonth.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_lastMonth.Location = new System.Drawing.Point(334, 276);
            this.btn_lastMonth.Name = "btn_lastMonth";
            this.btn_lastMonth.Size = new System.Drawing.Size(143, 41);
            this.btn_lastMonth.TabIndex = 6;
            this.btn_lastMonth.Text = "Last Month";
            this.btn_lastMonth.UseVisualStyleBackColor = false;
            this.btn_lastMonth.Click += new System.EventHandler(this.btn_lastMonth_Click);
            // 
            // activityLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 1102);
            this.Controls.Add(this.btn_lastMonth);
            this.Controls.Add(this.btn_lastWeek);
            this.Controls.Add(this.pb_scroll);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_disableVehicle);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(538, 1141);
            this.MinimumSize = new System.Drawing.Size(538, 1141);
            this.Name = "activityLog";
            this.Text = "Remozo - Activity Log";
            this.Load += new System.EventHandler(this.activityLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_scroll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_disableVehicle;
        private Button btn_back;
        private PictureBox pb_scroll;
        private Button btn_lastWeek;
        private Button btn_lastMonth;
    }
}