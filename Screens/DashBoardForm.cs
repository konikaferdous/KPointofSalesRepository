using KPointofSales.Screens.ProductsF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KPointofSales.Screens
{
    public partial class DashBoardForm : MetroFramework.Forms.MetroForm
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            ProductsBRecordForm prd = new ProductsBRecordForm();
            prd.Show();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DefineProductScreen dps = new DefineProductScreen();
            dps.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ProductsRecordForm prd = new ProductsRecordForm();
            prd.Show();
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            ProductsBRecordForm prd = new ProductsBRecordForm();
            prd.Show();
        }
    }
}
