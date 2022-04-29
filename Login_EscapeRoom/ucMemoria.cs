using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_EscapeRoom
{
    public partial class ucMemoria : UserControl
    {
        private PictureBox pbMargen3;
        private PictureBox pbMargen2;
        Sonido miSonido = new Sonido();
        public ucMemoria()
        {
            InitializeComponent();
        }

        public ucMemoria(PictureBox pbMargen3, PictureBox pbMargen2)
        {
            this.pbMargen3 = pbMargen3;
            this.pbMargen2 = pbMargen2;
        }


        private void CajaFuerte_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Introduce la secuencia numérica correcta y pulsa intro para abrir la caja fuerte");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "¿Quieres cerrar la pantalla y volver a la habitación?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                this.Parent.Visible = false;

            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "1-";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 7)
            {
                miSonido.Error();
                MessageBox.Show("La secuencia numércia es de 4 dígitos");
            }
        }

        public bool ComprobarResultado()
        {

            if (textBox1.Text == "0-9-5-6")
            {
                
                return true;
            }
            else
            {
                textBox1.Clear();
                return false;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 7)
            {
                miSonido.Error();
                MessageBox.Show("Error, la secuencia tienen 4 números");
            }
        }

        private void ucMemoria_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "2-";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "3-";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "4-";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "5-";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "6-";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "7-";
            }
            else
            {
                textBox1.Text += "7";
            }
        }


        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "8-";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "9-";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ComprobarResultado() == true)
            {
               
                MessageBox.Show("Felicidades, prueba superada");
                miSonido.PruebaConseguida();
                
                this.Parent.Visible = false;
            }
            else
            {
                miSonido.Error();

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "0-";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void btnC_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
