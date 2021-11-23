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
    public partial class FrmEntrees : Form
    {
        public FrmEntrees()
        {
            InitializeComponent();
        }

        public int orderNum;
        public bool splash;
        public List<string> order = new();
        public List<double> prices = new();

        public void OrderDisplay()
        {

            lbxOrder.Items.Clear();//clears listbox

            for (int i = 0; i < order.Count; i++)
            {
                lbxOrder.Items.Add(order[i] + ":  " + (prices[i].ToString("c")));
            }
        }

        private void FrmEntrees_Load(object sender, EventArgs e)
        {
            OrderDisplay();
        }

        private void BtnMeatballs_Click(object sender, EventArgs e)
        {
            const double MEATBALL = 10.00;// constant price variable
            if (nudMeatballs.Value >= 1)
            {
                for (int i = 0; i < nudMeatballs.Value; i++)//adds item(s) to arrays
                { 
                    order.Add("Classic Meatballs");
                    prices.Add(MEATBALL);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnChickenParm_Click(object sender, EventArgs e)
        {
            const double PARM = 8.00;// constant price variable

            if (nudChickenParm.Value >= 1)
            {
                {
                    for (int i = 0; i < nudChickenParm.Value; i++)//adds item(s) to arrays
                    {
                        order.Add("Chicken Parmesan");
                        prices.Add(PARM);
                    }
                    OrderDisplay();
                }

            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnSpagetti_Click(object sender, EventArgs e)
        {
            const double SPAGETTI = 11.00;// constant price variable

            if (nudSpagetti.Value >= 1)
            {
                for (int i = 0; i < nudSpagetti.Value; i++)//adds item(s) to arrays
                {
                    order.Add("Plate of Spaghetti");
                    prices.Add(SPAGETTI);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }
            
    

        private void BtnPesto_Click(object sender, EventArgs e)
        {
            const double PESTO = 9.00;// constant price variable

            if (nudPesto.Value >= 1)
            {
                for (int i = 0; i < nudPesto.Value; i++)//adds item(s) to arrays
                {
                    order.Add("Pesto Pasta");
                    prices.Add(PESTO);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnEggplant_Click(object sender, EventArgs e)
        {
            const double EGGPLANT = 11.00;// constant price variable

            if (nudEggplant.Value >= 1)
            {
                for (int i = 0; i < nudEggplant.Value; i++)//adds item(s) to arrays
                {
                    order.Add("Eggplant Plate");
                    prices.Add(EGGPLANT);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnShrimp_Click(object sender, EventArgs e)
        {
            const double SHRIMP = 10.00;// constant price variable

            if (nudShrimp.Value >= 1)
            {
                for (int i = 0; i < nudShrimp.Value; i++)//adds item(s) to arrays
                {
                    order.Add("Shrimp Risotto");
                    prices.Add(SHRIMP);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnSpinach_Click(object sender, EventArgs e)
        {
            const double SPINACH = 7.00;// constant price variable

            if (nudSpinach.Value >= 1)
            {
                for (int i = 0; i < nudSpinach.Value; i++)//adds item(s) to arrays
                {
                    order.Add("Spinach Risotto");
                    prices.Add(SPINACH);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnTomato_Click(object sender, EventArgs e)
        {
            const double TOMATO = 12.00;// constant price variable

            if (nudTomato.Value >= 1)
            {
                for (int i = 0; i < nudTomato.Value; i++)//adds item(s) to arrays
                {
                    order.Add("Tomato Soup");
                    prices.Add(TOMATO);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnMinestrone_Click(object sender, EventArgs e)
        {
            const double MINESTRONE = 9.00;// constant price variable

            if (nudMinestrone.Value >= 1)
            {
                for (int i = 0; i < nudMinestrone.Value; i++)//adds item(s) to arrays
                {
                    order.Add("Minestrone Soup");
                    prices.Add(MINESTRONE);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
        }

        private void BtnChickenGnocchi_Click(object sender, EventArgs e)
        {
            const double CHKGNOCCHI = 13.00;// constant price variable

            if (nudChickenGnocchi.Value >= 1)
            {
                for (int i = 0; i < nudChickenGnocchi.Value; i++)//adds item(s) to arrays
                {
                    order.Add("Chicken Gnocchi");
                    prices.Add(CHKGNOCCHI);
                }
                OrderDisplay();
            }
            else
            {
                MessageBox.Show("No amount selected");
            }
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

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            lbxOrder.Items.Clear();
            order.Clear();
            prices.Clear();

            MessageBox.Show("Order Cleared");
            OrderDisplay();
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
    }
}