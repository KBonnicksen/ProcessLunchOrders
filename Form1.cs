using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessLunchOrders
{
    public partial class frmLunchOrder : Form
    {
        Food foodItem = new Food();
        public Decimal taxRate = (Decimal)7.75;

        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void RadHamburger_Click(object sender, EventArgs e)
        {
            ClearPriceInfo();
            ClearCheckBoxes();
            foodItem = new Hamburger();
            ChangeAddOnList();
        }

        private void RadPizza_Click(object sender, EventArgs e)
        {
            ClearPriceInfo();
            ClearCheckBoxes();
            foodItem = new Pizza();
            ChangeAddOnList();
        }

        private void radSalad_Click(object sender, EventArgs e)
        {
            ClearPriceInfo();
            ClearCheckBoxes();
            foodItem = new Salad();
            ChangeAddOnList();
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            Decimal subtotal = foodItem.totalPrice;
            txtSubtotal.Text = subtotal.ToString();

            Decimal totalTax = (Decimal).01 * taxRate * subtotal;
            txtTax.Text = String.Format("{0:C2}", totalTax);

            txtTotal.Text = String.Format("{0:C2}", subtotal + totalTax);
        }

        private void ChangeAddOnList()
        {
            String addonInfo = String.Format("{0:C2}", foodItem.addOnPrice);
            grbAddOns.Text = "Add-on items (" + addonInfo + "/each)";
            MakeChkBoxesVisible();

            chkAddon1.Text = foodItem.addOn1;
            chkAddon2.Text = foodItem.addOn2;
            chkAddon3.Text = foodItem.addOn3;
        }

        public void MakeChkBoxesVisible()
        {
            foreach(Control c in grbAddOns.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox box = (CheckBox)c;
                    box.Visible = true;
                }
            }
        }

        private void ChkAddOns_CheckedChanged(object sender, EventArgs e)
        {
            ClearPriceInfo();
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked)
            {
                foodItem.AddItem();
            }
            else
            {
                foodItem.TakeItemOffOrder();
            }
        }

        private void ClearCheckBoxes()
        {
            foreach (Control c in grbAddOns.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox box = (CheckBox)c;
                    box.Checked = false;
                }
            }
        }

        private void ClearPriceInfo()
        {
            foreach (Control c in grbOrderTotal.Controls)
            {
                if (c is TextBox)
                {
                    TextBox box = (TextBox)c;
                    box.Clear();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
