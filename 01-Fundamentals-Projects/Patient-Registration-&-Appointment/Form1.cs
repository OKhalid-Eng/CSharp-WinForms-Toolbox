using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Patient_Registration___Appointment_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpAppointment.MinDate = DateTime.Now;
        }

        private void btnOpenFilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select Patient Photo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbPatientPhoto.Image = new Bitmap(openFileDialog.FileName);
                pbPatientPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Clear previous errors
            errorProvider1.Clear();

            // --- Validation ---
            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                errorProvider1.SetError(txtPatientName, "Please enter the patient's name.");
                txtPatientName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Please enter the phone number.");
                txtPhone.Focus();
                return;
            }

            // --- Data Collection ---
            string gender = rbMale.Checked ? "Male" : "Female";
            string department = cbDepartment.SelectedItem.ToString();
            string appointmentDate = dtpAppointment.Value.ToString("dd/MM/yyyy");
            string hasChronicDiseases = chboxSuffersPatient.Checked ? "Yes" : "No";

            // --- Prepare Summary ---
            string summary = "Appointment booked successfully!\n\n" +
                             $"Patient Name: {txtPatientName.Text}\n" +
                             $"Gender: {gender}\n" +
                             $"Department: {department}\n" +
                             $"Date: {appointmentDate}\n" +
                             $"Chronic Diseases: {hasChronicDiseases}";

            // --- Show Result ---
            MessageBox.Show(summary, "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // --- Reset Form ---
            ClearForm();
        }

        private void ClearForm()
        {
            txtPatientName.Clear();
            txtPhone.Clear();
            rbMale.Checked = true; // Default back to Male
            cbDepartment.SelectedIndex = 0; // Default back to first item
            dtpAppointment.Value = DateTime.Now; // Reset date to today
            chboxSuffersPatient.Checked = false;

            if (pbPatientPhoto.Image != null)
            {
                pbPatientPhoto.Image.Dispose();
                pbPatientPhoto.Image = null;
            }
        }
    } 
}
