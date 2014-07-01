﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLibrary;
using TestApplication.Properties;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Keywords keywd = new TestLibrary.Keywords();
            label1.Text = keywd.labelText;
            label1.Text += StKeywords.labelText + " [" + this.textBox1.Text + "]";

            int i = getinteger();

            pictureBox1.Image = Resources.日本語ファイル;
        }

        private int getinteger()
        {
            return 100;
        }
    }
}
