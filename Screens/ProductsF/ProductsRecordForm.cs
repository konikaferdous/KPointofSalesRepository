using KPointofSales.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KPointofSales.Screens.ProductsF
{
    public partial class ProductsRecordForm : MetroFramework.Forms.MetroForm
    {
        public ProductsRecordForm()
        {
            InitializeComponent();
        }

        private void ProductsRecordForm_Load(object sender, EventArgs e)
        {
            LoadAllProductsIntoDataGridView();
        }

        private void LoadAllProductsIntoDataGridView()
        {
            ProductsDataGridView.DataSource = GetData();
        }

        private DataTable GetData()
        {
            DataTable dtrecord = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Products_LoadAllProductsForDataGridView", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);
                }
            }
            return dtrecord;
        }

        private void ProductNameTextBox_Click(object sender, EventArgs e)
        {
            if (ProductNameTextBox.Text.Trim() == string.Empty) 
            {
                LoadAllProductsIntoDataGridView();
            }
            else
            {
                ProductsDataGridView.DataSource = GetProductByProductID();
            }
        }

        private object GetProductByProductID()
        {
            DataTable dtrecord = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Product_LoadAllProductsByProductNames", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", ProductNameTextBox.Text.Trim());
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);
                }
            }
            return dtrecord;
        }
    }
}
