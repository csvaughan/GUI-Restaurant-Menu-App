using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
/*
Name: Caleb Vaughan
Date: 5/10/2021
Project: Checkout Form- Lets user check out of menu app
 */
namespace SpicyMeatball_CS115Final
{
    public partial class FrmCheckout : Form
    {
        //global variables
        public string payment;
        public string name;
        public double tip;
        public int orderNum;
        public bool splash=true;

        //lists
        public List<string> order = new();
        public List<double> prices = new();

        public FrmCheckout()
        {
            InitializeComponent();
        }

        //shows recept to user
        void Recept()
        {
            payment = cbxPayment.Text;
            name = txtName.Text;
            tip = double.Parse(txtTip.Text);

            this.Hide();
            FrmRecept ReceptForm = new()
            {
                //transfer variables
                payment = payment,
                name = name,
                tip = tip,
                orderNum = orderNum,
                //transfers list
                order = order,
                prices = prices
            };
            ReceptForm.ShowDialog();
            this.Close();
        }

        //displays order in listbax and calcualtes recoomended tip
        public void OrderDisplay()
        {
            const double TAXRATE = .095;

            lbxOrder.Items.Clear();//clears listbox

            //calculates listbox items
            for (int i = 0; i < order.Count; i++)
            {
                lbxOrder.Items.Add(order[i] + ":  " + (prices[i].ToString("c")));
            }

            double total = CalcTotal(prices);
            double grandTot = (total + (total * TAXRATE));

            lblTotal.Text = "Total: " + total.ToString("c") +
                "\nSales Tax 9.5%: " + (total * TAXRATE).ToString("c") +
                "\nGrand total: "+ grandTot.ToString("c");

            //calculate suggested tip
            lblSuggestedTip.Text = "Our employees work very hard to deliver the best dining experience. Please consider showing your appreciation with a tip.\n\n" +
            "Recomended tip amount:      \n         10%: " + (grandTot* .10).ToString("c") +
                                        "\n         15%: " + (grandTot* .15).ToString("c") +
                                        "\n         20%: " + (grandTot * .20).ToString("c");
        }

        //calculates total cost of order
        public static double CalcTotal(List<double> prices)
        {
            double total = 0;

            for (int i = 0; i < prices.Count; i++)
            {
                total += prices[i];
            }

            return total;
        }

        private void FrmCheckout_Load(object sender, EventArgs e)
        {
            //loads order info 
            OrderDisplay();

            cbxPayment.Text=payment;
            txtName.Text = name;
            txtTip.Text = tip.ToString();
        }

        private void CbxPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPayment.SelectedIndex != -1)
            {
                switch (cbxPayment.SelectedIndex)
                {
                    case 0://cash
                        lblWaiter.Visible = true;
                        panCard.Visible = false;
                        panPin.Visible = false;
                        break;

                    case 1://debit                
                        lblWaiter.Visible = false;
                        panCard.Visible = true;
                        panPin.Visible = true;

                        break;

                    case 2://credit
                        lblWaiter.Visible = false;
                        panCard.Visible = true;
                        panPin.Visible = false;
                        break;
                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (order.Count != 0)
                {
                    if (cbxPayment.SelectedIndex != -1)
                    {
                        if (double.TryParse(txtTip.Text, out double tip) && tip >= 0)
                        {
                            switch (cbxPayment.SelectedIndex)
                            {
                                case 0://cash
                                    Recept();
                                    break;

                                case 1://debit
                                    if (txtCardnum.Text != "" && txtYear.Text != "" && txtMonth.Text != "" && txtPin.Text != "")
                                    {
                                        Recept();
                                    }
                                    else
                                        MessageBox.Show("Invalid data");
                                    break;

                                case 2://credit

                                    if (txtCardnum.Text != "" && txtYear.Text != "" && txtMonth.Text != "")
                                    {
                                        Recept();
                                    }
                                    else
                                        MessageBox.Show("Invalid data");
                                    break;
                            }
                        }
                        else
                            MessageBox.Show("Invalid tip entry");
                    }
                    else
                        MessageBox.Show("Please select a payment method from the drop-down");
                }
                else
                    MessageBox.Show("Order can not be blank");
            }
            else
                MessageBox.Show("Please enter a name for the order");
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain Mainform = new()
            {
                splash = splash,
                order = order,
                prices = prices,
                orderNum = orderNum
            };
            Mainform.ShowDialog();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (lbxOrder.SelectedIndex >= 0)
            {
                int item = lbxOrder.SelectedIndex;

                //removes items from arrays
                order.RemoveAt(item);               
                prices.RemoveAt(item);
          
                lbxOrder.Items.RemoveAt(item);
                OrderDisplay();
            }
            else
                MessageBox.Show("No item selected");
        }
    }
}