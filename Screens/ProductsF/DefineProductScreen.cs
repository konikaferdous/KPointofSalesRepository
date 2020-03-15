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
    public partial class DefineProductScreen : MetroFramework.Forms.MetroForm
    {
        public DefineProductScreen()
        {
            InitializeComponent();
        }

        public bool IsUpdate { get; set; }
        private List<int> SizesCart = new List<int>();
        private void DefineProductScreen_Load(object sender, EventArgs e)
        {
            if(!this.IsUpdate)
            {

            }
            LoadAllSizesinDataGridView();
            LoadDataIntoComboBoxes();
        }

        private void LoadDataIntoComboBoxes() {
            CategoryComboBox.DataSource = GetComboBoxData(3);
            CategoryComboBox.DisplayMember = "Description";
            CategoryComboBox.ValueMember = "ID";

            SupplierComboBox.DataSource = GetComboBoxData(2);
            SupplierComboBox.DisplayMember = "Description";
            SupplierComboBox.ValueMember = "ID";
        }

        private DataTable GetComboBoxData(int listTypeID)
        {
            DataTable dtrecord = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_ListTypesData_LoadDataIntoComboBox", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ListTypeID", listTypeID);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);
                }
            }
            return dtrecord;
        }

        private void LoadAllSizesinDataGridView()
        {
            SizesDataGridView.DataSource = GetSizesData();
            SizesDataGridView.Columns[0].Visible = false;
        }

        private DataTable GetSizesData()
        {
            DataTable dtsizes = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Sizes_LoadAllSizes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ListTypeID", 1);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtsizes.Load(sdr);
                }
            }
                return dtsizes;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DefineNewButton_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            ProductNameTextBox.Clear();
            SupplierComboBox.SelectedIndex = -1;
            CategoryComboBox.SelectedIndex = -1;
            PurchasePriceTextBox.Clear();
            SalesPriceTextBox.Clear();

            foreach(DataGridViewRow row in SizesDataGridView.Rows)
            {
                row.Cells["Select"].Value = 0;
            }

            ProductNameTextBox.Focus();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SizesCart.Clear();
                LoadDataIntoSizesCart();
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Products_InsertNewProduct", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", ProductNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryComboBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@SupplierID", SupplierComboBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@PurchasePrice", PurchasePriceTextBox.Text);
                        cmd.Parameters.AddWithValue("@SalesPrice", SalesPriceTextBox.Text);

                        con.Open();

                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        SaveSizes(id);
                        MessageBox.Show("Product no." + id.ToString() + " is Saved Succcessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void SaveSizes(int _id)
        {

            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach(int sizeID in SizesCart)
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Products_InsertProductSizes", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductID", _id);
                        cmd.Parameters.AddWithValue("@SizeID", sizeID);
                        cmd.ExecuteNonQuery();
                        }
                }
                
            }
        }

        private void LoadDataIntoSizesCart()
        {
            foreach (DataGridViewRow row in SizesDataGridView.Rows)
            {
                if(row.Cells["Select"].Value != null && !DBNull.Value.Equals(row.Cells["Select"].Value) && Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    SizesCart.Add((int)row.Cells["ID"].Value);
                }
            }
        }

        private bool IsValid()
        {
            
            if(ProductNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Product Name is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductNameTextBox.Focus();
                return false;
            }

            if (PurchasePriceTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Purchase Price is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PurchasePriceTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}
