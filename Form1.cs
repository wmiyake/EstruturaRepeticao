﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstudoEstruturasRepeticao
{
    public partial class frmEstruturaRepeticao : Form
    {
        public frmEstruturaRepeticao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txbNumero.Text);
            /*for (int i = 0; i <= 10; i++)
            {
                lsbResultados.Items.Add(string.Format("{0} x {1} = {2}", numero, i, numero * i));
            }*/
            int i = 0;
            while (i <= 10)
            {
                lsbResultados.Items.Add(string.Format("{0} x {1} = {2}", numero, i, numero * i));
            }
        }
    }
}
