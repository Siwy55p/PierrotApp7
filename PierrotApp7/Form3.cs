﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PierrotApp7
{
    public partial class Form3 : Form
    {
        public static string Komunikat;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.Text += Komunikat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
