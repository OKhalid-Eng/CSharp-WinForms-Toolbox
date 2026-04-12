using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbID.Text) || string.IsNullOrEmpty(tbName.Text))
                return;


            ListViewItem Item = new ListViewItem(tbID.Text.Trim());

            if (rbMale.Checked)
                Item.ImageIndex = 0;
            else
                Item.ImageIndex = 1;


            Item.SubItems.Add(tbName.Text.Trim());
            listView1.Items.Add(Item);

            tbID.Clear();
            tbName.Clear();
            tbID.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                listView1.SelectedItems[0].Remove();
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <=9; i++)
            {
                ListViewItem Item = new ListViewItem(i.ToString());

                if (i%2==0)
                    Item.ImageIndex = 1;
                else
                    Item.ImageIndex = 0;


                Item.SubItems.Add("Person"+i);
                listView1.Items.Add(Item);
            }
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;

        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;

        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
