using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormOrderPizzaOrder : Form
    {
        public FormOrderPizzaOrder()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);

            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);

            else
                return Convert.ToSingle(rbLarg.Tag);
        }

        float CalculateToppingPrice()
        {
            float ToppingTotalPrice = 0;

            if (chkExtraChess.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chkExtraChess.Tag);
            }

            if (chkGreenPappers.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chkGreenPappers.Tag);
            }

            if (chkMashrooms.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chkMashrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chktomatoes.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chktomatoes.Tag);
            }

            return ToppingTotalPrice;
        }

        float GetSelectedCrustPrice()
        {
            if (rbThickCrust.Checked)
                return Convert.ToSingle(rbThickCrust.Tag);
            else
                return Convert.ToSingle(rbThinCrust.Tag);
            
        }

        float CalculateTotalPrice()
        {
            return GetSelectedCrustPrice()+GetSelectedSizePrice()+CalculateToppingPrice(); 
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text="$"+CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                LbLSizeName.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                LbLSizeName.Text = "Meduim";
                return;
            }
            if (rbLarg.Checked)
            {
                LbLSizeName.Text = "Large";
                return;
            }
        }

        void UpdateCrast()
        {
            UpdateTotalPrice() ;

            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }
            if (rbThickCrust.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }
        }

        void UpdateTopping()
        {
            UpdateTotalPrice();

            string sTopping = "";

            if (chkExtraChess.Checked)
            {
                sTopping += "Extra Chess";
            }

            if (chkGreenPappers.Checked)
            {
                sTopping += ", GreenPappers";
            }

            if (chkMashrooms.Checked)
            {
                sTopping += ", Mashrooms";
            }

            if (chkOlives.Checked)
            {
                sTopping += ", Olives";
            }

            if (chkOnion.Checked)
            {
                sTopping += ", Onion";
            }

            if (chktomatoes.Checked)
            {
                sTopping += ", tomatoes";
            }

            if (sTopping.StartsWith(","))
            {
                sTopping = sTopping.Substring(1, sTopping.Length - 1).Trim();
            }

            if (sTopping=="")
            {
                sTopping = "No Topping";
            }

            LBLTopping.Text=sTopping;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
           UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

     



      

       

        private void btOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK) ; 
            {
                MessageBox.Show("Order Placed Successfully","Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btOrderPizza.Enabled = false;
                pnCrustType.Enabled = false;
                pnSize.Enabled = false;
                pnTopping.Enabled = false; 
                pnWhereEat.Enabled = false;
            }
        }

        private void chkExtraChess_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void chkMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void chktomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void chkGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrast();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbThickCrust_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateCrast();
        }

        void UpdateWhereEte()
        {
            if (rbEatIn.Checked)
            {
                LBLEat.Text = "Eat In";
            }
            if (rbTakeOut.Checked)
            {
                LBLEat.Text = "Take Out";
            }
        }
        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereEte();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereEte();

        }

        void ResetForm()
        {
            pnCrustType.Enabled = true;
            pnSize.Enabled = true;
            pnTopping.Enabled = true;
            pnWhereEat.Enabled = true;


            rbMedium.Checked = true;

            chkExtraChess.Checked = false;
            chkGreenPappers.Checked = false;
            chkMashrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chktomatoes.Checked = false;

            rbThickCrust.Checked = true;

            rbEatIn.Checked = true;

            btOrderPizza.Enabled = true;

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        void UpdateOrderSummay()
        {
             UpdateSize();
            UpdateTopping();
            UpdateCrast();
            UpdateWhereEte();
            UpdateTotalPrice(); 
        }
        private void FormOrderPizzaOrder_Load(object sender, EventArgs e)
        {
            UpdateOrderSummay();
        }
    }
}
