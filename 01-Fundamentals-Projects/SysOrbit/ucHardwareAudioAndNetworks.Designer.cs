namespace SysOrbit
{
    partial class ucHardwareAudioAndNetworks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDisplayData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefreshStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBatteryChargeStatus = new System.Windows.Forms.Label();
            this.lblVolueLev = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmListViet = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplayData
            // 
            this.btnDisplayData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisplayData.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDisplayData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayData.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayData.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnDisplayData.Location = new System.Drawing.Point(22, 374);
            this.btnDisplayData.Name = "btnDisplayData";
            this.btnDisplayData.Size = new System.Drawing.Size(564, 49);
            this.btnDisplayData.TabIndex = 15;
            this.btnDisplayData.Text = "Display Data";
            this.btnDisplayData.UseVisualStyleBackColor = false;
            this.btnDisplayData.Click += new System.EventHandler(this.btnDisplayData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Processes & Wi-Fi Scan";
            // 
            // btnRefreshStatus
            // 
            this.btnRefreshStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefreshStatus.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefreshStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStatus.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshStatus.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnRefreshStatus.Location = new System.Drawing.Point(22, 201);
            this.btnRefreshStatus.Name = "btnRefreshStatus";
            this.btnRefreshStatus.Size = new System.Drawing.Size(564, 49);
            this.btnRefreshStatus.TabIndex = 12;
            this.btnRefreshStatus.Text = "Refresh Status";
            this.btnRefreshStatus.UseVisualStyleBackColor = false;
            this.btnRefreshStatus.Click += new System.EventHandler(this.btnRefreshStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Battery && Audio Status";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Black;
            this.lblTittle.Location = new System.Drawing.Point(17, 25);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(350, 28);
            this.lblTittle.TabIndex = 9;
            this.lblTittle.Text = "Hardware, Audio && Networks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(58, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Battery:";
            // 
            // lblBatteryChargeStatus
            // 
            this.lblBatteryChargeStatus.AutoSize = true;
            this.lblBatteryChargeStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryChargeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBatteryChargeStatus.Location = new System.Drawing.Point(132, 121);
            this.lblBatteryChargeStatus.Name = "lblBatteryChargeStatus";
            this.lblBatteryChargeStatus.Size = new System.Drawing.Size(213, 24);
            this.lblBatteryChargeStatus.TabIndex = 19;
            this.lblBatteryChargeStatus.Text = "Battery Charge Status:";
            // 
            // lblVolueLev
            // 
            this.lblVolueLev.AutoSize = true;
            this.lblVolueLev.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolueLev.ForeColor = System.Drawing.Color.Green;
            this.lblVolueLev.Location = new System.Drawing.Point(200, 160);
            this.lblVolueLev.Name = "lblVolueLev";
            this.lblVolueLev.Size = new System.Drawing.Size(30, 24);
            this.lblVolueLev.TabIndex = 22;
            this.lblVolueLev.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(58, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Volume Level:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SysOrbit.Properties.Resources.volume;
            this.pictureBox2.Location = new System.Drawing.Point(22, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SysOrbit.Properties.Resources.battery;
            this.pictureBox1.Location = new System.Drawing.Point(22, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // cmListViet
            // 
            this.cmListViet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmListViet.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmListViet.FormattingEnabled = true;
            this.cmListViet.Items.AddRange(new object[] {
            "View Running Processes List",
            "Scan Nearby Wi-Fi Networks",
            ""});
            this.cmListViet.Location = new System.Drawing.Point(22, 319);
            this.cmListViet.Name = "cmListViet";
            this.cmListViet.Size = new System.Drawing.Size(564, 36);
            this.cmListViet.TabIndex = 23;
            // 
            // ucHardwareAudioAndNetworks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmListViet);
            this.Controls.Add(this.lblVolueLev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblBatteryChargeStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDisplayData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefreshStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTittle);
            this.Name = "ucHardwareAudioAndNetworks";
            this.Size = new System.Drawing.Size(605, 485);
            this.Load += new System.EventHandler(this.ucHardwareAudioAndNetworks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefreshStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBatteryChargeStatus;
        private System.Windows.Forms.Label lblVolueLev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmListViet;
    }
}
