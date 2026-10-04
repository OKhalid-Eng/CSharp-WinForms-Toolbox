namespace Patient_Registration___Appointment_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.pbPatientPhoto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFilePicture = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.chboxSuffersPatient = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(265, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register a new patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(141, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient name:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(146, 245);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(206, 32);
            this.txtPatientName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sex:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Location = new System.Drawing.Point(244, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 70);
            this.panel1.TabIndex = 5;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(172, 18);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(86, 26);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(78, 18);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(67, 26);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // pbPatientPhoto
            // 
            this.pbPatientPhoto.ErrorImage = null;
            this.pbPatientPhoto.Image = global::Patient_Registration___Appointment_Form.Properties.Resources.images1;
            this.pbPatientPhoto.Location = new System.Drawing.Point(145, 120);
            this.pbPatientPhoto.Name = "pbPatientPhoto";
            this.pbPatientPhoto.Size = new System.Drawing.Size(58, 71);
            this.pbPatientPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPatientPhoto.TabIndex = 6;
            this.pbPatientPhoto.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFilePicture
            // 
            this.btnOpenFilePicture.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFilePicture.Location = new System.Drawing.Point(219, 139);
            this.btnOpenFilePicture.Name = "btnOpenFilePicture";
            this.btnOpenFilePicture.Size = new System.Drawing.Size(133, 31);
            this.btnOpenFilePicture.TabIndex = 7;
            this.btnOpenFilePicture.Text = "Choose Picture";
            this.btnOpenFilePicture.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(891, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Required specialization:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "Dental ",
            "General surgery",
            "Pediatric ",
            "Neurology "});
            this.cbDepartment.Location = new System.Drawing.Point(920, 189);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(215, 29);
            this.cbDepartment.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(891, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Booking date:";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointment.Location = new System.Drawing.Point(886, 309);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(342, 32);
            this.dtpAppointment.TabIndex = 11;
            // 
            // chboxSuffersPatient
            // 
            this.chboxSuffersPatient.AutoSize = true;
            this.chboxSuffersPatient.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxSuffersPatient.Location = new System.Drawing.Point(131, 412);
            this.chboxSuffersPatient.Name = "chboxSuffersPatient";
            this.chboxSuffersPatient.Size = new System.Drawing.Size(766, 32);
            this.chboxSuffersPatient.TabIndex = 12;
            this.chboxSuffersPatient.Text = "The patient suffers from chronic diseases (diabetes/high blood pressure)";
            this.chboxSuffersPatient.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(273, 459);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(489, 56);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Save and confirm your reservation";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(435, 245);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(206, 32);
            this.txtPhone.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(430, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1257, 549);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.chboxSuffersPatient);
            this.Controls.Add(this.dtpAppointment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpenFilePicture);
            this.Controls.Add(this.pbPatientPhoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.PictureBox pbPatientPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFilePicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.CheckBox chboxSuffersPatient;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
    }
}

