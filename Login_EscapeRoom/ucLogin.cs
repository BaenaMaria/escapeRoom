using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_EscapeRoom
{
    public partial class ucLogin : UserControl
    {
        Sonido miSonido = new Sonido();
        public ucLogin()
        {
            InitializeComponent();
            Codigo();

            txtUser.Text = "USUARIO";
            txtPass.Text = "******";
        }

        private void ucLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            btnOk.Focus();
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "¿Quieres cerrar el login y volver a la Escape Room?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                this.Parent.Visible = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.ToUpper() == "DCANO" && txtPass.Text.ToUpper() == "CSHARP")
            {
                
                miSonido.PruebaConseguida();
                string message = "Prueba superada";
                string title = "Felicidades";
                MessageBox.Show(message, title);
                this.Controls["panel15"].Visible = true;
            }
            else
            {
                miSonido.Error();
                string message = "Ususario o contraseña incorrectas";
                string title = "ERROR";
                MessageBox.Show(message, title);
              
            }

        }

        private void comprobarBtnOk()
        {
            btnOk.Enabled = txtUser.Text.Trim().ToUpper() != "" && txtPass.Text.Trim().ToUpper() != "";

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            comprobarBtnOk();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            comprobarBtnOk();
        }
        public void Codigo()
        {

            Panel pan = new Panel();
            pan.Name = "panel15";


            ucCodigo uc = new ucCodigo();
            uc.Name = "ucCodigo";


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
