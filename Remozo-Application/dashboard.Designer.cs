namespace Remozo_Application
{
    partial class dashboard
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
            this.btn_locateExpand = new System.Windows.Forms.Button();
            this.btn_controlExpand = new System.Windows.Forms.Button();
            this.btn_maintainExpand = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_changeVehicle = new System.Windows.Forms.Button();
            this.btn_addVehicle = new System.Windows.Forms.Button();
            this.pb_off = new System.Windows.Forms.PictureBox();
            this.pb_armed = new System.Windows.Forms.PictureBox();
            this.pb_locked = new System.Windows.Forms.PictureBox();
            this.pb_started = new System.Windows.Forms.PictureBox();
            this.pb_disarmed = new System.Windows.Forms.PictureBox();
            this.pb_unlocked = new System.Windows.Forms.PictureBox();
            this.lbl_on = new System.Windows.Forms.Label();
            this.lbl_off = new System.Windows.Forms.Label();
            this.lbl_armed = new System.Windows.Forms.Label();
            this.lbl_disarmed = new System.Windows.Forms.Label();
            this.lbl_locked = new System.Windows.Forms.Label();
            this.lbl_unlocked = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_armed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_locked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_started)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_disarmed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_unlocked)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.App___Dashboard__No_Control_;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(523, 1141);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(523, 1141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 1141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_locateExpand
            // 
            this.btn_locateExpand.BackColor = System.Drawing.Color.White;
            this.btn_locateExpand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_locateExpand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_locateExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_locateExpand.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_locateExpand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_locateExpand.Location = new System.Drawing.Point(364, 374);
            this.btn_locateExpand.Name = "btn_locateExpand";
            this.btn_locateExpand.Size = new System.Drawing.Size(102, 35);
            this.btn_locateExpand.TabIndex = 1;
            this.btn_locateExpand.Text = "expand";
            this.btn_locateExpand.UseVisualStyleBackColor = false;
            this.btn_locateExpand.Click += new System.EventHandler(this.btn_locateExpand_Click);
            // 
            // btn_controlExpand
            // 
            this.btn_controlExpand.BackColor = System.Drawing.Color.White;
            this.btn_controlExpand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_controlExpand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_controlExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_controlExpand.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_controlExpand.Location = new System.Drawing.Point(364, 639);
            this.btn_controlExpand.Name = "btn_controlExpand";
            this.btn_controlExpand.Size = new System.Drawing.Size(102, 35);
            this.btn_controlExpand.TabIndex = 2;
            this.btn_controlExpand.Text = "expand";
            this.btn_controlExpand.UseVisualStyleBackColor = false;
            this.btn_controlExpand.Click += new System.EventHandler(this.btn_controlExpand_Click);
            // 
            // btn_maintainExpand
            // 
            this.btn_maintainExpand.BackColor = System.Drawing.Color.White;
            this.btn_maintainExpand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_maintainExpand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_maintainExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maintainExpand.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_maintainExpand.Location = new System.Drawing.Point(370, 914);
            this.btn_maintainExpand.Name = "btn_maintainExpand";
            this.btn_maintainExpand.Size = new System.Drawing.Size(96, 35);
            this.btn_maintainExpand.TabIndex = 3;
            this.btn_maintainExpand.Text = "expand";
            this.btn_maintainExpand.UseVisualStyleBackColor = false;
            this.btn_maintainExpand.Click += new System.EventHandler(this.btn_maintainExpand_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.White;
            this.btn_settings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_settings.Location = new System.Drawing.Point(402, 149);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(122, 40);
            this.btn_settings.TabIndex = 4;
            this.btn_settings.Text = "settings";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_changeVehicle
            // 
            this.btn_changeVehicle.BackColor = System.Drawing.Color.White;
            this.btn_changeVehicle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_changeVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changeVehicle.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_changeVehicle.Location = new System.Drawing.Point(178, 149);
            this.btn_changeVehicle.Name = "btn_changeVehicle";
            this.btn_changeVehicle.Size = new System.Drawing.Size(198, 40);
            this.btn_changeVehicle.TabIndex = 5;
            this.btn_changeVehicle.Text = "change vehicle";
            this.btn_changeVehicle.UseVisualStyleBackColor = false;
            this.btn_changeVehicle.Click += new System.EventHandler(this.btn_changeVehicle_Click);
            // 
            // btn_addVehicle
            // 
            this.btn_addVehicle.BackColor = System.Drawing.Color.White;
            this.btn_addVehicle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addVehicle.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_addVehicle.Location = new System.Drawing.Point(1, 149);
            this.btn_addVehicle.Name = "btn_addVehicle";
            this.btn_addVehicle.Size = new System.Drawing.Size(171, 40);
            this.btn_addVehicle.TabIndex = 6;
            this.btn_addVehicle.Text = "add vehicle";
            this.btn_addVehicle.UseVisualStyleBackColor = false;
            this.btn_addVehicle.Click += new System.EventHandler(this.btn_addVehicle_Click);
            // 
            // pb_off
            // 
            this.pb_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pb_off.Image = global::Remozo_Application.Properties.Resources.poweredOff;
            this.pb_off.Location = new System.Drawing.Point(364, 712);
            this.pb_off.Name = "pb_off";
            this.pb_off.Size = new System.Drawing.Size(104, 107);
            this.pb_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_off.TabIndex = 36;
            this.pb_off.TabStop = false;
            this.pb_off.Click += new System.EventHandler(this.pb_off_Click);
            // 
            // pb_armed
            // 
            this.pb_armed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pb_armed.Image = global::Remozo_Application.Properties.Resources.armed;
            this.pb_armed.Location = new System.Drawing.Point(206, 712);
            this.pb_armed.Name = "pb_armed";
            this.pb_armed.Size = new System.Drawing.Size(104, 107);
            this.pb_armed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_armed.TabIndex = 35;
            this.pb_armed.TabStop = false;
            this.pb_armed.Click += new System.EventHandler(this.pb_armed_Click);
            // 
            // pb_locked
            // 
            this.pb_locked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pb_locked.Image = global::Remozo_Application.Properties.Resources.locked;
            this.pb_locked.Location = new System.Drawing.Point(57, 712);
            this.pb_locked.Name = "pb_locked";
            this.pb_locked.Size = new System.Drawing.Size(104, 107);
            this.pb_locked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_locked.TabIndex = 34;
            this.pb_locked.TabStop = false;
            this.pb_locked.Click += new System.EventHandler(this.pb_locked_Click);
            // 
            // pb_started
            // 
            this.pb_started.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pb_started.Image = global::Remozo_Application.Properties.Resources.poweredOn;
            this.pb_started.Location = new System.Drawing.Point(364, 712);
            this.pb_started.Name = "pb_started";
            this.pb_started.Size = new System.Drawing.Size(104, 107);
            this.pb_started.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_started.TabIndex = 33;
            this.pb_started.TabStop = false;
            this.pb_started.Click += new System.EventHandler(this.pb_started_Click);
            // 
            // pb_disarmed
            // 
            this.pb_disarmed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pb_disarmed.Image = global::Remozo_Application.Properties.Resources.disarmed;
            this.pb_disarmed.Location = new System.Drawing.Point(206, 712);
            this.pb_disarmed.Name = "pb_disarmed";
            this.pb_disarmed.Size = new System.Drawing.Size(104, 107);
            this.pb_disarmed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_disarmed.TabIndex = 32;
            this.pb_disarmed.TabStop = false;
            this.pb_disarmed.Click += new System.EventHandler(this.pb_disarmed_Click);
            // 
            // pb_unlocked
            // 
            this.pb_unlocked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pb_unlocked.Image = global::Remozo_Application.Properties.Resources.unlocked;
            this.pb_unlocked.Location = new System.Drawing.Point(57, 712);
            this.pb_unlocked.Name = "pb_unlocked";
            this.pb_unlocked.Size = new System.Drawing.Size(104, 107);
            this.pb_unlocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_unlocked.TabIndex = 31;
            this.pb_unlocked.TabStop = false;
            this.pb_unlocked.Click += new System.EventHandler(this.pb_unlocked_Click);
            // 
            // lbl_on
            // 
            this.lbl_on.AutoSize = true;
            this.lbl_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbl_on.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_on.Location = new System.Drawing.Point(397, 822);
            this.lbl_on.Name = "lbl_on";
            this.lbl_on.Size = new System.Drawing.Size(38, 25);
            this.lbl_on.TabIndex = 42;
            this.lbl_on.Text = "On";
            // 
            // lbl_off
            // 
            this.lbl_off.AutoSize = true;
            this.lbl_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbl_off.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_off.Location = new System.Drawing.Point(395, 822);
            this.lbl_off.Name = "lbl_off";
            this.lbl_off.Size = new System.Drawing.Size(40, 25);
            this.lbl_off.TabIndex = 39;
            this.lbl_off.Text = "Off";
            this.lbl_off.Visible = false;
            // 
            // lbl_armed
            // 
            this.lbl_armed.AutoSize = true;
            this.lbl_armed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbl_armed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_armed.Location = new System.Drawing.Point(222, 822);
            this.lbl_armed.Name = "lbl_armed";
            this.lbl_armed.Size = new System.Drawing.Size(72, 25);
            this.lbl_armed.TabIndex = 38;
            this.lbl_armed.Text = "Armed";
            // 
            // lbl_disarmed
            // 
            this.lbl_disarmed.AutoSize = true;
            this.lbl_disarmed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbl_disarmed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_disarmed.Location = new System.Drawing.Point(210, 822);
            this.lbl_disarmed.Name = "lbl_disarmed";
            this.lbl_disarmed.Size = new System.Drawing.Size(96, 25);
            this.lbl_disarmed.TabIndex = 41;
            this.lbl_disarmed.Text = "Disarmed";
            this.lbl_disarmed.Visible = false;
            // 
            // lbl_locked
            // 
            this.lbl_locked.AutoSize = true;
            this.lbl_locked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbl_locked.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_locked.Location = new System.Drawing.Point(74, 822);
            this.lbl_locked.Name = "lbl_locked";
            this.lbl_locked.Size = new System.Drawing.Size(76, 25);
            this.lbl_locked.TabIndex = 37;
            this.lbl_locked.Text = "Locked";
            // 
            // lbl_unlocked
            // 
            this.lbl_unlocked.AutoSize = true;
            this.lbl_unlocked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbl_unlocked.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_unlocked.Location = new System.Drawing.Point(64, 822);
            this.lbl_unlocked.Name = "lbl_unlocked";
            this.lbl_unlocked.Size = new System.Drawing.Size(97, 25);
            this.lbl_unlocked.TabIndex = 40;
            this.lbl_unlocked.Text = "Unlocked";
            this.lbl_unlocked.Visible = false;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 1141);
            this.Controls.Add(this.lbl_on);
            this.Controls.Add(this.lbl_off);
            this.Controls.Add(this.lbl_armed);
            this.Controls.Add(this.lbl_disarmed);
            this.Controls.Add(this.lbl_locked);
            this.Controls.Add(this.lbl_unlocked);
            this.Controls.Add(this.pb_off);
            this.Controls.Add(this.pb_armed);
            this.Controls.Add(this.pb_locked);
            this.Controls.Add(this.pb_started);
            this.Controls.Add(this.pb_disarmed);
            this.Controls.Add(this.pb_unlocked);
            this.Controls.Add(this.btn_addVehicle);
            this.Controls.Add(this.btn_changeVehicle);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_maintainExpand);
            this.Controls.Add(this.btn_controlExpand);
            this.Controls.Add(this.btn_locateExpand);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(540, 1180);
            this.MinimumSize = new System.Drawing.Size(540, 1180);
            this.Name = "dashboard";
            this.Text = "Remoso - Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_armed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_locked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_started)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_disarmed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_unlocked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_locateExpand;
        private Button btn_controlExpand;
        private Button btn_maintainExpand;
        private Button btn_settings;
        private Button btn_changeVehicle;
        private Button btn_addVehicle;
        private PictureBox pb_off;
        private PictureBox pb_armed;
        private PictureBox pb_locked;
        private PictureBox pb_started;
        private PictureBox pb_disarmed;
        private PictureBox pb_unlocked;
        private Label lbl_on;
        private Label lbl_off;
        private Label lbl_armed;
        private Label lbl_disarmed;
        private Label lbl_locked;
        private Label lbl_unlocked;
    }
}