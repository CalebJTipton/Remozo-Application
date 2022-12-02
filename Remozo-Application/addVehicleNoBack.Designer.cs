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
            this.txt_make = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_vin = new System.Windows.Forms.TextBox();
            this.txt_deviceKey = new System.Windows.Forms.TextBox();
            this.txt_drivers = new System.Windows.Forms.TextBox();
            this.btn_addVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(72, 281);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(357, 23);
            this.txt_make.TabIndex = 1;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(72, 350);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(357, 23);
            this.txt_model.TabIndex = 2;
            // 
            // txt_vin
            // 
            this.txt_vin.Location = new System.Drawing.Point(72, 423);
            this.txt_vin.Name = "txt_vin";
            this.txt_vin.Size = new System.Drawing.Size(357, 23);
            this.txt_vin.TabIndex = 3;
            // 
            // txt_deviceKey
            // 
            this.txt_deviceKey.Location = new System.Drawing.Point(72, 495);
            this.txt_deviceKey.Name = "txt_deviceKey";
            this.txt_deviceKey.Size = new System.Drawing.Size(357, 23);
            this.txt_deviceKey.TabIndex = 4;
            // 
            // txt_drivers
            // 
            this.txt_drivers.Location = new System.Drawing.Point(72, 571);
            this.txt_drivers.Name = "txt_drivers";
            this.txt_drivers.Size = new System.Drawing.Size(357, 23);
            this.txt_drivers.TabIndex = 5;
            // 
            // btn_addVehicle
            // 
            this.btn_addVehicle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addVehicle.Location = new System.Drawing.Point(113, 905);
            this.btn_addVehicle.Name = "btn_addVehicle";
            this.btn_addVehicle.Size = new System.Drawing.Size(298, 64);
            this.btn_addVehicle.TabIndex = 6;
            this.btn_addVehicle.Text = "button1";
            this.btn_addVehicle.UseVisualStyleBackColor = false;
            // 
            // addVehicleNoBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 974);
            this.Controls.Add(this.btn_addVehicle);
            this.Controls.Add(this.txt_drivers);
            this.Controls.Add(this.txt_deviceKey);
            this.Controls.Add(this.txt_vin);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_make);
            this.MaximumSize = new System.Drawing.Size(540, 1013);
            this.MinimumSize = new System.Drawing.Size(540, 1013);
            this.Name = "addVehicleNoBack";
            this.Text = "Add Vehicle (first time)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txt_make;
        private TextBox txt_model;
        private TextBox txt_vin;
        private TextBox txt_deviceKey;
        private TextBox txt_drivers;
        private Button btn_addVehicle;
    }
}