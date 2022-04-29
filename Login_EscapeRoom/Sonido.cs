using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Login_EscapeRoom
{
    class Sonido
    {
        public Sonido()
        {
        }

        public void AplausoFinal()
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Aplauso);
                simpleSound.Play();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR ", e.ToString());
            }          
        }
        public void PruebaConseguida()
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._07043047);
                simpleSound.Play();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR ", e.ToString());
            }
        }
        public void Error()
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.fail_buzzer_02);
                simpleSound.Play();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR ", e.ToString());
            }
        }
    }   
}
