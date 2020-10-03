using KPointofSales.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using KPointofSales.Screens;

namespace KPointofSales
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public DefineForm()
        {
            MessageBox.Show("Define new things!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                //string constring = ApplicationSetting.ConnectionString();
                //MessageBox.Show(constring);
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Login_VerifyLoginDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", UserNametxtBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", PasswordtxtBox.Text.Trim());
                        con.Open();
                        SqlDataReader srd = cmd.ExecuteReader();
                        if (srd.Read())
                        {
                            //MessageBox.Show("Welcome");
                            this.Hide();
                            DashBoardForm df = new DashBoardForm();
                            df.Show();
                        }
                        else
                        {
                            MessageBox.Show("User Name or Password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
        }
        private bool IsValid()
        {
            if (UserNametxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNametxtBox.Focus();
                return false;
            }
            if (PasswordtxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordtxtBox.Focus();
                return false;
            }
            return true;
        }
    }
}
