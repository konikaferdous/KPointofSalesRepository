namespace KPointofSales.Screens.ProductsF
{
    partial class DefineProductScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ProductNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CategoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.DefineNewButton = new MetroFramework.Controls.MetroButton();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.SizesDataGridView = new System.Windows.Forms.DataGridView();
            this.SalesPriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PurchasePriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.SupplierComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DeSelectSizeinbutton = new System.Windows.Forms.Button();
            this.SelectAllSizebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SizesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(676, 115);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Poduct Name";
            // 
            // ProductNameTextBox
            // 
            // 
            // 
            // 
            this.ProductNameTextBox.CustomButton.Image = null;
            this.ProductNameTextBox.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.ProductNameTextBox.CustomButton.Name = "";
            this.ProductNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProductNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductNameTextBox.CustomButton.TabIndex = 1;
            this.ProductNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductNameTextBox.CustomButton.UseSelectable = true;
            this.ProductNameTextBox.CustomButton.Visible = false;
            this.ProductNameTextBox.Lines = new string[0];
            this.ProductNameTextBox.Location = new System.Drawing.Point(377, 111);
            this.ProductNameTextBox.MaxLength = 32767;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.PasswordChar = '\0';
            this.ProductNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductNameTextBox.SelectedText = "";
            this.ProductNameTextBox.SelectionLength = 0;
            this.ProductNameTextBox.SelectionStart = 0;
            this.ProductNameTextBox.ShortcutsEnabled = true;
            this.ProductNameTextBox.Size = new System.Drawing.Size(255, 23);
            this.ProductNameTextBox.TabIndex = 0;
            this.ProductNameTextBox.UseSelectable = true;
            this.ProductNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.ItemHeight = 23;
            this.CategoryComboBox.Location = new System.Drawing.Point(411, 141);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(220, 29);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.UseSelectable = true;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Location = new System.Drawing.Point(377, 371);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(166, 38);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save  ";
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DefineNewButton
            // 
            this.DefineNewButton.Location = new System.Drawing.Point(76, 371);
            this.DefineNewButton.Name = "DefineNewButton";
            this.DefineNewButton.Size = new System.Drawing.Size(167, 38);
            this.DefineNewButton.TabIndex = 8;
            this.DefineNewButton.Text = "Define New";
            this.DefineNewButton.UseSelectable = true;
            this.DefineNewButton.Click += new System.EventHandler(this.DefineNewButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CloseButton.Location = new System.Drawing.Point(598, 371);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(167, 38);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseSelectable = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SizesDataGridView
            // 
            this.SizesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SizesDataGridView.Location = new System.Drawing.Point(76, 112);
            this.SizesDataGridView.Name = "SizesDataGridView";
            this.SizesDataGridView.Size = new System.Drawing.Size(240, 242);
            this.SizesDataGridView.TabIndex = 5;
            // 
            // SalesPriceTextBox
            // 
            // 
            // 
            // 
            this.SalesPriceTextBox.CustomButton.Image = null;
            this.SalesPriceTextBox.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.SalesPriceTextBox.CustomButton.Name = "";
            this.SalesPriceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SalesPriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SalesPriceTextBox.CustomButton.TabIndex = 1;
            this.SalesPriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SalesPriceTextBox.CustomButton.UseSelectable = true;
            this.SalesPriceTextBox.CustomButton.Visible = false;
            this.SalesPriceTextBox.Lines = new string[0];
            this.SalesPriceTextBox.Location = new System.Drawing.Point(450, 240);
            this.SalesPriceTextBox.MaxLength = 32767;
            this.SalesPriceTextBox.Name = "SalesPriceTextBox";
            this.SalesPriceTextBox.PasswordChar = '\0';
            this.SalesPriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SalesPriceTextBox.SelectedText = "";
            this.SalesPriceTextBox.SelectionLength = 0;
            this.SalesPriceTextBox.SelectionStart = 0;
            this.SalesPriceTextBox.ShortcutsEnabled = true;
            this.SalesPriceTextBox.Size = new System.Drawing.Size(181, 23);
            this.SalesPriceTextBox.TabIndex = 4;
            this.SalesPriceTextBox.UseSelectable = true;
            this.SalesPriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SalesPriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PurchasePriceTextBox
            // 
            // 
            // 
            // 
            this.PurchasePriceTextBox.CustomButton.Image = null;
            this.PurchasePriceTextBox.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.PurchasePriceTextBox.CustomButton.Name = "";
            this.PurchasePriceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PurchasePriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PurchasePriceTextBox.CustomButton.TabIndex = 1;
            this.PurchasePriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PurchasePriceTextBox.CustomButton.UseSelectable = true;
            this.PurchasePriceTextBox.CustomButton.Visible = false;
            this.PurchasePriceTextBox.Lines = new string[0];
            this.PurchasePriceTextBox.Location = new System.Drawing.Point(450, 211);
            this.PurchasePriceTextBox.MaxLength = 32767;
            this.PurchasePriceTextBox.Name = "PurchasePriceTextBox";
            this.PurchasePriceTextBox.PasswordChar = '\0';
            this.PurchasePriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PurchasePriceTextBox.SelectedText = "";
            this.PurchasePriceTextBox.SelectionLength = 0;
            this.PurchasePriceTextBox.SelectionStart = 0;
            this.PurchasePriceTextBox.ShortcutsEnabled = true;
            this.PurchasePriceTextBox.Size = new System.Drawing.Size(181, 23);
            this.PurchasePriceTextBox.TabIndex = 3;
            this.PurchasePriceTextBox.UseSelectable = true;
            this.PurchasePriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PurchasePriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(279, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Sizes";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(-371, -31);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(48, 33);
            this.dataGridView4.TabIndex = 4;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.ItemHeight = 23;
            this.SupplierComboBox.Location = new System.Drawing.Point(412, 176);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(220, 29);
            this.SupplierComboBox.TabIndex = 2;
            this.SupplierComboBox.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(651, 145);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Product Category";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(708, 180);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Supplier";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(671, 215);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Purchase Price";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(694, 244);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Sales Price";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-424, -292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 36);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-424, -221);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(10, 36);
            this.dataGridView2.TabIndex = 4;
            // 
            // DeSelectSizeinbutton
            // 
            this.DeSelectSizeinbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeSelectSizeinbutton.Location = new System.Drawing.Point(23, 155);
            this.DeSelectSizeinbutton.Name = "DeSelectSizeinbutton";
            this.DeSelectSizeinbutton.Size = new System.Drawing.Size(47, 43);
            this.DeSelectSizeinbutton.TabIndex = 9;
            this.DeSelectSizeinbutton.Text = "D";
            this.DeSelectSizeinbutton.UseVisualStyleBackColor = true;
            // 
            // SelectAllSizebutton
            // 
            this.SelectAllSizebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectAllSizebutton.Location = new System.Drawing.Point(23, 111);
            this.SelectAllSizebutton.Name = "SelectAllSizebutton";
            this.SelectAllSizebutton.Size = new System.Drawing.Size(47, 43);
            this.SelectAllSizebutton.TabIndex = 9;
            this.SelectAllSizebutton.Text = "S";
            this.SelectAllSizebutton.UseVisualStyleBackColor = true;
            // 
            // DefineProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectAllSizebutton);
            this.Controls.Add(this.DeSelectSizeinbutton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.SizesDataGridView);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DefineNewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SupplierComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.PurchasePriceTextBox);
            this.Controls.Add(this.SalesPriceTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimizeBox = false;
            this.Name = "DefineProductScreen";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Product Definition";
            this.Load += new System.EventHandler(this.DefineProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SizesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox ProductNameTextBox;
        private MetroFramework.Controls.MetroComboBox CategoryComboBox;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroButton DefineNewButton;
        private MetroFramework.Controls.MetroButton CloseButton;
        private System.Windows.Forms.DataGridView SizesDataGridView;
        private MetroFramework.Controls.MetroTextBox SalesPriceTextBox;
        private MetroFramework.Controls.MetroTextBox PurchasePriceTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private MetroFramework.Controls.MetroComboBox SupplierComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button DeSelectSizeinbutton;
        private System.Windows.Forms.Button SelectAllSizebutton;
    }
}