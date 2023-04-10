namespace T4
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
            this.Bprocess = new System.Windows.Forms.Button();
            this.PBimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBimage)).BeginInit();
            this.SuspendLayout();
            // 
            // Bprocess
            // 
            this.Bprocess.Location = new System.Drawing.Point(326, 429);
            this.Bprocess.Name = "Bprocess";
            this.Bprocess.Size = new System.Drawing.Size(141, 79);
            this.Bprocess.TabIndex = 0;
            this.Bprocess.Text = "Procesar";
            this.Bprocess.UseVisualStyleBackColor = true;
            this.Bprocess.Click += new System.EventHandler(this.Bprocess_Click);
            // 
            // PBimage
            // 
            this.PBimage.BackColor = System.Drawing.Color.White;
            this.PBimage.Location = new System.Drawing.Point(12, 12);
            this.PBimage.Name = "PBimage";
            this.PBimage.Size = new System.Drawing.Size(776, 397);
            this.PBimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBimage.TabIndex = 1;
            this.PBimage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.PBimage);
            this.Controls.Add(this.Bprocess);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PBimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bprocess;
        private System.Windows.Forms.PictureBox PBimage;
    }
}

