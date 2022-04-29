using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_EscapeRoom
{
    public partial class NoPista : UserControl
    {
        public NoPista()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Parent.Visible = false;
        }
    }
}
