using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_EscapeRoom
{
    public partial class ucCajon : UserControl
    {
        string message = "";
        string title = "";
        private PictureBox pmMargen1;
        Sonido miSonido = new Sonido();

        public ucCajon(PictureBox pmMargen1)
        {
            InitializeComponent();
            this.pmMargen1 = pmMargen1;
        }
        private void ucCajon_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void pbFigura1_DragEnter(object sender, DragEventArgs e)
        {
            MetodoDragEnter(sender, e);
        }

        private void PBFigura2_DragEnter(object sender, DragEventArgs e)
        {
            MetodoDragEnter(sender, e);
        }
        private void pbFigura3_DragEnter(object sender, DragEventArgs e)
        {
            MetodoDragEnter(sender, e);
        }

        private void pbFigura4_DragEnter(object sender, DragEventArgs e)
        {
            MetodoDragEnter(sender, e);
        }

        private void pbFigura1_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pbFigura1.Image = getPicture;
        }

        
        private void pbFigura3_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pbFigura3.Image = getPicture;
        }

        private void pbFigura4_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pbFigura4.Image = getPicture;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ComprobarResultado())
            {

                pmMargen1.Visible = true;
                pmMargen1.Enabled = true;
                this.Parent.Visible = false;
            }
            else
            {
                FotoRam();
            }
        }

        public bool ComprobarResultado()
        {
            if (pbFigura4.Image == pictureBox7.Image && pbFigura1.Image == pictureBox5.Image && PBFigura2.Image == pictureBox3.Image && pbFigura3.Image == pictureBox11.Image)
            {
                miSonido.PruebaConseguida();
                message = "FELICIDADES, has conseguido resolver las imágenes";
                title = "Juego terminado";
                MessageBox.Show(message, title);

                return true;
            }

            else
            {
                miSonido.Error();
                message = "Secuencia incorrecta, vuelve a intentarlo";
                title = "INCORRECTO";
                MessageBox.Show(message, title);

                return false;
            }
        }

        public void Inicio()
        {
          
            pictureBox10.AllowDrop = true;
            pictureBox9.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox1.AllowDrop = true;

            pbFigura1.AllowDrop = true;
            PBFigura2.AllowDrop = true;
            pbFigura3.AllowDrop = true;
            pbFigura4.AllowDrop = true;

            FotoRam();

        }

        private void btSalir_Click(object sender, EventArgs e)
        {

            message = "¿Quieres cerrar la pantalla de imágenes?";
            title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Parent.Visible = false;
            }
        }

        private void pbFigura2_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            PBFigura2.Image = getPicture;
        }

        private void pbFigura2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        public void MetodoDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        public void FotoRam()
        {
            pbFigura4.Image = Properties.Resources.ram;
            pbFigura1.Image = Properties.Resources.ram;
            pbFigura3.Image = Properties.Resources.ram;
            PBFigura2.Image = Properties.Resources.ram;

        }
    }
}