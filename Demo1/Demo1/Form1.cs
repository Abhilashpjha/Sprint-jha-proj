using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.utextbox.Clear();
            this.upassword.Clear();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (utextbox.Text == "Admin" && upassword.Text == "admin123")
            {
                HomePage hmp = new HomePage();
                hmp.Show();
            }
            else if(utextbox.Text == null || upassword.Text == null)
            {
                MessageBox.Show("Please enter user name password");
            }
            else if (utextbox.Text != "Admin" && upassword.Text != "admin123")
            {
                MessageBox.Show("please enter valid id password ");
            }

        }
    }
}

