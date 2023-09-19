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
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace fa_icon_demo
{
    public partial class Login : Form
    {
        public Login()
        {

            
            this.DoubleBuffered = true;
            InitializeComponent();
            if(Properties.Settings.Default.UserName != "" && Properties.Settings.Default.PassWord!= "")
            {
                txtuser.Text = Properties.Settings.Default.UserName;
                txtpass.Text = Properties.Settings.Default.PassWord;
            }

        }
        //connect sql




        Modify modify = new Modify();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            String userName;
            String passWord;
            userName= txtuser.Text;
            passWord= txtpass.Text;
            //user to restrick the user to enter their UserName of PassWord
            if(userName== "" || passWord== "")
            {
                MessageBox.Show("Invalid User Name or Password");
            }
            else
            {

                string query = "SELECT * From Account WHERE username = '" + userName + "' AND password = '" + passWord + "'";
                if (modify.Accounts(query).Count!=0)
                {
                    MessageBox.Show("Success","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Home Home = new Home();
                    Home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password");
                }




            }
        }


        private void lblcreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }

        private void cbrmb_CheckedChanged(object sender, EventArgs e)
        {
            if (cbrmb.Checked)
            {
                String username= txtuser.Text;
                String passWord= txtpass.Text;
                Properties.Settings.Default.UserName = username;
                Properties.Settings.Default.PassWord = passWord;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.PassWord = "";
                Properties.Settings.Default.Save();
            }

        }

        private void lblforgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot forgot = new Forgot();
            this.Hide();
            forgot.ShowDialog();
            this.Close();
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
