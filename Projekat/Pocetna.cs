﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class Pocetna : MetroFramework.Forms.MetroForm
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Admin Form = new Admin();
            this.Hide();
            Form.ShowDialog();
            this.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Prezentacija form = new Prezentacija(username);
            //this.Hide();
            //form.ShowDialog();
            //this.Show();
        }
    }
}
