 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SpicyMeatball_CS115Final
{
    public partial class FrmRecept : Form
    {
        public int orderNum;
        public string name;
        public double tip;
        public string payment;
        public DateTime now = DateTime.Now; //date and time 

        //taxrate
        const double TAXRATE = .095;

        public List<string> order = new();
        public List<double> prices = new();

        public FrmRecept()
        {
            InitializeComponent();
        }

        //writes recept to file
        public void WriteRecept(double total) 
        {
            string filename = ("Order_" + orderNum+".txt").ToString();

            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText(filename);

                //writes order info
                outputFile.Write("Order number: " + orderNum + "\nName: " + name + "\nDate: " + now + "\n");

                //writes items to file
                for (int i = 0; i < order.Count; i++)
                {
                    outputFile.WriteLine(order[i] + ":  " + (prices[i].ToString("c")));
                }
                //writes totals
                outputFile.Write("Total: " + total.ToString("c") +
                    "\nTax: " + TAXRATE.ToString("p") +
                    "\nTip: " + tip.ToString("c") +
                    "\nGrand Total: " + ((total + (total * TAXRATE)) + tip).ToString("c") + "\nPayment Method: " + payment);

                outputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static double CalcTotal(List<double> prices)
        {
            double total = 0;

            for (int i = 0; i < prices.Count; i++)
            {
                total += prices[i];
            }

            return total;
        }

        public void DisplayOrder()
        {

            orderNum++;//increase order number

            //calculates listbox items
            for (int i = 0; i < order.Count; i++)
            {
                lbxOrder.Items.Add(order[i] + ":  " + (prices[i].ToString("c")));
            }

            double total = CalcTotal(prices);
            //total
            lblTotal.Text = "Total: " + total.ToString("c") +
                "\nSales Tax 9.5%: " + (total * TAXRATE).ToString("c") +
                "\nTip: " + tip.ToString("c") +
                "\nGrand total: " + ((total + (total * TAXRATE)) + tip).ToString("c");

            //order info
            lblorderInfo.Text = "Name: " + name +
                "\nOrder #: " + orderNum + "\nPayment type: " + payment;
        }

        private void FrmRecept_Load(object sender, EventArgs e)
        {
            DisplayOrder();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            double total = CalcTotal(prices);
            //write recept
            WriteRecept(total);

            MessageBox.Show("Order Submitted!");

            //clears arrays
            order = null;
            prices = null;

            this.Hide();
            this.Close();


            //resets screen
            FrmMain MainForm = new()
            {  
                orderNum = orderNum,   
            };
            MainForm.ShowDialog();
           
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCheckout CheckoutForm = new()
            {
                //transfers variables
                payment = payment,
                name = name,
                tip = tip,
                orderNum =orderNum,
                order = order,
                prices = prices
            };
            CheckoutForm.ShowDialog();
        }
    }
}
