using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BtnHideShow.Text == "Show")
            {
                BtnHideShow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                BtnHideShow.Text = "Show";
                txtPassword.PasswordChar ='*';
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                btnlogin.Enabled = true;
            }
            else
            {
                btnlogin.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogin.Enabled = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Awantika" && txtPassword.Text == "pass")
            {
                dashboard db = new dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Username and Password.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
