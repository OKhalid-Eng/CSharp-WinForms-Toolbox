namespace SysOrbit
{
    partial class ucSysAndDisplay
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReslution = new System.Windows.Forms.TextBox();
            this.btnGetResolution = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnApplyWallpaper = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Black;
            this.lblTittle.Location = new System.Drawing.Point(15, 30);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(350, 28);
            this.lblTittle.TabIndex = 2;
            this.lblTittle.Text = "Display && Wallpaper Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Screen Resolution";
            // 
            // txtReslution
            // 
            this.txtReslution.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReslution.ForeColor = System.Drawing.Color.DarkGray;
            this.txtReslution.Location = new System.Drawing.Point(20, 123);
            this.txtReslution.Name = "txtReslution";
            this.txtReslution.ReadOnly = true;
            this.txtReslution.Size = new System.Drawing.Size(564, 40);
            this.txtReslution.TabIndex = 4;
            // 
            // btnGetResolution
            // 
            this.btnGetResolution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetResolution.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGetResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetResolution.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetResolution.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnGetResolution.Location = new System.Drawing.Point(20, 192);
            this.btnGetResolution.Name = "btnGetResolution";
            this.btnGetResolution.Size = new System.Drawing.Size(564, 49);
            this.btnGetResolution.TabIndex = 5;
            this.btnGetResolution.Text = "Get Resolution";
            this.btnGetResolution.UseVisualStyleBackColor = false;
            this.btnGetResolution.Click += new System.EventHandler(this.btnGetResolution_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Change Desktop Wallpaper";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(20, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Choose Wallpaper";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnApplyWallpaper
            // 
            this.btnApplyWallpaper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApplyWallpaper.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnApplyWallpaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyWallpaper.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyWallpaper.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnApplyWallpaper.Location = new System.Drawing.Point(20, 379);
            this.btnApplyWallpaper.Name = "btnApplyWallpaper";
            this.btnApplyWallpaper.Size = new System.Drawing.Size(564, 49);
            this.btnApplyWallpaper.TabIndex = 8;
            this.btnApplyWallpaper.Text = "Apply Wallpaper";
            this.btnApplyWallpaper.UseVisualStyleBackColor = false;
            this.btnApplyWallpaper.Click += new System.EventHandler(this.btnApplyWallpaper_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ucSysAndDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnApplyWallpaper);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetResolution);
            this.Controls.Add(this.txtReslution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTittle);
            this.Name = "ucSysAndDisplay";
            this.Size = new System.Drawing.Size(605, 485);
            this.Load += new System.EventHandler(this.ucSysAndDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReslution;
        private System.Windows.Forms.Button btnGetResolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnApplyWallpaper;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
