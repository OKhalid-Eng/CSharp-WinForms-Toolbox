namespace WindowsFormsApp25
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnCheckTheLimetSpeed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mbtSpeed = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnCheckTheLimetSpeed
            // 
            this.btnCheckTheLimetSpeed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckTheLimetSpeed.Location = new System.Drawing.Point(250, 212);
            this.btnCheckTheLimetSpeed.Name = "btnCheckTheLimetSpeed";
            this.btnCheckTheLimetSpeed.Size = new System.Drawing.Size(212, 41);
            this.btnCheckTheLimetSpeed.TabIndex = 0;
            this.btnCheckTheLimetSpeed.Text = "Check The Limet Speed";
            this.btnCheckTheLimetSpeed.UseVisualStyleBackColor = true;
            this.btnCheckTheLimetSpeed.Click += new System.EventHandler(this.btnCheckTheLimetSpeed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(266, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Speed";
            // 
            // mbtSpeed
            // 
            this.mbtSpeed.Location = new System.Drawing.Point(269, 142);
            this.mbtSpeed.Mask = "000";
            this.mbtSpeed.Name = "mbtSpeed";
            this.mbtSpeed.Size = new System.Drawing.Size(175, 24);
            this.mbtSpeed.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mbtSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckTheLimetSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnCheckTheLimetSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mbtSpeed;
    }
}

