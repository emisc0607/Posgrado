namespace T5
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
            this.Bopen = new System.Windows.Forms.Button();
            this.Pin = new System.Windows.Forms.PictureBox();
            this.Pout = new System.Windows.Forms.PictureBox();
            this.Bprocess = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binariaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.coloresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umbralizaciónDeOtsuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Pin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pout)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bopen
            // 
            this.Bopen.Location = new System.Drawing.Point(147, 427);
            this.Bopen.Name = "Bopen";
            this.Bopen.Size = new System.Drawing.Size(87, 51);
            this.Bopen.TabIndex = 0;
            this.Bopen.Text = "Comparar";
            this.Bopen.UseVisualStyleBackColor = true;
            this.Bopen.Click += new System.EventHandler(this.Bopen_Click);
            // 
            // Pin
            // 
            this.Pin.BackColor = System.Drawing.Color.White;
            this.Pin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pin.Location = new System.Drawing.Point(12, 51);
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(380, 370);
            this.Pin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pin.TabIndex = 1;
            this.Pin.TabStop = false;
            // 
            // Pout
            // 
            this.Pout.BackColor = System.Drawing.Color.White;
            this.Pout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pout.Location = new System.Drawing.Point(408, 51);
            this.Pout.Name = "Pout";
            this.Pout.Size = new System.Drawing.Size(380, 370);
            this.Pout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pout.TabIndex = 2;
            this.Pout.TabStop = false;
            // 
            // Bprocess
            // 
            this.Bprocess.Location = new System.Drawing.Point(539, 427);
            this.Bprocess.Name = "Bprocess";
            this.Bprocess.Size = new System.Drawing.Size(99, 51);
            this.Bprocess.TabIndex = 3;
            this.Bprocess.Text = "Procesar";
            this.Bprocess.UseVisualStyleBackColor = true;
            this.Bprocess.Click += new System.EventHandler(this.Bprocess_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rToolStripMenuItem,
            this.gToolStripMenuItem,
            this.bToolStripMenuItem,
            this.escalaDeGrisesToolStripMenuItem,
            this.binariaToolStripMenuItem,
            this.negativaToolStripMenuItem,
            this.umbralizaciónDeOtsuToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.rToolStripMenuItem.Text = "R";
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.gToolStripMenuItem.Text = "G";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.bToolStripMenuItem.Text = "B";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de grises";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // binariaToolStripMenuItem
            // 
            this.binariaToolStripMenuItem.Name = "binariaToolStripMenuItem";
            this.binariaToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.binariaToolStripMenuItem.Text = "Binaria";
            this.binariaToolStripMenuItem.Click += new System.EventHandler(this.binariaToolStripMenuItem_Click);
            // 
            // negativaToolStripMenuItem
            // 
            this.negativaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escalaDeGrisesToolStripMenuItem1,
            this.binariaToolStripMenuItem1,
            this.coloresToolStripMenuItem});
            this.negativaToolStripMenuItem.Name = "negativaToolStripMenuItem";
            this.negativaToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.negativaToolStripMenuItem.Text = "Negativa";
            // 
            // escalaDeGrisesToolStripMenuItem1
            // 
            this.escalaDeGrisesToolStripMenuItem1.Name = "escalaDeGrisesToolStripMenuItem1";
            this.escalaDeGrisesToolStripMenuItem1.Size = new System.Drawing.Size(196, 26);
            this.escalaDeGrisesToolStripMenuItem1.Text = "Escala de grises";
            this.escalaDeGrisesToolStripMenuItem1.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem1_Click);
            // 
            // binariaToolStripMenuItem1
            // 
            this.binariaToolStripMenuItem1.Name = "binariaToolStripMenuItem1";
            this.binariaToolStripMenuItem1.Size = new System.Drawing.Size(196, 26);
            this.binariaToolStripMenuItem1.Text = "Binaria";
            this.binariaToolStripMenuItem1.Click += new System.EventHandler(this.binariaToolStripMenuItem1_Click);
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.coloresToolStripMenuItem.Text = "Colores";
            this.coloresToolStripMenuItem.Click += new System.EventHandler(this.coloresToolStripMenuItem_Click);
            // 
            // umbralizaciónDeOtsuToolStripMenuItem
            // 
            this.umbralizaciónDeOtsuToolStripMenuItem.Name = "umbralizaciónDeOtsuToolStripMenuItem";
            this.umbralizaciónDeOtsuToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.umbralizaciónDeOtsuToolStripMenuItem.Text = "Umbralización de Otsu";
            this.umbralizaciónDeOtsuToolStripMenuItem.Click += new System.EventHandler(this.umbralizaciónDeOtsuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.Bprocess);
            this.Controls.Add(this.Pout);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.Bopen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pout)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bopen;
        private System.Windows.Forms.PictureBox Pin;
        private System.Windows.Forms.PictureBox Pout;
        private System.Windows.Forms.Button Bprocess;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binariaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem coloresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umbralizaciónDeOtsuToolStripMenuItem;
    }
}

