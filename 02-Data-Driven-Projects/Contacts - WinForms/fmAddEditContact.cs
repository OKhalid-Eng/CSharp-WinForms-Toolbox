using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts___WinForms
{
    public partial class fmAddEditContact : Form
    {

        public enum enMode { AddNew = 0, Update = 1};
        private enMode _Mode;

        int _ContactID;
        clsContact _Contact;

        public fmAddEditContact(int ContactID)
        {
            InitializeComponent();
            _ContactID = ContactID;

            if (_ContactID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }
    
        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach(DataRow row in dtCountries.Rows)
            {
                cbcountry.Items.Add(row["CountryName"]);
                
            }

        }


       private void _LoadData()
        {
            _FillCountriesInComboBox();
            cbcountry.SelectedIndex = 0;

            if (_Mode==enMode.AddNew)
            {
                lbMode.Text = "Add New Contact";
                _Contact = new clsContact();
                return;
            }
            _Contact = clsContact.Find(_ContactID);

            if (_Contact==null)
            {
                MessageBox.Show($"This Form Will Be Close Bec. the Contact with ID :{_ContactID} is Not Found");
                this.Close();
                return;
            }

            lbMode.Text = "Edit Contact ID: " + _ContactID;
            lbContactID.Text = _ContactID.ToString();
            txtFirstName.Text = _Contact.FirstName;
            txtLastName.Text = _Contact.LastName;
            txtPhone.Text = _Contact.Phone;
            txtEmail.Text = _Contact.Email;
            txtAddress.Text = _Contact.Address;

            dtpDataBirth.Value = _Contact.DateOfBirth;

            if (_Contact.ImagePath!="")
            {
                pictureBox1.Load(_Contact.ImagePath);
            }

            LinkRemove.Visible = (_Contact.ImagePath != "");
            cbcountry.SelectedIndex = cbcountry.FindString(clsCountry.Find(_Contact.CountryID).CountryName);

        }

        private void fmAddEditContact_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int CountryID = clsCountry.Find(cbcountry.Text).ID;

            _Contact.FirstName = txtFirstName.Text;
            _Contact.LastName = txtLastName.Text;
            _Contact.Address = txtAddress.Text;
            _Contact.Email = txtEmail.Text;
            _Contact.DateOfBirth = dtpDataBirth.Value;
            _Contact.CountryID = CountryID;
            _Contact.Phone = txtPhone.Text;


            if (pictureBox1.ImageLocation != null)
                _Contact.ImagePath = pictureBox1.ImageLocation;
            else
                _Contact.ImagePath = "";


            if (_Contact.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            _Mode = enMode.Update;
            lbMode.Text = "Edit Contact ID = " + _Contact.ID;
            lbContactID.Text = _Contact.ID.ToString();
        }

        struct CountryItem
        {
            public string Text;
            public int Value;
            public CountryItem(string Text, int Value)
            {
                this.Text = Text;
                this.Value = Value;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


       
        private void linkImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
                // ...
            }
        }

        private void LinkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
            linkImage.Visible = false;
        }
    }
}
