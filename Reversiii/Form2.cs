﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversiii
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string name1 = "";
        public static string name2 = "";
        
        private void button1_Click(object sender, EventArgs e)
        {   name1 = invoer1.Text;
            name2= invoer2.Text;
            if (string.IsNullOrWhiteSpace(invoer1.Text) ||string.IsNullOrWhiteSpace(invoer2.Text))
            {
                MessageBox.Show("Vul beide velden in!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Form form1 = new Form1();
                form1.Show();
            }
        }
    }
}