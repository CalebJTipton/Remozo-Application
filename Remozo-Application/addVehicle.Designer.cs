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
            this.evHybridGroup = new System.Windows.Forms.GroupBox();
            this.rbtn_hybrid = new System.Windows.Forms.RadioButton();
            this.rbtn_EV = new System.Windows.Forms.RadioButton();
            this.truckGroup = new System.Windows.Forms.GroupBox();
            this.rbtn_van = new System.Windows.Forms.RadioButton();
            this.rbtn_truck = new System.Windows.Forms.RadioButton();
            this.rbtn_SUV = new System.Windows.Forms.RadioButton();
            this.rbtn_car = new System.Windows.Forms.RadioButton();
            this.groupOBD = new System.Windows.Forms.GroupBox();
            this.rbtn_obdv2 = new System.Windows.Forms.RadioButton();
            this.rbtn_obdv1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.evHybridGroup.SuspendLayout();
            this.truckGroup.SuspendLayout();
            this.groupOBD.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.App___Add_Vehicle__No_Toggle_;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 1107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_addVehicle
            // 
            this.btn_addVehicle.BackColor = System.Drawing.Color.Red;
            this.btn_addVehicle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addVehicle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addVehicle.ForeColor = System.Drawing.Color.White;
            this.btn_addVehicle.Location = new System.Drawing.Point(76, 988);
            this.btn_addVehicle.Name = "btn_addVehicle";
            this.btn_addVehicle.Size = new System.Drawing.Size(347, 73);
            this.btn_addVehicle.TabIndex = 1;
            this.btn_addVehicle.Text = "Add Vehicle";
            this.btn_addVehicle.UseVisualStyleBackColor = false;
            this.btn_addVehicle.Click += new System.EventHandler(this.btn_addVehicle_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(47, 144);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(73, 38);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(38, 310);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(397, 23);
            this.txt_make.TabIndex = 3;
            this.txt_make.TextChanged += new System.EventHandler(this.txt_make_TextChanged);
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(38, 386);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(397, 23);
            this.txt_model.TabIndex = 4;
            this.txt_model.TextChanged += new System.EventHandler(this.txt_model_TextChanged);
            // 
            // txt_vin
            // 
            this.txt_vin.Location = new System.Drawing.Point(38, 464);
            this.txt_vin.Name = "txt_vin";
            this.txt_vin.Size = new System.Drawing.Size(397, 23);
            this.txt_vin.TabIndex = 5;
            // 
            // txt_deviceKey
            // 
            this.txt_deviceKey.Location = new System.Drawing.Point(38, 563);
            this.txt_deviceKey.Name = "txt_deviceKey";
            this.txt_deviceKey.Size = new System.Drawing.Size(397, 23);
            this.txt_deviceKey.TabIndex = 6;
            // 
            // txt_drivers
            // 
            this.txt_drivers.Location = new System.Drawing.Point(38, 628);
            this.txt_drivers.Name = "txt_drivers";
            this.txt_drivers.Size = new System.Drawing.Size(397, 23);
            this.txt_drivers.TabIndex = 7;
            // 
            // evHybridGroup
            // 
            this.evHybridGroup.BackColor = System.Drawing.Color.White;
            this.evHybridGroup.Controls.Add(this.rbtn_hybrid);
            this.evHybridGroup.Controls.Add(this.rbtn_EV);
            this.evHybridGroup.Location = new System.Drawing.Point(303, 728);
            this.evHybridGroup.Name = "evHybridGroup";
            this.evHybridGroup.Size = new System.Drawing.Size(92, 60);
            this.evHybridGroup.TabIndex = 11;
            this.evHybridGroup.TabStop = false;
            // 
            // rbtn_hybrid
            // 
            this.rbtn_hybrid.AutoSize = true;
            this.rbtn_hybrid.Checked = true;
            this.rbtn_hybrid.Location = new System.Drawing.Point(6, 34);
            this.rbtn_hybrid.Name = "rbtn_hybrid";
            this.rbtn_hybrid.Size = new System.Drawing.Size(44, 19);
            this.rbtn_hybrid.TabIndex = 1;
            this.rbtn_hybrid.TabStop = true;
            this.rbtn_hybrid.Text = "Gas";
            this.rbtn_hybrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_hybrid.UseVisualStyleBackColor = true;
            // 
            // rbtn_EV
            // 
            this.rbtn_EV.AutoSize = true;
            this.rbtn_EV.Location = new System.Drawing.Point(6, 15);
            this.rbtn_EV.Name = "rbtn_EV";
            this.rbtn_EV.Size = new System.Drawing.Size(79, 19);
            this.rbtn_EV.TabIndex = 0;
            this.rbtn_EV.Text = "EV/Hybrid";
            this.rbtn_EV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_EV.UseVisualStyleBackColor = true;
            this.rbtn_EV.CheckedChanged += new System.EventHandler(this.rbtn_EV_CheckedChanged);
            // 
            // truckGroup
            // 
            this.truckGroup.BackColor = System.Drawing.Color.White;
            this.truckGroup.Controls.Add(this.rbtn_van);
            this.truckGroup.Controls.Add(this.rbtn_truck);
            this.truckGroup.Controls.Add(this.rbtn_SUV);
            this.truckGroup.Controls.Add(this.rbtn_car);
            this.truckGroup.Location = new System.Drawing.Point(303, 803);
            this.truckGroup.Name = "truckGroup";
            this.truckGroup.Size = new System.Drawing.Size(148, 60);
            this.truckGroup.TabIndex = 11;
            this.truckGroup.TabStop = false;
            // 
            // rbtn_van
            // 
            this.rbtn_van.AutoSize = true;
            this.rbtn_van.Location = new System.Drawing.Point(77, 35);
            this.rbtn_van.Name = "rbtn_van";
            this.rbtn_van.Size = new System.Drawing.Size(44, 19);
            this.rbtn_van.TabIndex = 3;
            this.rbtn_van.Text = "Van";
            this.rbtn_van.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_van.UseVisualStyleBackColor = true;
            // 
            // rbtn_truck
            // 
            this.rbtn_truck.AutoSize = true;
            this.rbtn_truck.Location = new System.Drawing.Point(77, 15);
            this.rbtn_truck.Name = "rbtn_truck";
            this.rbtn_truck.Size = new System.Drawing.Size(53, 19);
            this.rbtn_truck.TabIndex = 2;
            this.rbtn_truck.Text = "Truck";
            this.rbtn_truck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_truck.UseVisualStyleBackColor = true;
            // 
            // rbtn_SUV
            // 
            this.rbtn_SUV.AutoSize = true;
            this.rbtn_SUV.Checked = true;
            this.rbtn_SUV.Location = new System.Drawing.Point(6, 34);
            this.rbtn_SUV.Name = "rbtn_SUV";
            this.rbtn_SUV.Size = new System.Drawing.Size(46, 19);
            this.rbtn_SUV.TabIndex = 1;
            this.rbtn_SUV.TabStop = true;
            this.rbtn_SUV.Text = "SUV";
            this.rbtn_SUV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_SUV.UseVisualStyleBackColor = true;
            // 
            // rbtn_car
            // 
            this.rbtn_car.AutoSize = true;
            this.rbtn_car.Location = new System.Drawing.Point(6, 15);
            this.rbtn_car.Name = "rbtn_car";
            this.rbtn_car.Size = new System.Drawing.Size(43, 19);
            this.rbtn_car.TabIndex = 0;
            this.rbtn_car.Text = "Car";
            this.rbtn_car.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_car.UseVisualStyleBackColor = true;
            // 
            // groupOBD
            // 
            this.groupOBD.BackColor = System.Drawing.Color.White;
            this.groupOBD.Controls.Add(this.rbtn_obdv2);
            this.groupOBD.Controls.Add(this.rbtn_obdv1);
            this.groupOBD.Location = new System.Drawing.Point(303, 875);
            this.groupOBD.Name = "groupOBD";
            this.groupOBD.Size = new System.Drawing.Size(75, 60);
            this.groupOBD.TabIndex = 12;
            this.groupOBD.TabStop = false;
            // 
            // rbtn_obdv2
            // 
            this.rbtn_obdv2.AutoSize = true;
            this.rbtn_obdv2.Checked = true;
            this.rbtn_obdv2.Location = new System.Drawing.Point(6, 34);
            this.rbtn_obdv2.Name = "rbtn_obdv2";
            this.rbtn_obdv2.Size = new System.Drawing.Size(65, 19);
            this.rbtn_obdv2.TabIndex = 1;
            this.rbtn_obdv2.TabStop = true;
            this.rbtn_obdv2.Text = "OBD V2";
            this.rbtn_obdv2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_obdv2.UseVisualStyleBackColor = true;
            // 
            // rbtn_obdv1
            // 
            this.rbtn_obdv1.AutoSize = true;
            this.rbtn_obdv1.Location = new System.Drawing.Point(6, 15);
            this.rbtn_obdv1.Name = "rbtn_obdv1";
            this.rbtn_obdv1.Size = new System.Drawing.Size(65, 19);
            this.rbtn_obdv1.TabIndex = 0;
            this.rbtn_obdv1.Text = "OBD V1";
            this.rbtn_obdv1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_obdv1.UseVisualStyleBackColor = true;
            // 
            // addVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 1102);
            this.Controls.Add(this.groupOBD);
            this.Controls.Add(this.truckGroup);
            this.Controls.Add(this.evHybridGroup);
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
            this.evHybridGroup.ResumeLayout(false);
            this.evHybridGroup.PerformLayout();
            this.truckGroup.ResumeLayout(false);
            this.truckGroup.PerformLayout();
            this.groupOBD.ResumeLayout(false);
            this.groupOBD.PerformLayout();
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
        private GroupBox evHybridGroup;
        private RadioButton rbtn_hybrid;
        private RadioButton rbtn_EV;
        private GroupBox truckGroup;
        private RadioButton rbtn_SUV;
        private RadioButton rbtn_car;
        private GroupBox groupOBD;
        private RadioButton rbtn_obdv2;
        private RadioButton rbtn_obdv1;
        private RadioButton rbtn_van;
        private RadioButton rbtn_truck;
    }
}