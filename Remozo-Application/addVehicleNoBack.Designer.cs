namespace Remozo_Application
{
    partial class addVehicleNoBack
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
            this.txt_drivers = new System.Windows.Forms.TextBox();
            this.txt_deviceKey = new System.Windows.Forms.TextBox();
            this.txt_vin = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_make = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.Add_Vehicle_no_back;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 1104);
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
            this.btn_addVehicle.Location = new System.Drawing.Point(72, 1022);
            this.btn_addVehicle.Name = "btn_addVehicle";
            this.btn_addVehicle.Size = new System.Drawing.Size(347, 73);
            this.btn_addVehicle.TabIndex = 2;
            this.btn_addVehicle.Text = "Add Vehicle";
            this.btn_addVehicle.UseVisualStyleBackColor = false;
            // 
            // txt_drivers
            // 
            this.txt_drivers.Location = new System.Drawing.Point(35, 650);
            this.txt_drivers.Name = "txt_drivers";
            this.txt_drivers.Size = new System.Drawing.Size(397, 23);
            this.txt_drivers.TabIndex = 12;
            // 
            // txt_deviceKey
            // 
            this.txt_deviceKey.Location = new System.Drawing.Point(35, 565);
            this.txt_deviceKey.Name = "txt_deviceKey";
            this.txt_deviceKey.Size = new System.Drawing.Size(397, 23);
            this.txt_deviceKey.TabIndex = 11;
            // 
            // txt_vin
            // 
            this.txt_vin.Location = new System.Drawing.Point(35, 482);
            this.txt_vin.Name = "txt_vin";
            this.txt_vin.Size = new System.Drawing.Size(397, 23);
            this.txt_vin.TabIndex = 10;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(35, 400);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(397, 23);
            this.txt_model.TabIndex = 9;
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(35, 322);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(397, 23);
            this.txt_make.TabIndex = 8;
            // 
            // addVehicleNoBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 1102);
            this.Controls.Add(this.txt_drivers);
            this.Controls.Add(this.txt_deviceKey);
            this.Controls.Add(this.txt_vin);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_make);
            this.Controls.Add(this.btn_addVehicle);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(538, 1141);
            this.MinimumSize = new System.Drawing.Size(538, 1141);
            this.Name = "addVehicleNoBack";
            this.Text = "Remozo - Add Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_addVehicle;
        private TextBox txt_drivers;
        private TextBox txt_deviceKey;
        private TextBox txt_vin;
        private TextBox txt_model;
        private TextBox txt_make;
    }
}