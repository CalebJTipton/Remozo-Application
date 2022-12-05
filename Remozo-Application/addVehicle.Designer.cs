namespace Remozo_Application
{
    partial class addVehicle
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
            this.btn_addVehicle = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_vin = new System.Windows.Forms.TextBox();
            this.txt_deviceKey = new System.Windows.Forms.TextBox();
            this.txt_drivers = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.Add_Vehicle_back;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 1107);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_addVehicle
            // 
            this.btn_addVehicle.BackColor = System.Drawing.Color.Red;
            this.btn_addVehicle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addVehicle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addVehicle.ForeColor = System.Drawing.Color.White;
            this.btn_addVehicle.Location = new System.Drawing.Point(78, 1021);
            this.btn_addVehicle.Name = "btn_addVehicle";
            this.btn_addVehicle.Size = new System.Drawing.Size(347, 73);
            this.btn_addVehicle.TabIndex = 1;
            this.btn_addVehicle.Text = "Add Vehicle";
            this.btn_addVehicle.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(44, 153);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 35);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(38, 317);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(397, 23);
            this.txt_make.TabIndex = 3;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(38, 395);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(397, 23);
            this.txt_model.TabIndex = 4;
            // 
            // txt_vin
            // 
            this.txt_vin.Location = new System.Drawing.Point(38, 477);
            this.txt_vin.Name = "txt_vin";
            this.txt_vin.Size = new System.Drawing.Size(397, 23);
            this.txt_vin.TabIndex = 5;
            // 
            // txt_deviceKey
            // 
            this.txt_deviceKey.Location = new System.Drawing.Point(38, 560);
            this.txt_deviceKey.Name = "txt_deviceKey";
            this.txt_deviceKey.Size = new System.Drawing.Size(397, 23);
            this.txt_deviceKey.TabIndex = 6;
            // 
            // txt_drivers
            // 
            this.txt_drivers.Location = new System.Drawing.Point(38, 645);
            this.txt_drivers.Name = "txt_drivers";
            this.txt_drivers.Size = new System.Drawing.Size(397, 23);
            this.txt_drivers.TabIndex = 7;
            // 
            // addVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 1102);
            this.Controls.Add(this.txt_drivers);
            this.Controls.Add(this.txt_deviceKey);
            this.Controls.Add(this.txt_vin);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_make);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_addVehicle);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(538, 1141);
            this.MinimumSize = new System.Drawing.Size(538, 1141);
            this.Name = "addVehicle";
            this.Text = "Remozo - Add Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_addVehicle;
        private Button btn_back;
        private TextBox txt_make;
        private TextBox txt_model;
        private TextBox txt_vin;
        private TextBox txt_deviceKey;
        private TextBox txt_drivers;
    }
}