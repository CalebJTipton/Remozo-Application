﻿namespace Remozo_Application
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
            this.txt_geofence = new System.Windows.Forms.TextBox();
            this.txt_userList = new System.Windows.Forms.TextBox();
            this.vibrationGroup = new System.Windows.Forms.GroupBox();
            this.rbtn_vibration_disabled = new System.Windows.Forms.RadioButton();
            this.rbtn_vibration_enabled = new System.Windows.Forms.RadioButton();
            this.colorblindGroup = new System.Windows.Forms.GroupBox();
            this.rbtn_colorblind_disabled = new System.Windows.Forms.RadioButton();
            this.rbtn_colorblind_enabled = new System.Windows.Forms.RadioButton();
            this.contrastGroup = new System.Windows.Forms.GroupBox();
            this.rbtn_contrast_disabled = new System.Windows.Forms.RadioButton();
            this.rbtn_contrast_enabled = new System.Windows.Forms.RadioButton();
            this.geofenceAlertGroup = new System.Windows.Forms.GroupBox();
            this.rbtn_geofence_disabled = new System.Windows.Forms.RadioButton();
            this.rbtn_geofence_enabled = new System.Windows.Forms.RadioButton();
            this.maintenanceAlertGroup = new System.Windows.Forms.GroupBox();
            this.rbtn_maintenance_disabled = new System.Windows.Forms.RadioButton();
            this.rbtn_maintenance_enabled = new System.Windows.Forms.RadioButton();
            this.darkModeGroup = new System.Windows.Forms.GroupBox();
            this.rbtn_darkMode_disabled = new System.Windows.Forms.RadioButton();
            this.rbtn_darkMode_enabled = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.vibrationGroup.SuspendLayout();
            this.colorblindGroup.SuspendLayout();
            this.contrastGroup.SuspendLayout();
            this.geofenceAlertGroup.SuspendLayout();
            this.maintenanceAlertGroup.SuspendLayout();
            this.darkModeGroup.SuspendLayout();
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Black;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(44, 154);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 38);
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
            this.btn_checkUpdates.Click += new System.EventHandler(this.btn_checkUpdates_Click);
            // 
            // txt_geofence
            // 
            this.txt_geofence.Location = new System.Drawing.Point(32, 572);
            this.txt_geofence.Name = "txt_geofence";
            this.txt_geofence.Size = new System.Drawing.Size(394, 23);
            this.txt_geofence.TabIndex = 3;
            // 
            // txt_userList
            // 
            this.txt_userList.Location = new System.Drawing.Point(32, 955);
            this.txt_userList.Name = "txt_userList";
            this.txt_userList.Size = new System.Drawing.Size(394, 23);
            this.txt_userList.TabIndex = 4;
            // 
            // vibrationGroup
            // 
            this.vibrationGroup.BackColor = System.Drawing.Color.Black;
            this.vibrationGroup.Controls.Add(this.rbtn_vibration_disabled);
            this.vibrationGroup.Controls.Add(this.rbtn_vibration_enabled);
            this.vibrationGroup.ForeColor = System.Drawing.Color.White;
            this.vibrationGroup.Location = new System.Drawing.Point(424, 813);
            this.vibrationGroup.Name = "vibrationGroup";
            this.vibrationGroup.Size = new System.Drawing.Size(92, 60);
            this.vibrationGroup.TabIndex = 19;
            this.vibrationGroup.TabStop = false;
            // 
            // rbtn_vibration_disabled
            // 
            this.rbtn_vibration_disabled.AutoSize = true;
            this.rbtn_vibration_disabled.Checked = true;
            this.rbtn_vibration_disabled.Location = new System.Drawing.Point(6, 34);
            this.rbtn_vibration_disabled.Name = "rbtn_vibration_disabled";
            this.rbtn_vibration_disabled.Size = new System.Drawing.Size(70, 19);
            this.rbtn_vibration_disabled.TabIndex = 1;
            this.rbtn_vibration_disabled.TabStop = true;
            this.rbtn_vibration_disabled.Text = "Disabled";
            this.rbtn_vibration_disabled.UseVisualStyleBackColor = true;
            // 
            // rbtn_vibration_enabled
            // 
            this.rbtn_vibration_enabled.AutoSize = true;
            this.rbtn_vibration_enabled.Location = new System.Drawing.Point(6, 15);
            this.rbtn_vibration_enabled.Name = "rbtn_vibration_enabled";
            this.rbtn_vibration_enabled.Size = new System.Drawing.Size(67, 19);
            this.rbtn_vibration_enabled.TabIndex = 0;
            this.rbtn_vibration_enabled.Text = "Enabled";
            this.rbtn_vibration_enabled.UseVisualStyleBackColor = true;
            // 
            // colorblindGroup
            // 
            this.colorblindGroup.BackColor = System.Drawing.Color.Black;
            this.colorblindGroup.Controls.Add(this.rbtn_colorblind_disabled);
            this.colorblindGroup.Controls.Add(this.rbtn_colorblind_enabled);
            this.colorblindGroup.ForeColor = System.Drawing.Color.White;
            this.colorblindGroup.Location = new System.Drawing.Point(424, 738);
            this.colorblindGroup.Name = "colorblindGroup";
            this.colorblindGroup.Size = new System.Drawing.Size(92, 60);
            this.colorblindGroup.TabIndex = 18;
            this.colorblindGroup.TabStop = false;
            // 
            // rbtn_colorblind_disabled
            // 
            this.rbtn_colorblind_disabled.AutoSize = true;
            this.rbtn_colorblind_disabled.Checked = true;
            this.rbtn_colorblind_disabled.Location = new System.Drawing.Point(6, 34);
            this.rbtn_colorblind_disabled.Name = "rbtn_colorblind_disabled";
            this.rbtn_colorblind_disabled.Size = new System.Drawing.Size(70, 19);
            this.rbtn_colorblind_disabled.TabIndex = 1;
            this.rbtn_colorblind_disabled.TabStop = true;
            this.rbtn_colorblind_disabled.Text = "Disabled";
            this.rbtn_colorblind_disabled.UseVisualStyleBackColor = true;
            // 
            // rbtn_colorblind_enabled
            // 
            this.rbtn_colorblind_enabled.AutoSize = true;
            this.rbtn_colorblind_enabled.Location = new System.Drawing.Point(6, 15);
            this.rbtn_colorblind_enabled.Name = "rbtn_colorblind_enabled";
            this.rbtn_colorblind_enabled.Size = new System.Drawing.Size(67, 19);
            this.rbtn_colorblind_enabled.TabIndex = 0;
            this.rbtn_colorblind_enabled.Text = "Enabled";
            this.rbtn_colorblind_enabled.UseVisualStyleBackColor = true;
            // 
            // contrastGroup
            // 
            this.contrastGroup.BackColor = System.Drawing.Color.Black;
            this.contrastGroup.Controls.Add(this.rbtn_contrast_disabled);
            this.contrastGroup.Controls.Add(this.rbtn_contrast_enabled);
            this.contrastGroup.ForeColor = System.Drawing.Color.White;
            this.contrastGroup.Location = new System.Drawing.Point(424, 663);
            this.contrastGroup.Name = "contrastGroup";
            this.contrastGroup.Size = new System.Drawing.Size(92, 60);
            this.contrastGroup.TabIndex = 15;
            this.contrastGroup.TabStop = false;
            // 
            // rbtn_contrast_disabled
            // 
            this.rbtn_contrast_disabled.AutoSize = true;
            this.rbtn_contrast_disabled.Checked = true;
            this.rbtn_contrast_disabled.Location = new System.Drawing.Point(6, 34);
            this.rbtn_contrast_disabled.Name = "rbtn_contrast_disabled";
            this.rbtn_contrast_disabled.Size = new System.Drawing.Size(70, 19);
            this.rbtn_contrast_disabled.TabIndex = 1;
            this.rbtn_contrast_disabled.TabStop = true;
            this.rbtn_contrast_disabled.Text = "Disabled";
            this.rbtn_contrast_disabled.UseVisualStyleBackColor = true;
            // 
            // rbtn_contrast_enabled
            // 
            this.rbtn_contrast_enabled.AutoSize = true;
            this.rbtn_contrast_enabled.Location = new System.Drawing.Point(6, 15);
            this.rbtn_contrast_enabled.Name = "rbtn_contrast_enabled";
            this.rbtn_contrast_enabled.Size = new System.Drawing.Size(67, 19);
            this.rbtn_contrast_enabled.TabIndex = 0;
            this.rbtn_contrast_enabled.Text = "Enabled";
            this.rbtn_contrast_enabled.UseVisualStyleBackColor = true;
            // 
            // geofenceAlertGroup
            // 
            this.geofenceAlertGroup.BackColor = System.Drawing.Color.Black;
            this.geofenceAlertGroup.Controls.Add(this.rbtn_geofence_disabled);
            this.geofenceAlertGroup.Controls.Add(this.rbtn_geofence_enabled);
            this.geofenceAlertGroup.ForeColor = System.Drawing.Color.White;
            this.geofenceAlertGroup.Location = new System.Drawing.Point(418, 472);
            this.geofenceAlertGroup.Name = "geofenceAlertGroup";
            this.geofenceAlertGroup.Size = new System.Drawing.Size(92, 60);
            this.geofenceAlertGroup.TabIndex = 17;
            this.geofenceAlertGroup.TabStop = false;
            // 
            // rbtn_geofence_disabled
            // 
            this.rbtn_geofence_disabled.AutoSize = true;
            this.rbtn_geofence_disabled.Checked = true;
            this.rbtn_geofence_disabled.Location = new System.Drawing.Point(6, 34);
            this.rbtn_geofence_disabled.Name = "rbtn_geofence_disabled";
            this.rbtn_geofence_disabled.Size = new System.Drawing.Size(70, 19);
            this.rbtn_geofence_disabled.TabIndex = 1;
            this.rbtn_geofence_disabled.TabStop = true;
            this.rbtn_geofence_disabled.Text = "Disabled";
            this.rbtn_geofence_disabled.UseVisualStyleBackColor = true;
            // 
            // rbtn_geofence_enabled
            // 
            this.rbtn_geofence_enabled.AutoSize = true;
            this.rbtn_geofence_enabled.Location = new System.Drawing.Point(6, 15);
            this.rbtn_geofence_enabled.Name = "rbtn_geofence_enabled";
            this.rbtn_geofence_enabled.Size = new System.Drawing.Size(67, 19);
            this.rbtn_geofence_enabled.TabIndex = 0;
            this.rbtn_geofence_enabled.Text = "Enabled";
            this.rbtn_geofence_enabled.UseVisualStyleBackColor = true;
            this.rbtn_geofence_enabled.CheckedChanged += new System.EventHandler(this.rbtn_geofence_enabled_CheckedChanged);
            // 
            // maintenanceAlertGroup
            // 
            this.maintenanceAlertGroup.BackColor = System.Drawing.Color.Black;
            this.maintenanceAlertGroup.Controls.Add(this.rbtn_maintenance_disabled);
            this.maintenanceAlertGroup.Controls.Add(this.rbtn_maintenance_enabled);
            this.maintenanceAlertGroup.ForeColor = System.Drawing.Color.White;
            this.maintenanceAlertGroup.Location = new System.Drawing.Point(418, 397);
            this.maintenanceAlertGroup.Name = "maintenanceAlertGroup";
            this.maintenanceAlertGroup.Size = new System.Drawing.Size(92, 60);
            this.maintenanceAlertGroup.TabIndex = 16;
            this.maintenanceAlertGroup.TabStop = false;
            // 
            // rbtn_maintenance_disabled
            // 
            this.rbtn_maintenance_disabled.AutoSize = true;
            this.rbtn_maintenance_disabled.Checked = true;
            this.rbtn_maintenance_disabled.Location = new System.Drawing.Point(6, 34);
            this.rbtn_maintenance_disabled.Name = "rbtn_maintenance_disabled";
            this.rbtn_maintenance_disabled.Size = new System.Drawing.Size(70, 19);
            this.rbtn_maintenance_disabled.TabIndex = 1;
            this.rbtn_maintenance_disabled.TabStop = true;
            this.rbtn_maintenance_disabled.Text = "Disabled";
            this.rbtn_maintenance_disabled.UseVisualStyleBackColor = true;
            // 
            // rbtn_maintenance_enabled
            // 
            this.rbtn_maintenance_enabled.AutoSize = true;
            this.rbtn_maintenance_enabled.Location = new System.Drawing.Point(6, 15);
            this.rbtn_maintenance_enabled.Name = "rbtn_maintenance_enabled";
            this.rbtn_maintenance_enabled.Size = new System.Drawing.Size(67, 19);
            this.rbtn_maintenance_enabled.TabIndex = 0;
            this.rbtn_maintenance_enabled.Text = "Enabled";
            this.rbtn_maintenance_enabled.UseVisualStyleBackColor = true;
            // 
            // darkModeGroup
            // 
            this.darkModeGroup.BackColor = System.Drawing.Color.Black;
            this.darkModeGroup.Controls.Add(this.rbtn_darkMode_disabled);
            this.darkModeGroup.Controls.Add(this.rbtn_darkMode_enabled);
            this.darkModeGroup.ForeColor = System.Drawing.Color.White;
            this.darkModeGroup.Location = new System.Drawing.Point(418, 321);
            this.darkModeGroup.Name = "darkModeGroup";
            this.darkModeGroup.Size = new System.Drawing.Size(92, 60);
            this.darkModeGroup.TabIndex = 14;
            this.darkModeGroup.TabStop = false;
            // 
            // rbtn_darkMode_disabled
            // 
            this.rbtn_darkMode_disabled.AutoSize = true;
            this.rbtn_darkMode_disabled.Location = new System.Drawing.Point(6, 34);
            this.rbtn_darkMode_disabled.Name = "rbtn_darkMode_disabled";
            this.rbtn_darkMode_disabled.Size = new System.Drawing.Size(70, 19);
            this.rbtn_darkMode_disabled.TabIndex = 1;
            this.rbtn_darkMode_disabled.Text = "Disabled";
            this.rbtn_darkMode_disabled.UseVisualStyleBackColor = true;
            this.rbtn_darkMode_disabled.CheckedChanged += new System.EventHandler(this.rbtn_darkMode_disabled_CheckedChanged);
            // 
            // rbtn_darkMode_enabled
            // 
            this.rbtn_darkMode_enabled.AutoSize = true;
            this.rbtn_darkMode_enabled.Checked = true;
            this.rbtn_darkMode_enabled.Location = new System.Drawing.Point(6, 15);
            this.rbtn_darkMode_enabled.Name = "rbtn_darkMode_enabled";
            this.rbtn_darkMode_enabled.Size = new System.Drawing.Size(67, 19);
            this.rbtn_darkMode_enabled.TabIndex = 0;
            this.rbtn_darkMode_enabled.TabStop = true;
            this.rbtn_darkMode_enabled.Text = "Enabled";
            this.rbtn_darkMode_enabled.UseVisualStyleBackColor = true;
            this.rbtn_darkMode_enabled.CheckedChanged += new System.EventHandler(this.rbtn_darkMode_enabled_CheckedChanged);
            // 
            // settings_darkMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 1102);
            this.Controls.Add(this.vibrationGroup);
            this.Controls.Add(this.colorblindGroup);
            this.Controls.Add(this.contrastGroup);
            this.Controls.Add(this.geofenceAlertGroup);
            this.Controls.Add(this.maintenanceAlertGroup);
            this.Controls.Add(this.darkModeGroup);
            this.Controls.Add(this.txt_userList);
            this.Controls.Add(this.txt_geofence);
            this.Controls.Add(this.btn_checkUpdates);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(538, 1141);
            this.MinimumSize = new System.Drawing.Size(538, 1141);
            this.Name = "settings_darkMode";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.vibrationGroup.ResumeLayout(false);
            this.vibrationGroup.PerformLayout();
            this.colorblindGroup.ResumeLayout(false);
            this.colorblindGroup.PerformLayout();
            this.contrastGroup.ResumeLayout(false);
            this.contrastGroup.PerformLayout();
            this.geofenceAlertGroup.ResumeLayout(false);
            this.geofenceAlertGroup.PerformLayout();
            this.maintenanceAlertGroup.ResumeLayout(false);
            this.maintenanceAlertGroup.PerformLayout();
            this.darkModeGroup.ResumeLayout(false);
            this.darkModeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_back;
        private Button btn_checkUpdates;
        private TextBox txt_geofence;
        private TextBox txt_userList;
        private GroupBox vibrationGroup;
        private RadioButton rbtn_vibration_disabled;
        private RadioButton rbtn_vibration_enabled;
        private GroupBox colorblindGroup;
        private RadioButton rbtn_colorblind_disabled;
        private RadioButton rbtn_colorblind_enabled;
        private GroupBox contrastGroup;
        private RadioButton rbtn_contrast_disabled;
        private RadioButton rbtn_contrast_enabled;
        private GroupBox geofenceAlertGroup;
        private RadioButton rbtn_geofence_disabled;
        private RadioButton rbtn_geofence_enabled;
        private GroupBox maintenanceAlertGroup;
        private RadioButton rbtn_maintenance_disabled;
        private RadioButton rbtn_maintenance_enabled;
        private GroupBox darkModeGroup;
        private RadioButton rbtn_darkMode_disabled;
        private RadioButton rbtn_darkMode_enabled;
    }
}