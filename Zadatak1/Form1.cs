﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
            if (radioButtonAvion.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz avionom.";
            }

            if (radioButtonAutobus.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz autobusom.";
            }

            if (radioButtonVlastiti.Checked)
            {
                textBox1.Text = "Odabrali ste vlastiti prijevoz.";
            }

        }
    }
}
