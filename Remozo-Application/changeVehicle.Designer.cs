namespace Remozo_Application
{
    partial class changeVehicle
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
            this.btn_addVehicle = new System.Windows.Forms.Button();
            this.lbl_jeepWrangler = new System.Windows.Forms.Label();
            this.lbl_porcheTaycan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.App___Change_Vehicle;
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 1106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(47, 153);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(77, 40);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_addVehicle
            // 
            this.btn_addVehicle.BackColor = System.Drawing.Color.Red;
            this.btn_addVehicle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addVehicle.FlatAppearance.BorderSize = 0;
            this.btn_addVehicle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addVehicle.ForeColor = System.Drawing.Color.White;
            this.btn_addVehicle.Location = new System.Drawing.Point(96, 613);
            this.btn_addVehicle.Name = "btn_addVehicle";
            this.btn_addVehicle.Size = new System.Drawing.Size(348, 75);
            this.btn_addVehicle.TabIndex = 3;
            this.btn_addVehicle.Text = "Add Vehicle";
            this.btn_addVehicle.UseVisualStyleBackColor = false;
            this.btn_addVehicle.Click += new System.EventHandler(this.btn_addVehicle_Click);
            // 
            // lbl_jeepWrangler
            // 
            this.lbl_jeepWrangler.AutoSize = true;
            this.lbl_jeepWrangler.BackColor = System.Drawing.Color.White;
            this.lbl_jeepWrangler.Font = new System.Drawing.Font("Segoe UI", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_jeepWrangler.Location = new System.Drawing.Point(213, 303);
            this.lbl_jeepWrangler.Name = "lbl_jeepWrangler";
            this.lbl_jeepWrangler.Size = new System.Drawing.Size(317, 59);
            this.lbl_jeepWrangler.TabIndex = 4;
            this.lbl_jeepWrangler.Text = "Jeep Wrangler";
            this.lbl_jeepWrangler.Click += new System.EventHandler(this.lbl_jeepWrangler_Click);
            // 
            // lbl_porcheTaycan
            // 
            this.lbl_porcheTaycan.AutoSize = true;
            this.lbl_porcheTaycan.BackColor = System.Drawing.Color.White;
            this.lbl_porcheTaycan.Font = new System.Drawing.Font("Segoe UI", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_porcheTaycan.Location = new System.Drawing.Point(213, 482);
            this.lbl_porcheTaycan.Name = "lbl_porcheTaycan";
            this.lbl_porcheTaycan.Size = new System.Drawing.Size(312, 59);
            this.lbl_porcheTaycan.TabIndex = 5;
            this.lbl_porcheTaycan.Text = "Porche Taycan";
            this.lbl_porcheTaycan.Click += new System.EventHandler(this.lbl_porcheTaycan_Click);
            // 
            // changeVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 1102);
            this.Controls.Add(this.lbl_porcheTaycan);
            this.Controls.Add(this.lbl_jeepWrangler);
            this.Controls.Add(this.btn_addVehicle);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(538, 1141);
            this.MinimumSize = new System.Drawing.Size(538, 1141);
            this.Name = "changeVehicle";
            this.Text = "Remozo - Garage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_back;
        private Button btn_addVehicle;
        private Label lbl_jeepWrangler;
        private Label lbl_porcheTaycan;
    }
}