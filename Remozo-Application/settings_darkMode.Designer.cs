namespace Remozo_Application
{
    partial class settings_darkMode
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
            this.btn_checkUpdates = new System.Windows.Forms.Button();
            this.txt_geoFence = new System.Windows.Forms.TextBox();
            this.txt_userList = new System.Windows.Forms.TextBox();
            this.chk_darkModeDisabled = new System.Windows.Forms.CheckBox();
            this.chk_darkModeEnabled = new System.Windows.Forms.CheckBox();
            this.chk_vibrationDisabled = new System.Windows.Forms.CheckBox();
            this.chk_vibrationEnabled = new System.Windows.Forms.CheckBox();
            this.chk_colorblindDisabled = new System.Windows.Forms.CheckBox();
            this.chk_colorblindEnabled = new System.Windows.Forms.CheckBox();
            this.chk_increasedVisabilityDisabled = new System.Windows.Forms.CheckBox();
            this.chk_increasedVisabilityEnabled = new System.Windows.Forms.CheckBox();
            this.chk_geofenceAlertDisabled = new System.Windows.Forms.CheckBox();
            this.chk_geofenceAlertEnabled = new System.Windows.Forms.CheckBox();
            this.chk_maintenanceAlertDisabled = new System.Windows.Forms.CheckBox();
            this.chk_maintenanceAlertEnabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.dark_settings;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 1101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Black;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(44, 157);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 35);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_checkUpdates
            // 
            this.btn_checkUpdates.BackColor = System.Drawing.Color.Red;
            this.btn_checkUpdates.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_checkUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkUpdates.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_checkUpdates.ForeColor = System.Drawing.Color.White;
            this.btn_checkUpdates.Location = new System.Drawing.Point(68, 1057);
            this.btn_checkUpdates.Name = "btn_checkUpdates";
            this.btn_checkUpdates.Size = new System.Drawing.Size(397, 43);
            this.btn_checkUpdates.TabIndex = 2;
            this.btn_checkUpdates.Text = "Check for Updates";
            this.btn_checkUpdates.UseVisualStyleBackColor = false;
            // 
            // txt_geoFence
            // 
            this.txt_geoFence.Location = new System.Drawing.Point(32, 572);
            this.txt_geoFence.Name = "txt_geoFence";
            this.txt_geoFence.Size = new System.Drawing.Size(394, 23);
            this.txt_geoFence.TabIndex = 3;
            // 
            // txt_userList
            // 
            this.txt_userList.Location = new System.Drawing.Point(32, 955);
            this.txt_userList.Name = "txt_userList";
            this.txt_userList.Size = new System.Drawing.Size(394, 23);
            this.txt_userList.TabIndex = 4;
            // 
            // chk_darkModeDisabled
            // 
            this.chk_darkModeDisabled.AutoSize = true;
            this.chk_darkModeDisabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_darkModeDisabled.Location = new System.Drawing.Point(427, 359);
            this.chk_darkModeDisabled.Name = "chk_darkModeDisabled";
            this.chk_darkModeDisabled.Size = new System.Drawing.Size(77, 20);
            this.chk_darkModeDisabled.TabIndex = 12;
            this.chk_darkModeDisabled.Text = "Disabled";
            this.chk_darkModeDisabled.UseVisualStyleBackColor = true;
            // 
            // chk_darkModeEnabled
            // 
            this.chk_darkModeEnabled.AutoSize = true;
            this.chk_darkModeEnabled.Checked = true;
            this.chk_darkModeEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_darkModeEnabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_darkModeEnabled.Location = new System.Drawing.Point(427, 333);
            this.chk_darkModeEnabled.Name = "chk_darkModeEnabled";
            this.chk_darkModeEnabled.Size = new System.Drawing.Size(74, 20);
            this.chk_darkModeEnabled.TabIndex = 11;
            this.chk_darkModeEnabled.Text = "Enabled";
            this.chk_darkModeEnabled.UseVisualStyleBackColor = true;
            this.chk_darkModeEnabled.CheckedChanged += new System.EventHandler(this.chk_darkModeEnabled_CheckedChanged);
            // 
            // chk_vibrationDisabled
            // 
            this.chk_vibrationDisabled.AutoSize = true;
            this.chk_vibrationDisabled.Checked = true;
            this.chk_vibrationDisabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_vibrationDisabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_vibrationDisabled.Location = new System.Drawing.Point(427, 848);
            this.chk_vibrationDisabled.Name = "chk_vibrationDisabled";
            this.chk_vibrationDisabled.Size = new System.Drawing.Size(77, 20);
            this.chk_vibrationDisabled.TabIndex = 30;
            this.chk_vibrationDisabled.Text = "Disabled";
            this.chk_vibrationDisabled.UseVisualStyleBackColor = true;
            // 
            // chk_vibrationEnabled
            // 
            this.chk_vibrationEnabled.AutoSize = true;
            this.chk_vibrationEnabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_vibrationEnabled.Location = new System.Drawing.Point(427, 822);
            this.chk_vibrationEnabled.Name = "chk_vibrationEnabled";
            this.chk_vibrationEnabled.Size = new System.Drawing.Size(74, 20);
            this.chk_vibrationEnabled.TabIndex = 29;
            this.chk_vibrationEnabled.Text = "Enabled";
            this.chk_vibrationEnabled.UseVisualStyleBackColor = true;
            // 
            // chk_colorblindDisabled
            // 
            this.chk_colorblindDisabled.AutoSize = true;
            this.chk_colorblindDisabled.Checked = true;
            this.chk_colorblindDisabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_colorblindDisabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_colorblindDisabled.Location = new System.Drawing.Point(427, 773);
            this.chk_colorblindDisabled.Name = "chk_colorblindDisabled";
            this.chk_colorblindDisabled.Size = new System.Drawing.Size(77, 20);
            this.chk_colorblindDisabled.TabIndex = 28;
            this.chk_colorblindDisabled.Text = "Disabled";
            this.chk_colorblindDisabled.UseVisualStyleBackColor = true;
            // 
            // chk_colorblindEnabled
            // 
            this.chk_colorblindEnabled.AutoSize = true;
            this.chk_colorblindEnabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_colorblindEnabled.Location = new System.Drawing.Point(427, 747);
            this.chk_colorblindEnabled.Name = "chk_colorblindEnabled";
            this.chk_colorblindEnabled.Size = new System.Drawing.Size(74, 20);
            this.chk_colorblindEnabled.TabIndex = 27;
            this.chk_colorblindEnabled.Text = "Enabled";
            this.chk_colorblindEnabled.UseVisualStyleBackColor = true;
            // 
            // chk_increasedVisabilityDisabled
            // 
            this.chk_increasedVisabilityDisabled.AutoSize = true;
            this.chk_increasedVisabilityDisabled.Checked = true;
            this.chk_increasedVisabilityDisabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_increasedVisabilityDisabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_increasedVisabilityDisabled.Location = new System.Drawing.Point(427, 697);
            this.chk_increasedVisabilityDisabled.Name = "chk_increasedVisabilityDisabled";
            this.chk_increasedVisabilityDisabled.Size = new System.Drawing.Size(77, 20);
            this.chk_increasedVisabilityDisabled.TabIndex = 26;
            this.chk_increasedVisabilityDisabled.Text = "Disabled";
            this.chk_increasedVisabilityDisabled.UseVisualStyleBackColor = true;
            // 
            // chk_increasedVisabilityEnabled
            // 
            this.chk_increasedVisabilityEnabled.AutoSize = true;
            this.chk_increasedVisabilityEnabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_increasedVisabilityEnabled.Location = new System.Drawing.Point(427, 671);
            this.chk_increasedVisabilityEnabled.Name = "chk_increasedVisabilityEnabled";
            this.chk_increasedVisabilityEnabled.Size = new System.Drawing.Size(74, 20);
            this.chk_increasedVisabilityEnabled.TabIndex = 25;
            this.chk_increasedVisabilityEnabled.Text = "Enabled";
            this.chk_increasedVisabilityEnabled.UseVisualStyleBackColor = true;
            // 
            // chk_geofenceAlertDisabled
            // 
            this.chk_geofenceAlertDisabled.AutoSize = true;
            this.chk_geofenceAlertDisabled.Checked = true;
            this.chk_geofenceAlertDisabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_geofenceAlertDisabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_geofenceAlertDisabled.Location = new System.Drawing.Point(427, 506);
            this.chk_geofenceAlertDisabled.Name = "chk_geofenceAlertDisabled";
            this.chk_geofenceAlertDisabled.Size = new System.Drawing.Size(77, 20);
            this.chk_geofenceAlertDisabled.TabIndex = 24;
            this.chk_geofenceAlertDisabled.Text = "Disabled";
            this.chk_geofenceAlertDisabled.UseVisualStyleBackColor = true;
            // 
            // chk_geofenceAlertEnabled
            // 
            this.chk_geofenceAlertEnabled.AutoSize = true;
            this.chk_geofenceAlertEnabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_geofenceAlertEnabled.Location = new System.Drawing.Point(427, 480);
            this.chk_geofenceAlertEnabled.Name = "chk_geofenceAlertEnabled";
            this.chk_geofenceAlertEnabled.Size = new System.Drawing.Size(74, 20);
            this.chk_geofenceAlertEnabled.TabIndex = 23;
            this.chk_geofenceAlertEnabled.Text = "Enabled";
            this.chk_geofenceAlertEnabled.UseVisualStyleBackColor = true;
            // 
            // chk_maintenanceAlertDisabled
            // 
            this.chk_maintenanceAlertDisabled.AutoSize = true;
            this.chk_maintenanceAlertDisabled.Checked = true;
            this.chk_maintenanceAlertDisabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_maintenanceAlertDisabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_maintenanceAlertDisabled.Location = new System.Drawing.Point(427, 434);
            this.chk_maintenanceAlertDisabled.Name = "chk_maintenanceAlertDisabled";
            this.chk_maintenanceAlertDisabled.Size = new System.Drawing.Size(77, 20);
            this.chk_maintenanceAlertDisabled.TabIndex = 22;
            this.chk_maintenanceAlertDisabled.Text = "Disabled";
            this.chk_maintenanceAlertDisabled.UseVisualStyleBackColor = true;
            this.chk_maintenanceAlertDisabled.CheckedChanged += new System.EventHandler(this.chk_maintenanceAlertDisabled_CheckedChanged);
            // 
            // chk_maintenanceAlertEnabled
            // 
            this.chk_maintenanceAlertEnabled.AutoSize = true;
            this.chk_maintenanceAlertEnabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_maintenanceAlertEnabled.Location = new System.Drawing.Point(427, 408);
            this.chk_maintenanceAlertEnabled.Name = "chk_maintenanceAlertEnabled";
            this.chk_maintenanceAlertEnabled.Size = new System.Drawing.Size(74, 20);
            this.chk_maintenanceAlertEnabled.TabIndex = 21;
            this.chk_maintenanceAlertEnabled.Text = "Enabled";
            this.chk_maintenanceAlertEnabled.UseVisualStyleBackColor = true;
            // 
            // settings_darkMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 1102);
            this.Controls.Add(this.chk_vibrationDisabled);
            this.Controls.Add(this.chk_vibrationEnabled);
            this.Controls.Add(this.chk_colorblindDisabled);
            this.Controls.Add(this.chk_colorblindEnabled);
            this.Controls.Add(this.chk_increasedVisabilityDisabled);
            this.Controls.Add(this.chk_increasedVisabilityEnabled);
            this.Controls.Add(this.chk_geofenceAlertDisabled);
            this.Controls.Add(this.chk_geofenceAlertEnabled);
            this.Controls.Add(this.chk_maintenanceAlertDisabled);
            this.Controls.Add(this.chk_maintenanceAlertEnabled);
            this.Controls.Add(this.chk_darkModeDisabled);
            this.Controls.Add(this.chk_darkModeEnabled);
            this.Controls.Add(this.txt_userList);
            this.Controls.Add(this.txt_geoFence);
            this.Controls.Add(this.btn_checkUpdates);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(538, 1141);
            this.MinimumSize = new System.Drawing.Size(538, 1141);
            this.Name = "settings_darkMode";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_back;
        private Button btn_checkUpdates;
        private TextBox txt_geoFence;
        private TextBox txt_userList;
        private CheckBox chk_darkModeDisabled;
        private CheckBox chk_darkModeEnabled;
        private CheckBox chk_vibrationDisabled;
        private CheckBox chk_vibrationEnabled;
        private CheckBox chk_colorblindDisabled;
        private CheckBox chk_colorblindEnabled;
        private CheckBox chk_increasedVisabilityDisabled;
        private CheckBox chk_increasedVisabilityEnabled;
        private CheckBox chk_geofenceAlertDisabled;
        private CheckBox chk_geofenceAlertEnabled;
        private CheckBox chk_maintenanceAlertDisabled;
        private CheckBox chk_maintenanceAlertEnabled;
    }
}