namespace KPointofSales
{
    partial class LoginForm
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNametxtBox = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordtxtBox = new System.Windows.Forms.TextBox();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(217, 82);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(57, 13);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "UserName";
            // 
            // UserNametxtBox
            // 
            this.UserNametxtBox.Location = new System.Drawing.Point(293, 79);
            this.UserNametxtBox.Name = "UserNametxtBox";
            this.UserNametxtBox.Size = new System.Drawing.Size(216, 20);
            this.UserNametxtBox.TabIndex = 0;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Loginbtn.Location = new System.Drawing.Point(293, 153);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(216, 35);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(217, 119);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordtxtBox
            // 
            this.PasswordtxtBox.Location = new System.Drawing.Point(293, 116);
            this.PasswordtxtBox.Name = "PasswordtxtBox";
            this.PasswordtxtBox.PasswordChar = '*';
            this.PasswordtxtBox.Size = new System.Drawing.Size(216, 20);
            this.PasswordtxtBox.TabIndex = 1;
            this.PasswordtxtBox.UseSystemPasswordChar = true;
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exitbtn.Location = new System.Drawing.Point(293, 203);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(216, 33);
            this.Exitbtn.TabIndex = 3;
            this.Exitbtn.Text = "Exit Application";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KPointofSales.Properties.Resources.Applogin;
            this.pictureBox1.Location = new System.Drawing.Point(23, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.PasswordtxtBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNametxtBox);
            this.Controls.Add(this.UserNameLabel);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Point of Sales - Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNametxtBox;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordtxtBox;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

