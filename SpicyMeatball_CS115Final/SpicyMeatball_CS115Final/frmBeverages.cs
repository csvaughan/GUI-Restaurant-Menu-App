using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpicyMeatball_CS115Final
{
    public partial class FrmBeverages : Form
    {
        public int orderNum;
        public bool splash;
        public List<string> order = new() { };
        public List<double> prices = new() { };

        public FrmBeverages()
        {
            InitializeComponent();
        }


        public void OrderDisplay()
        {

            lbxOrder.Items.Clear();//clears listbox

            for (int i = 0; i < order.Count/*placeholder*/; i++)
            {
                lbxOrder.Items.Add(order[i] + ":  " + (prices[i].ToString("c")));
            }
        }

        private void FrmBeverages_Load(object sender, EventArgs e)
        {
            OrderDisplay();
        }

        private void BtnWater_Click(object sender, EventArgs e)
        {
            const double WATER = 1.00;
            if (nudWater.Value >= 1)
            {
                for (int i = 0; i < nudWater.Value; i++)
                {
                    order.Add("Glass of Water");
                    prices.Add(WATER); 
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnFountain_Click(object sender, EventArgs e)
        {
            const double SODA = 3.00;
            if (nudFountain.Value >= 1)
            {

                for (int i = 0; i < nudFountain.Value; i++)
                {
                    order.Add("Fountain Drink");
                    prices.Add(SODA);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnTea_Click(object sender, EventArgs e)
        {
            const double TEA = 3.00;
            if (nudTea.Value >= 1)
            {
                for (int i = 0; i < nudTea.Value; i++)
                {
                    order.Add("Cup of Tea");
                    prices.Add(TEA);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnCoffee_Click(object sender, EventArgs e)
        {
            const double COFFEE = 4.00;
            if (nudCoffee.Value >= 1)
            {
                for (int i = 0; i < nudCoffee.Value; i++)
                {
                    order.Add("Cup of Coffee");
                    prices.Add(COFFEE);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            const double RED = 5.00;
            if (nudRed.Value >= 1)
            {           
                for (int i = 0; i < nudRed.Value; i++)
                {
                    order.Add("Red Wine");
                    prices.Add(RED);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnWhite_Click(object sender, EventArgs e)
        {
            const double WHITE = 6.00;
            if (nudWhite.Value >= 1)
            {
                for (int i = 0; i < nudWhite.Value; i++)
                {
                    order.Add("White Wine");
                    prices.Add(WHITE);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnSparkling_Click(object sender, EventArgs e)
        {
            const double SPARKLE = 5.00;
            if (nudSparkling.Value >= 1)
            {
                for (int i = 0; i < nudSparkling.Value; i++)
                {
                    order.Add("White Wine");
                    prices.Add(SPARKLE);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
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

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            lbxOrder.Items.Clear();
            order.Clear();
            prices.Clear();
            
            MessageBox.Show("Order Cleared");
            OrderDisplay();
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

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();//this hides main from
            FrmCheckout checkout = new()
            {
                splash = splash,
                order = order,
                prices = prices,
                orderNum = orderNum
            };
            checkout.ShowDialog();//pops up beverages form
            this.Close();//this closes the first form
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
