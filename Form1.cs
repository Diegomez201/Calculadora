using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnuno_Click(object sender, EventArgs e)
        {
            // si el textbox1 esta vacio pongale el calor de "1"

            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "1";
            }

            else if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "1";
            }

            else
            {
                MessageBox.Show("ya estan completos los numeros");
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "2";
            }
            else if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "2";
            }

            else
            {
                MessageBox.Show("ya estan completos los numeros");
            }
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "3";
            }

            else if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "3";
            }

            else
            {
                MessageBox.Show("ya estan completos los numeros");
            }
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "4";
            }

            else if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "4";
            }

            else
            {
                MessageBox.Show("ya estan completos los numeros");
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "5";
            }

            else if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "5";
            }

            else
            {
                MessageBox.Show("ya estan completos los numeros");
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "6";
            }

            else if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "6";
            }

            else
            {
                MessageBox.Show("ya estan completos los numeros");
            }
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {

            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "7";
            }

            else if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "7";
            }

            else
            {
                MessageBox.Show("ya estan completos los numeros");
            }
        }

        private void btnocho_Click(object sender, EventArgs e)
        {

            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "8";
            }

            else if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "8";
            }

            else
            {
                MessageBox.Show("ya estan completos los numeros");
            }
        }

        private void btnnueve_Click(object sender, EventArgs e)
        {

            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "9";
            }

            else if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "9";
            }

            else
            {
                MessageBox.Show("ya estan completos los numeros");
            }
        }

        private void btncero_Click(object sender, EventArgs e)
        {

            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "0";
            }

            else if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "0";
            }

            else
            {
                MessageBox.Show("ya estan completos los numeros");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Text = "";//string.empty
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int suma = Convert.ToInt32(txtNumero1.Text) + Convert.ToInt32(txtNumero2.Text);

            txtResultado.Text = Convert.ToString(suma); 
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            int suma = Convert.ToInt32(txtNumero1.Text) - Convert.ToInt32(txtNumero2.Text);

            txtResultado.Text = Convert.ToString(suma);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var suma = Convert.ToInt32(txtNumero1.Text) * Convert.ToInt32(txtNumero2.Text);

            txtResultado.Text = Convert.ToString(suma);

        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "")
            {
                MessageBox.Show("debe ingresar un valor para el numero 1");
                return;
            }

            var acumulador = 1;
            var numero = int.Parse(txtNumero1.Text);

            for (int i=1; i <= numero; i++)
            {
                acumulador = acumulador * i;

            }

            txtResultado.Text = acumulador.ToString();


        }
    }
}
