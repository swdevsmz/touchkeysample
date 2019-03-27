﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchKeySample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
            textBox1.Focus();
            textBox2.Focus();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Focus");
        }
    }
}
