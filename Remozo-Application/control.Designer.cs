namespace Remozo_Application
{
    partial class control
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_diableVehicle = new System.Windows.Forms.Button();
            this.window1Group = new System.Windows.Forms.GroupBox();
            this.rbtn_window1_closed = new System.Windows.Forms.RadioButton();
            this.rbtn_window1_open = new System.Windows.Forms.RadioButton();
            this.window2Group = new System.Windows.Forms.GroupBox();
            this.rbtn_window2_closed = new System.Windows.Forms.RadioButton();
            this.rbtn_window2_open = new System.Windows.Forms.RadioButton();
            this.window3Group = new System.Windows.Forms.GroupBox();
            this.rbtn_window3_closed = new System.Windows.Forms.RadioButton();
            this.rbtn_window3_open = new System.Windows.Forms.RadioButton();
            this.window4Group = new System.Windows.Forms.GroupBox();
            this.rbtn_window4_closed = new System.Windows.Forms.RadioButton();
            this.rbtn_window4_open = new System.Windows.Forms.RadioButton();
            this.window5Group = new System.Windows.Forms.GroupBox();
            this.rbtn_window5_closed = new System.Windows.Forms.RadioButton();
            this.rbtn_window5_open = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.window1Group.SuspendLayout();
            this.window2Group.SuspendLayout();
            this.window3Group.SuspendLayout();
            this.window4Group.SuspendLayout();
            this.window5Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.Control;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 1108);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(38, 155);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 37);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_diableVehicle
            // 
            this.btn_diableVehicle.BackColor = System.Drawing.Color.Red;
            this.btn_diableVehicle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_diableVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diableVehicle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_diableVehicle.ForeColor = System.Drawing.Color.White;
            this.btn_diableVehicle.Location = new System.Drawing.Point(85, 412);
            this.btn_diableVehicle.Name = "btn_diableVehicle";
            this.btn_diableVehicle.Size = new System.Drawing.Size(347, 73);
            this.btn_diableVehicle.TabIndex = 4;
            this.btn_diableVehicle.Text = "Disable Vehicle";
            this.btn_diableVehicle.UseVisualStyleBackColor = false;
            this.btn_diableVehicle.Click += new System.EventHandler(this.btn_diableVehicle_Click);
            // 
            // window1Group
            // 
            this.window1Group.BackColor = System.Drawing.Color.White;
            this.window1Group.Controls.Add(this.rbtn_window1_closed);
            this.window1Group.Controls.Add(this.rbtn_window1_open);
            this.window1Group.Location = new System.Drawing.Point(21, 753);
            this.window1Group.Name = "window1Group";
            this.window1Group.Size = new System.Drawing.Size(75, 60);
            this.window1Group.TabIndex = 10;
            this.window1Group.TabStop = false;
            // 
            // rbtn_window1_closed
            // 
            this.rbtn_window1_closed.AutoSize = true;
            this.rbtn_window1_closed.Checked = true;
            this.rbtn_window1_closed.Location = new System.Drawing.Point(6, 34);
            this.rbtn_window1_closed.Name = "rbtn_window1_closed";
            this.rbtn_window1_closed.Size = new System.Drawing.Size(61, 19);
            this.rbtn_window1_closed.TabIndex = 1;
            this.rbtn_window1_closed.TabStop = true;
            this.rbtn_window1_closed.Text = "Closed";
            this.rbtn_window1_closed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_window1_closed.UseVisualStyleBackColor = true;
            // 
            // rbtn_window1_open
            // 
            this.rbtn_window1_open.AutoSize = true;
            this.rbtn_window1_open.Location = new System.Drawing.Point(6, 15);
            this.rbtn_window1_open.Name = "rbtn_window1_open";
            this.rbtn_window1_open.Size = new System.Drawing.Size(54, 19);
            this.rbtn_window1_open.TabIndex = 0;
            this.rbtn_window1_open.Text = "Open";
            this.rbtn_window1_open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_window1_open.UseVisualStyleBackColor = true;
            // 
            // window2Group
            // 
            this.window2Group.BackColor = System.Drawing.Color.White;
            this.window2Group.Controls.Add(this.rbtn_window2_closed);
            this.window2Group.Controls.Add(this.rbtn_window2_open);
            this.window2Group.Location = new System.Drawing.Point(21, 854);
            this.window2Group.Name = "window2Group";
            this.window2Group.Size = new System.Drawing.Size(75, 60);
            this.window2Group.TabIndex = 11;
            this.window2Group.TabStop = false;
            // 
            // rbtn_window2_closed
            // 
            this.rbtn_window2_closed.AutoSize = true;
            this.rbtn_window2_closed.Checked = true;
            this.rbtn_window2_closed.Location = new System.Drawing.Point(6, 34);
            this.rbtn_window2_closed.Name = "rbtn_window2_closed";
            this.rbtn_window2_closed.Size = new System.Drawing.Size(61, 19);
            this.rbtn_window2_closed.TabIndex = 1;
            this.rbtn_window2_closed.TabStop = true;
            this.rbtn_window2_closed.Text = "Closed";
            this.rbtn_window2_closed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_window2_closed.UseVisualStyleBackColor = true;
            // 
            // rbtn_window2_open
            // 
            this.rbtn_window2_open.AutoSize = true;
            this.rbtn_window2_open.Location = new System.Drawing.Point(6, 15);
            this.rbtn_window2_open.Name = "rbtn_window2_open";
            this.rbtn_window2_open.Size = new System.Drawing.Size(54, 19);
            this.rbtn_window2_open.TabIndex = 0;
            this.rbtn_window2_open.Text = "Open";
            this.rbtn_window2_open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_window2_open.UseVisualStyleBackColor = true;
            // 
            // window3Group
            // 
            this.window3Group.BackColor = System.Drawing.Color.White;
            this.window3Group.Controls.Add(this.rbtn_window3_closed);
            this.window3Group.Controls.Add(this.rbtn_window3_open);
            this.window3Group.Location = new System.Drawing.Point(435, 753);
            this.window3Group.Name = "window3Group";
            this.window3Group.Size = new System.Drawing.Size(75, 60);
            this.window3Group.TabIndex = 12;
            this.window3Group.TabStop = false;
            // 
            // rbtn_window3_closed
            // 
            this.rbtn_window3_closed.AutoSize = true;
            this.rbtn_window3_closed.Checked = true;
            this.rbtn_window3_closed.Location = new System.Drawing.Point(6, 34);
            this.rbtn_window3_closed.Name = "rbtn_window3_closed";
            this.rbtn_window3_closed.Size = new System.Drawing.Size(61, 19);
            this.rbtn_window3_closed.TabIndex = 1;
            this.rbtn_window3_closed.TabStop = true;
            this.rbtn_window3_closed.Text = "Closed";
            this.rbtn_window3_closed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_window3_closed.UseVisualStyleBackColor = true;
            // 
            // rbtn_window3_open
            // 
            this.rbtn_window3_open.AutoSize = true;
            this.rbtn_window3_open.Location = new System.Drawing.Point(6, 15);
            this.rbtn_window3_open.Name = "rbtn_window3_open";
            this.rbtn_window3_open.Size = new System.Drawing.Size(54, 19);
            this.rbtn_window3_open.TabIndex = 0;
            this.rbtn_window3_open.Text = "Open";
            this.rbtn_window3_open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_window3_open.UseVisualStyleBackColor = true;
            // 
            // window4Group
            // 
            this.window4Group.BackColor = System.Drawing.Color.White;
            this.window4Group.Controls.Add(this.rbtn_window4_closed);
            this.window4Group.Controls.Add(this.rbtn_window4_open);
            this.window4Group.Location = new System.Drawing.Point(435, 854);
            this.window4Group.Name = "window4Group";
            this.window4Group.Size = new System.Drawing.Size(75, 60);
            this.window4Group.TabIndex = 13;
            this.window4Group.TabStop = false;
            // 
            // rbtn_window4_closed
            // 
            this.rbtn_window4_closed.AutoSize = true;
            this.rbtn_window4_closed.Checked = true;
            this.rbtn_window4_closed.Location = new System.Drawing.Point(6, 34);
            this.rbtn_window4_closed.Name = "rbtn_window4_closed";
            this.rbtn_window4_closed.Size = new System.Drawing.Size(61, 19);
            this.rbtn_window4_closed.TabIndex = 1;
            this.rbtn_window4_closed.TabStop = true;
            this.rbtn_window4_closed.Text = "Closed";
            this.rbtn_window4_closed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_window4_closed.UseVisualStyleBackColor = true;
            // 
            // rbtn_window4_open
            // 
            this.rbtn_window4_open.AutoSize = true;
            this.rbtn_window4_open.Location = new System.Drawing.Point(6, 15);
            this.rbtn_window4_open.Name = "rbtn_window4_open";
            this.rbtn_window4_open.Size = new System.Drawing.Size(54, 19);
            this.rbtn_window4_open.TabIndex = 0;
            this.rbtn_window4_open.Text = "Open";
            this.rbtn_window4_open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_window4_open.UseVisualStyleBackColor = true;
            // 
            // window5Group
            // 
            this.window5Group.BackColor = System.Drawing.Color.White;
            this.window5Group.Controls.Add(this.rbtn_window5_closed);
            this.window5Group.Controls.Add(this.rbtn_window5_open);
            this.window5Group.Location = new System.Drawing.Point(221, 838);
            this.window5Group.Name = "window5Group";
            this.window5Group.Size = new System.Drawing.Size(75, 60);
            this.window5Group.TabIndex = 14;
            this.window5Group.TabStop = false;
            // 
            // rbtn_window5_closed
            // 
            this.rbtn_window5_closed.AutoSize = true;
            this.rbtn_window5_closed.Checked = true;
            this.rbtn_window5_closed.Location = new System.Drawing.Point(6, 34);
            this.rbtn_window5_closed.Name = "rbtn_window5_closed";
            this.rbtn_window5_closed.Size = new System.Drawing.Size(61, 19);
            this.rbtn_window5_closed.TabIndex = 1;
            this.rbtn_window5_closed.TabStop = true;
            this.rbtn_window5_closed.Text = "Closed";
            this.rbtn_window5_closed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_window5_closed.UseVisualStyleBackColor = true;
            // 
            // rbtn_window5_open
            // 
            this.rbtn_window5_open.AutoSize = true;
            this.rbtn_window5_open.Location = new System.Drawing.Point(6, 15);
            this.rbtn_window5_open.Name = "rbtn_window5_open";
            this.rbtn_window5_open.Size = new System.Drawing.Size(54, 19);
            this.rbtn_window5_open.TabIndex = 0;
            this.rbtn_window5_open.Text = "Open";
            this.rbtn_window5_open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_window5_open.UseVisualStyleBackColor = true;
            // 
            // control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 1102);
            this.Controls.Add(this.window5Group);
            this.Controls.Add(this.window4Group);
            this.Controls.Add(this.window3Group);
            this.Controls.Add(this.window2Group);
            this.Controls.Add(this.window1Group);
            this.Controls.Add(this.btn_diableVehicle);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(538, 1141);
            this.MinimumSize = new System.Drawing.Size(538, 1141);
            this.Name = "control";
            this.Text = "control";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.window1Group.ResumeLayout(false);
            this.window1Group.PerformLayout();
            this.window2Group.ResumeLayout(false);
            this.window2Group.PerformLayout();
            this.window3Group.ResumeLayout(false);
            this.window3Group.PerformLayout();
            this.window4Group.ResumeLayout(false);
            this.window4Group.PerformLayout();
            this.window5Group.ResumeLayout(false);
            this.window5Group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_back;
        private Button btn_diableVehicle;
        private GroupBox window1Group;
        private RadioButton rbtn_window1_closed;
        private RadioButton rbtn_window1_open;
        private GroupBox window2Group;
        private RadioButton rbtn_window2_closed;
        private RadioButton rbtn_window2_open;
        private GroupBox window3Group;
        private RadioButton rbtn_window3_closed;
        private RadioButton rbtn_window3_open;
        private GroupBox window4Group;
        private RadioButton rbtn_window4_closed;
        private RadioButton rbtn_window4_open;
        private GroupBox window5Group;
        private RadioButton rbtn_window5_closed;
        private RadioButton rbtn_window5_open;
    }
}