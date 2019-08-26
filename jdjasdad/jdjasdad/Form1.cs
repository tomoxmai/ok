using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();//cierra el formulario
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if(box.Text=="juancho" &&usu.Text =="123tamarindo")

            {
                MessageBox.Show("jasdjd");
                this.Hide();//escondemos ventana login
                Curso_programacion CursosVentana = new Curso_programacion();
                CursosVentana.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no valido");
                box.Text = "";
                usu.Text = "";
                box.Focus();
            }
        }

        private void Usu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar==(int)Keys.Enter)
            {
                if (box.Text == "juancho" && usu.Text == "123tamarindo")

                {
                    MessageBox.Show("jasdjd");
                    this.Hide();//escondemos ventana login
                    Curso_programacion CursosVentana = new Curso_programacion();
                    CursosVentana.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña no valido");
                    box.Text = "";
                    usu.Text = "";
                    box.Focus();
                }
            }
        }
    }
}
