﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotemMuseuParaInteracaoDoPublico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TecladoVirtual tecladoVirtual = new TecladoVirtual();
            tecladoVirtual.Visible = true;
            textBox1.Focus();
        }
    }
}
