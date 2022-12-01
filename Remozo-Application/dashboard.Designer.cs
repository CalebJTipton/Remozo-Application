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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.App___Dashboard3;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(523, 1141);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(523, 1141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 1141);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_locateExpand
            // 
            this.btn_locateExpand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_locateExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_locateExpand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_locateExpand.Location = new System.Drawing.Point(366, 374);
            this.btn_locateExpand.Name = "btn_locateExpand";
            this.btn_locateExpand.Size = new System.Drawing.Size(100, 35);
            this.btn_locateExpand.TabIndex = 1;
            this.btn_locateExpand.Text = "expand";
            this.btn_locateExpand.UseVisualStyleBackColor = true;
            this.btn_locateExpand.Click += new System.EventHandler(this.btn_locateExpand_Click);
            // 
            // btn_controlExpand
            // 
            this.btn_controlExpand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_controlExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_controlExpand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_controlExpand.Location = new System.Drawing.Point(366, 639);
            this.btn_controlExpand.Name = "btn_controlExpand";
            this.btn_controlExpand.Size = new System.Drawing.Size(100, 35);
            this.btn_controlExpand.TabIndex = 2;
            this.btn_controlExpand.Text = "expand";
            this.btn_controlExpand.UseVisualStyleBackColor = true;
            // 
            // btn_maintainExpand
            // 
            this.btn_maintainExpand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_maintainExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maintainExpand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_maintainExpand.Location = new System.Drawing.Point(366, 916);
            this.btn_maintainExpand.Name = "btn_maintainExpand";
            this.btn_maintainExpand.Size = new System.Drawing.Size(100, 35);
            this.btn_maintainExpand.TabIndex = 3;
            this.btn_maintainExpand.Text = "expand";
            this.btn_maintainExpand.UseVisualStyleBackColor = true;
            this.btn_maintainExpand.Click += new System.EventHandler(this.btn_maintainExpand_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 1141);
            this.Controls.Add(this.btn_maintainExpand);
            this.Controls.Add(this.btn_controlExpand);
            this.Controls.Add(this.btn_locateExpand);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(540, 1180);
            this.MinimumSize = new System.Drawing.Size(540, 1180);
            this.Name = "dashboard";
            this.Text = "Remoso - Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_locateExpand;
        private Button btn_controlExpand;
        private Button btn_maintainExpand;
    }
}