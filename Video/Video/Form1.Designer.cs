namespace Video
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pvideo = new System.Windows.Forms.PictureBox();
            this.CBlista = new System.Windows.Forms.ComboBox();
            this.Biniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pvideo)).BeginInit();
            this.SuspendLayout();
            // 
            // Pvideo
            // 
            this.Pvideo.BackColor = System.Drawing.Color.White;
            this.Pvideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pvideo.Location = new System.Drawing.Point(12, 8);
            this.Pvideo.Name = "Pvideo";
            this.Pvideo.Size = new System.Drawing.Size(770, 385);
            this.Pvideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pvideo.TabIndex = 0;
            this.Pvideo.TabStop = false;
            // 
            // CBlista
            // 
            this.CBlista.FormattingEnabled = true;
            this.CBlista.Location = new System.Drawing.Point(13, 414);
            this.CBlista.Name = "CBlista";
            this.CBlista.Size = new System.Drawing.Size(272, 24);
            this.CBlista.TabIndex = 1;
            // 
            // Biniciar
            // 
            this.Biniciar.Location = new System.Drawing.Point(692, 399);
            this.Biniciar.Name = "Biniciar";
            this.Biniciar.Size = new System.Drawing.Size(90, 38);
            this.Biniciar.TabIndex = 2;
            this.Biniciar.Text = "INICIAR";
            this.Biniciar.UseVisualStyleBackColor = true;
            this.Biniciar.Click += new System.EventHandler(this.Biniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Biniciar);
            this.Controls.Add(this.CBlista);
            this.Controls.Add(this.Pvideo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pvideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pvideo;
        private System.Windows.Forms.ComboBox CBlista;
        private System.Windows.Forms.Button Biniciar;
    }
}

