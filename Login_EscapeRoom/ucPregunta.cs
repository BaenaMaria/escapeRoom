using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_EscapeRoom
{
    public partial class ucPregunta : UserControl
    {
        private int contadorFallos;
        private int contador;
        Sonido miSonido = new Sonido();
        

        public ucPregunta()
        {
            InitializeComponent();
            contadorFallos = 0;
            PictureNoVisible();
            Billete();
        }
       

       
        public void ComprobarRespuestas()
        {
            if (tbRespuesta1.Text.ToUpper().Trim() == "ANTARTIDA" || tbRespuesta1.Text.ToUpper().Trim() == "ANTÁRTIDA")
            {
                tbRespuesta1.Visible = false;
                lbPregunta1.Visible = false;
                pictureBox1.Visible = false;
                contador++;

            }
            if (tbRespuesta2.Text.ToUpper().Trim() == "AMAZONAS")
            {
                tbRespuesta2.Visible = false;
                lbPregunta2.Visible = false;
                pictureBox2.Visible = false;
                contador++;
            }
            if (tbRespuesta3.Text.ToUpper().Trim() == "AMERICA" || tbRespuesta3.Text.ToUpper().Trim() == "AMÉRICA" || tbRespuesta3.Text.ToUpper().Trim() == "AMERICANO")
            {
                tbRespuesta3.Visible = false;
                lbPregunta3.Visible = false;
                pictureBox3.Visible = false;
                contador++;
            }
            if (tbRespuesta4.Text.Trim() == "1945" || tbRespuesta4.Text.Trim() == "1.945")
            {
                tbRespuesta4.Visible = false;
                lbPregunta4.Visible = false;
                pictureBox4.Visible = false;
                contador++;
            }
            if (tbRespuesta5.Text.ToUpper().Trim() == "GRECIA")
            {
                tbRespuesta5.Visible = false;
                lbPregunta5.Visible = false;
                pictureBox5.Visible = false;
                contador++;
            }
            if (tbRespuesta6.Text.ToUpper().Trim() == "PACIFICO" || tbRespuesta6.Text.ToUpper().Trim() == "PACÍFICO")
            {
                tbRespuesta6.Visible = false;
                lbPregunta6.Visible = false;
                pictureBox6.Visible = false;
                contador++;
            }


        }
        public void ContadorAciertos()
        {

            if (contador == 6)
            {
                miSonido.PruebaConseguida();
                string message = "Felicidades has superado esta prueba";
                string title = "Conseguido";
                MessageBox.Show(message, title);

                System.Threading.Thread.Sleep(2000);
                this.Controls["panel5"].Visible = true;


            }
            else
            {
                miSonido.Error();
                contador = 0;
                contadorFallos++;
            }
        }
       
        public void Pista()
        {


            if (contadorFallos == 5)
            {
                MessageBox.Show("Te regalo una respuesta, selecciona la pregunta que quieres resolver.....\n De nada :)");
                if (tbRespuesta1.Visible == true)
                {
                    pictureBox1.Visible = true;
                }
                if (tbRespuesta2.Visible == true)
                {
                    pictureBox2.Visible = true;
                }
                if (tbRespuesta3.Visible == true)
                {
                    pictureBox3.Visible = true;
                }
                if (tbRespuesta4.Visible == true)
                {
                    pictureBox4.Visible = true;
                }
                if (tbRespuesta5.Visible == true)
                {
                    pictureBox5.Visible = true;
                }
                if (tbRespuesta6.Visible == true)
                {
                    pictureBox6.Visible = true;
                }
            }

        }

        public void PictureNoVisible()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

        }

        public void ControlVacios()
        {
            if (tbRespuesta1.Text == "" && tbRespuesta2.Text == "" && tbRespuesta3.Text == "" && tbRespuesta4.Text == "" && tbRespuesta5.Text == "" && tbRespuesta6.Text == "")
            {
                MessageBox.Show("Venga, una por lo menos te tienes que saber");
            }

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {

            string message = "¿Quieres cerrar la pantalla de preguntas?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                this.Parent.Visible = false;

            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            ControlVacios();
            ComprobarRespuestas();
            ContadorAciertos();
            if (contadorFallos == 5)
            {

                Pista();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Antártida");
            PictureNoVisible();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amazonas");
            PictureNoVisible();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("América");
            PictureNoVisible();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1945");
            PictureNoVisible();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grecia");
            PictureNoVisible();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pacífico");
            PictureNoVisible();
        }
        public void Billete()
        {

            Panel pan = new Panel();
            pan.Name = "panel5";


            ucBillete uc = new ucBillete();
            uc.Name = "ucBillete";


            pan.Controls.Add(uc);
            this.Controls.Add(pan);


            pan.Size = new Size(this.Width - 60, this.Height - 60);
            pan.Location = new Point(30, 30);


            uc.Location = new Point((int)(pan.Width - uc.Width) / 2, (int)(pan.Height - uc.Height) / 2);

            pan.BringToFront();

            pan.Hide();

        }

    }

}
