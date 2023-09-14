using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fa_icon_demo
{
    public partial class Forgot : Form
    {
        public Forgot()
        {

            InitializeComponent();
           

        }

        Modify modify = new Modify();
        private void btnrcv_Click(object sender, EventArgs e)
        {
            string email= txtemail.Text;
            if (email.Trim() == "" ) {
                MessageBox.Show("Enter your email");
            }
            else
            {
                String query = ("SELECT * FROM Account WHERE email= '"+email+"'");
                if(modify.Accounts(query).Count != 0)
                {
                    txtpass.Text = modify.Accounts(query)[0].Password;
                }
                else
                {
                    MessageBox.Show("email has not been registered");
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
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

        private void iconButton6_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void iconButton6_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
