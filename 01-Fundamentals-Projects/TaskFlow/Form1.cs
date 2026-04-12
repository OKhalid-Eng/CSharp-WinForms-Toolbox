using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdatePanddingAndAsyncCompletedEventArgs()
        {
            lblPending.Text = (checkedListBox1.Items.Count - checkedListBox1.CheckedIndices.Count).ToString();
            lblCompleted.Text = checkedListBox1.CheckedItems.Count.ToString();

        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (tbAddItem.Text!="")
            {
                checkedListBox1.Items.Add(tbAddItem.Text);
                UpdatePanddingAndAsyncCompletedEventArgs();
            }
        }

        private void btDelect_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.RemoveAt(checkedListBox1.Items.Count - 1);
            UpdatePanddingAndAsyncCompletedEventArgs();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePanddingAndAsyncCompletedEventArgs();
        }
    }
}
