﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonApp_V1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void BTNLogin_Click(object sender, EventArgs e)
        {
            if (TBUsername.Text=="admin" && TBUserPassword.Text=="password")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos incorrectos","Error");
            }
        }


    }
}
