﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Öğrendim_Click(object sender, EventArgs e)
        {
     
            Form2 f2 = new Form2();
            
            f2.Show();
            this.Hide();
          
           
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void listBoxT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
