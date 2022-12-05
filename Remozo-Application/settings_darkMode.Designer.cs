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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.dark_settings;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 1101);
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
            // settings_darkMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 1102);
            this.Controls.Add(this.txt_userList);
            this.Controls.Add(this.txt_geoFence);
            this.Controls.Add(this.btn_checkUpdates);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(523, 1141);
            this.MinimumSize = new System.Drawing.Size(523, 1141);
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
    }
}