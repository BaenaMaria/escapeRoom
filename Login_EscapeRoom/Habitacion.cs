using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_EscapeRoom
{
   
    public partial class Habitacion : Form
    {
        Sonido miSonido = new Sonido();
        string panel = "";
        
       
        
        public Habitacion()
        {
            InitializeComponent();
            Pantalla();
            Preguntas();
            Cajon();
            Memoria();
            Login();
            NoPista();

        }

     
        private void pbBillete_Click(object sender, EventArgs e)
        {
            string panel = "panel3";


            Panel(panel);

        }



        private void pbPantallaOrdenador_Click(object sender, EventArgs e)
        {
            string panel = "panel2";


            Panel(panel);
        }

        private void pbCajon_Click(object sender, EventArgs e)
        {
            this.Controls["panel6"].Visible = true;

            pmMargen1.AllowDrop = true;
            pbPantallaOrdenador.AllowDrop = true;

        }

        private void Habitacion_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void pbPantallaOrdenador_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbPantallaOrdenador_DragDrop(object sender, DragEventArgs e)
        {
            string panel = "panel9";


            Panel(panel);
        }

       
        private void pbArmario_Click(object sender, EventArgs e)
        {
            miSonido.PruebaConseguida();
            System.Threading.Thread.Sleep(2000);
            pbMargen2.Visible = true;
            pbArmario.Image = Properties.Resources._50420558_hand_drawn_wardrobe_sketch_room_interior_with_clothes_;
        }

        private void pbMargen2_Click(object sender, EventArgs e)
        {


            string panel = "panel1";


            Panel(panel);


        }

        

      private void Inicio()
      {
            pmMargen1.Visible = false;
            pbMargen2.Visible = false;
            pbMargen3.Visible = false;
           
            pbArmario.Visible = true;
            pbArmario.Enabled = true;

        }



        

        public void Memoria()
        {

            Panel pan = new Panel();
            pan.Name = "panel1";


            ucMemoria uc = new ucMemoria();
            uc.Name = "ucMemoria";


            pan.Controls.Add(uc);
            this.Controls.Add(pan);


            pan.Size = new Size(this.Width - 60, this.Height - 60);
            pan.Location = new Point(30, 30);


            uc.Location = new Point((int)(pan.Width - uc.Width) / 2, (int)(pan.Height - uc.Height) / 2);

            pan.BringToFront();

            pan.Hide();



        }
        public void Pantalla()
        {

            Panel pan = new Panel();
            pan.Name = "panel2";


            ucPantalla uc = new ucPantalla();
            uc.Name = "ucPantalla";


            pan.Controls.Add(uc);
            this.Controls.Add(pan);


            pan.Size = new Size(this.Width - 60, this.Height - 60);
            pan.Location = new Point(30, 30);


            uc.Location = new Point((int)(pan.Width - uc.Width) / 2, (int)(pan.Height - uc.Height) / 2);

            pan.BringToFront();

            pan.Hide();



        }

        public void Preguntas()
        {


            Panel pan = new Panel();
            pan.Name = "panel3";


            ucPregunta uc = new ucPregunta();
            uc.Name = "ucPregunta";


            pan.Controls.Add(uc);
            this.Controls.Add(pan);


            pan.Size = new Size(this.Width - 60, this.Height - 60);
            pan.Location = new Point(30, 30);


            uc.Location = new Point((int)(pan.Width - uc.Width) / 2, (int)(pan.Height - uc.Height) / 2);

            pan.BringToFront();

            pan.Hide();


        }
        public void Cajon()
        {


            Panel pan = new Panel();
            pan.Name = "panel6";


            ucCajon uc= new ucCajon(pmMargen1);
            uc.Name = "ucCajon";


            pan.Controls.Add(uc);
            this.Controls.Add(pan);


            pan.Size = new Size(this.Width - 60, this.Height - 60);
            pan.Location = new Point(30, 30);


            uc.Location = new Point((int)(pan.Width - uc.Width) / 2, (int)(pan.Height - uc.Height) / 2);

            pan.BringToFront();

            pan.Hide();


        }
        public void Login()
        {


            Panel pan = new Panel();
            pan.Name = "panel9";


            ucLogin uc = new ucLogin ();
            uc.Name = "ucLogin";


            pan.Controls.Add(uc);
            this.Controls.Add(pan);


            pan.Size = new Size(this.Width - 60, this.Height - 60);
            pan.Location = new Point(30, 30);


            uc.Location = new Point((int)(pan.Width - uc.Width) / 2, (int)(pan.Height - uc.Height) / 2);

            pan.BringToFront();

            pan.Hide();


        }
        public void NoPista()
        {


            Panel pan = new Panel();
            pan.Name = "panel12";


            NoPista uc = new NoPista();
            uc.Name = "ucLogin";


            pan.Controls.Add(uc);
            this.Controls.Add(pan);


            pan.Size = new Size(this.Width - 60, this.Height - 60);
            pan.Location = new Point(30, 30);


            uc.Location = new Point((int)(pan.Width - uc.Width) / 2, (int)(pan.Height - uc.Height) / 2);

            pan.BringToFront();

            pan.Hide();


        }
        private void pmMargen1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arrastrame donde me necesites");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RespuestaMala();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RespuestaMala();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RespuestaMala();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            RespuestaMala();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            RespuestaMala();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            RespuestaMala();
        }

        private void RespuestaMala()
        {
            this.Controls["panel12"].Visible = true;

        }
        private void Panel(string panel)
        {

            this.Controls[panel].Visible = true;

        }
    }
    
}
