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
    public partial class FrmDesserts: Form
    {
        public int orderNum;
        public bool splash;
        public List<string> order = new() ;
        public List<double> prices = new();

        public FrmDesserts()
        {
            InitializeComponent();
        }

        public void OrderDisplay()
        {
            lbxOrder.Items.Clear();//clears listbox

            for (int i = 0; i < order.Count; i++)
            {
                lbxOrder.Items.Add(order[i] + ":  " + (prices[i].ToString("c")));
            }
        }

        private void FrmDesserts_Load(object sender, EventArgs e)
        {
            OrderDisplay();
        }

        //buttons to add items
        private void BtnCanolli_Click(object sender, EventArgs e)
        {
            const double CANOLLI = 6.00;// constant price variable
            if (nudCanolli.Value >= 1)
            {

                for (int i = 0; i < nudCanolli.Value; i++)//adds item(s) to arrays
                {
                    order.Add("Canolli Cake Slice");
                    prices.Add(CANOLLI); 
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnMousse_Click(object sender, EventArgs e)
        {

            const double MOUSSE = 5.00;
            if (nudMousse.Value >= 1)
            {
                for (int i = 0; i < nudMousse.Value; i++)
                {
                    order.Add("Mousse Cake Slice");
                    prices.Add(MOUSSE); //costs $5
                }
                
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnTiramisu_Click(object sender, EventArgs e)
        {
            const double TIRAMISU = 6.00;
            if (nudTiramisu.Value >= 1)
            {

                for (int i = 0; i < nudTiramisu.Value; i++)
                {
                    order.Add("Tiramisu");
                    prices.Add(TIRAMISU); // costs $6
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnCheesecake_Click(object sender, EventArgs e)
        {
            const double CHEESECAKE = 6.00;
            if (nudCheesecake.Value >= 1)
            {

                for (int i = 0; i < nudCheesecake.Value; i++)
                {
                    order.Add("Cheesecake Slice");
                    prices.Add(CHEESECAKE); //  costs $6
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnCherry_Click(object sender, EventArgs e)
        {
            const double PIE = 4.00;
            if (nudCherry.Value >= 1)
            {

                for (int i = 0; i < nudCherry.Value; i++)
                {
                    order.Add("Cherry Pie Slice");
                    prices.Add(PIE); // costs $4
                }
                OrderDisplay();

            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnPistachio_Click(object sender, EventArgs e)
        {
            const double PISTACHIO = 4.00;
            if (nudPistachio.Value >= 1)
            {

                for (int i = 0; i < nudPistachio.Value; i++)
                {
                    order.Add("Pistachio Ice Cream");
                    prices.Add(PISTACHIO); // costs $4
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnPeach_Click(object sender, EventArgs e)
        {
            const double PEACH = 6.00;
            if (nudPeach.Value >= 1)
            {

                for (int i = 0; i < nudPeach.Value; i++)
                {
                    order.Add("Peach Ripiero");
                    prices.Add(PEACH); // cake costs $6.50
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
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
            this.Hide();//this hides main from
            FrmMain main = new()
            {
                splash=splash,
                order = order,
                prices = prices,
                orderNum = orderNum
            };
            main.ShowDialog();//pops up beverages form
            this.Close();//this closes the first form
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();//this hides main from
            FrmCheckout checkout = new()
            {
                splash=splash,
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