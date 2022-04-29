
namespace Login_EscapeRoom
{
    partial class ucCodigo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbYoda = new System.Windows.Forms.PictureBox();
            this.lbYoda = new System.Windows.Forms.Label();
            this.pbCodigo = new System.Windows.Forms.PictureBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.bntExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbYoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbYoda
            // 
            this.pbYoda.BackColor = System.Drawing.Color.Transparent;
            this.pbYoda.Image = global::Login_EscapeRoom.Properties.Resources.baby_yoda_11;
            this.pbYoda.Location = new System.Drawing.Point(1273, 275);
            this.pbYoda.Name = "pbYoda";
            this.pbYoda.Size = new System.Drawing.Size(702, 613);
            this.pbYoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbYoda.TabIndex = 17;
            this.pbYoda.TabStop = false;
            this.pbYoda.Click += new System.EventHandler(this.pbYoda_Click);
            // 
            // lbYoda
            // 
            this.lbYoda.AutoSize = true;
            this.lbYoda.BackColor = System.Drawing.Color.Transparent;
            this.lbYoda.Font = new System.Drawing.Font("Digital-7", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbYoda.ForeColor = System.Drawing.Color.Black;
            this.lbYoda.Location = new System.Drawing.Point(128, 335);
            this.lbYoda.Name = "lbYoda";
            this.lbYoda.Size = new System.Drawing.Size(1149, 320);
            this.lbYoda.TabIndex = 18;
            this.lbYoda.Text = "Si el código quieres saber,\r\n de binario a decimal debes pasar.\r\n\r\nPulsa en Yoda " +
    "para continuar.";
            // 
            // pbCodigo
            // 
            this.pbCodigo.Image = global::Login_EscapeRoom.Properties.Resources.descarga;
            this.pbCodigo.Location = new System.Drawing.Point(345, 201);
            this.pbCodigo.Name = "pbCodigo";
            this.pbCodigo.Size = new System.Drawing.Size(749, 254);
            this.pbCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCodigo.TabIndex = 16;
            this.pbCodigo.TabStop = false;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigo.Font = new System.Drawing.Font("Digital-7", 200F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCodigo.ForeColor = System.Drawing.Color.Black;
            this.lbCodigo.Location = new System.Drawing.Point(331, 509);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(1339, 263);
            this.lbCodigo.TabIndex = 14;
            this.lbCodigo.Text = "0-1001-101-110";
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.Transparent;
            this.bntExit.BackgroundImage = global::Login_EscapeRoom.Properties.Resources.Letter_X_black_34834;
            this.bntExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntExit.Location = new System.Drawing.Point(1722, 967);
            this.bntExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(148, 80);
            this.bntExit.TabIndex = 20;
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // ucCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Login_EscapeRoom.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.pbYoda);
            this.Controls.Add(this.lbYoda);
            this.Controls.Add(this.pbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Name = "ucCodigo";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.ucCodigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbYoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbYoda;
        private System.Windows.Forms.Label lbYoda;
        private System.Windows.Forms.PictureBox pbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button bntExit;
    }
}
