namespace ClasificadorBilletes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CBlista = new System.Windows.Forms.ComboBox();
            this.Biniciar = new System.Windows.Forms.Button();
            this.RBbilletes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBMonedas = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Pvideo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pvideo
            // 
            this.Pvideo.BackColor = System.Drawing.Color.White;
            this.Pvideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pvideo.Location = new System.Drawing.Point(12, 27);
            this.Pvideo.Name = "Pvideo";
            this.Pvideo.Size = new System.Drawing.Size(776, 426);
            this.Pvideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pvideo.TabIndex = 0;
            this.Pvideo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CBlista
            // 
            this.CBlista.FormattingEnabled = true;
            this.CBlista.Location = new System.Drawing.Point(12, 469);
            this.CBlista.Name = "CBlista";
            this.CBlista.Size = new System.Drawing.Size(283, 24);
            this.CBlista.TabIndex = 2;
            // 
            // Biniciar
            // 
            this.Biniciar.Location = new System.Drawing.Point(676, 459);
            this.Biniciar.Name = "Biniciar";
            this.Biniciar.Size = new System.Drawing.Size(112, 34);
            this.Biniciar.TabIndex = 3;
            this.Biniciar.Text = "INICIAR";
            this.Biniciar.UseVisualStyleBackColor = true;
            this.Biniciar.Click += new System.EventHandler(this.Biniciar_Click);
            // 
            // RBbilletes
            // 
            this.RBbilletes.AutoSize = true;
            this.RBbilletes.Location = new System.Drawing.Point(6, 23);
            this.RBbilletes.Name = "RBbilletes";
            this.RBbilletes.Size = new System.Drawing.Size(72, 20);
            this.RBbilletes.TabIndex = 4;
            this.RBbilletes.TabStop = true;
            this.RBbilletes.Text = "Billetes";
            this.RBbilletes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBMonedas);
            this.groupBox1.Controls.Add(this.RBbilletes);
            this.groupBox1.Location = new System.Drawing.Point(348, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objeto";
            // 
            // RBMonedas
            // 
            this.RBMonedas.AutoSize = true;
            this.RBMonedas.Location = new System.Drawing.Point(115, 21);
            this.RBMonedas.Name = "RBMonedas";
            this.RBMonedas.Size = new System.Drawing.Size(85, 20);
            this.RBMonedas.TabIndex = 5;
            this.RBMonedas.TabStop = true;
            this.RBMonedas.Text = "Monedas";
            this.RBMonedas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Biniciar);
            this.Controls.Add(this.CBlista);
            this.Controls.Add(this.Pvideo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pvideo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pvideo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox CBlista;
        private System.Windows.Forms.Button Biniciar;
        private System.Windows.Forms.RadioButton RBbilletes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBMonedas;
    }
}

