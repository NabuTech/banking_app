﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Prototype
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnCustomerManangement_Click(object sender, EventArgs e)
        {
            CustomerManagmentForm customerManagmentForm = new CustomerManagmentForm();

            customerManagmentForm.Show();

            this.Hide();
        }
    }
}
