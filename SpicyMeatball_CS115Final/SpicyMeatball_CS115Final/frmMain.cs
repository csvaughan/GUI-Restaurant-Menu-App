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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public int orderNum;
        public bool splash;
        public List<string> order = new() { };
        public List<double> prices = new() { };

        private void BtnEntrees_Click(object sender, EventArgs e)
        {
            splash = true;//set splash to true
            this.Hide();//this hides main from
            FrmEntrees entrees = new()
            {
                splash=splash,
                order = order,
                prices = prices,
                orderNum = orderNum
            };
            entrees.ShowDialog();//pops up entrees form
            this.Close();//this closes the first form
        }

        private void BtnDessert_Click(object sender, EventArgs e)
        {
            splash = true;//set splash to true
            this.Hide();//this hides main from
            FrmDesserts dessert = new()
            {
                splash=splash,
                order = order,
                prices = prices,
                orderNum = orderNum
            };
            dessert.ShowDialog();//pops up dessert form
            this.Close();//this closes the first form
        }

        private void BtnBeverages_Click(object sender, EventArgs e)
        {
            splash = true;//set splash to true
            this.Hide();//this hides main from
            FrmBeverages beverages = new()
            {
                splash=splash,
                order = order,
                prices = prices,
                orderNum = orderNum
            };
            beverages.ShowDialog();//pops up beverages form
            this.Close();//this closes the first form
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (splash==false)//splash screen only shows first time 
            {
                FrmSplashScreen splashForm = new();
                splashForm.ShowDialog();
            }
        }
    }
}
