using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_EscapeRoom
{
    public partial class ucPantalla : UserControl
    {
        public ucPantalla()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
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

        private void ucPantalla_DragEnter(object sender, DragEventArgs e)
        {
            this.Controls["panel7"].Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

    }
}
