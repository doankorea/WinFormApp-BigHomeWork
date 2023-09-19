using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Principal;

namespace fa_icon_demo
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        //check user password
        public bool checkAccount(String account)
        {
            return Regex.IsMatch(account, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(String email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false
                    ;
            }
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,30}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();

        private void btnsignup_Click(object sender, EventArgs e)
        {
            String user = txtuser.Text;
            String passWord = txtpass.Text;
            String checkPasswor = txtcheckpass.Text;
            String email = txtemail.Text;
            if (!checkAccount(user))
            {
                MessageBox.Show("account error");
                return;
            }
            if (!checkAccount(passWord))
            {
                MessageBox.Show("Try again password");
                return;
            }
            if (passWord != checkPasswor)
            {
                MessageBox.Show("Try again password");
                return;

            }
            if (!checkEmail(email))
            {
                MessageBox.Show("email in valid");
                return;
            }
            if (modify.Accounts("SELECT * FROM Account WHERE email= '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email already exists");
                return;
            }
            try
            {
                string query = "INSERT INTO Account VALUES ('" + user + "','" + passWord + "','" + email + "')";
                modify.Command(query);
                MessageBox.Show("Success");
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void iconButton6_MouseEnter(object sender, EventArgs e)
        {
            iconButton6.BackColor = Color.Silver;
        }
    }
}
