using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_EscapeRoom
{
    public partial class ucCodigo : UserControl
    {
        public ucCodigo()
        {
            InitializeComponent();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            string message = "¿Quieres cerrar el código y volver a la Escape Room?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Parent.Visible = false;

            }
        }

        private void pbYoda_Click(object sender, EventArgs e)
        {
          
            CambioForm();
        }

        public void Inicio()
        {
            lbCodigo.Visible = false;
            pbCodigo.Visible = false;
            lbYoda.Visible = true;
            pbYoda.Visible = true;

        }

        public void CambioForm()
        {
            lbCodigo.Visible = true;
            pbCodigo.Visible = true;
            lbYoda.Visible = false;
            pbYoda.Visible = false;
        }

        private void ucCodigo_Load(object sender, EventArgs e)
        {
            Inicio();
        }       
    }
}
