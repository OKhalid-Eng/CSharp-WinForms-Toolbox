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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvAllContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _RefreshAllContactsList()
        {
            dgvAllContacts.DataSource = clsContact.GetAllContacts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshAllContactsList();
        }

        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            fmAddEditContact frm = new fmAddEditContact((int)dgvAllContacts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshAllContactsList();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete contact [" + dgvAllContacts.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsContact.DeleteContact((int)dgvAllContacts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Successfully.");
                    _RefreshAllContactsList();
                }

                else
                    MessageBox.Show("Contact is not deleted.");

            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            fmAddEditContact frm = new fmAddEditContact(-1);
            frm.ShowDialog();
            _RefreshAllContactsList();
        }
    }
}
