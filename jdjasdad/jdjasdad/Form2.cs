﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jdjasdad
{
    public partial class Curso_programacion : Form
    {
        public Curso_programacion()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if(c.Checked==true)
            {
                conteo++;
            }
            if (basic.Checked==true)
            {
                conteo++;
            }
            if(credito.Checked==true)
            {
                seleccion = "Tarjeta credito";
            }
            else
            {
                seleccion = "PayPal";
            }
        }
    }
}
