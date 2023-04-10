namespace T3
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
            this.Bres = new System.Windows.Forms.Button();
            this.RBdeg = new System.Windows.Forms.RadioButton();
            this.RBrad = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tangle = new System.Windows.Forms.TextBox();
            this.Tsin = new System.Windows.Forms.TextBox();
            this.GBunit = new System.Windows.Forms.GroupBox();
            this.GBunit.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bres
            // 
            this.Bres.Location = new System.Drawing.Point(283, 87);
            this.Bres.Name = "Bres";
            this.Bres.Size = new System.Drawing.Size(76, 34);
            this.Bres.TabIndex = 0;
            this.Bres.Text = "Calcular";
            this.Bres.UseVisualStyleBackColor = true;
            this.Bres.Click += new System.EventHandler(this.Bres_Click);
            // 
            // RBdeg
            // 
            this.RBdeg.AutoSize = true;
            this.RBdeg.Checked = true;
            this.RBdeg.Location = new System.Drawing.Point(43, 56);
            this.RBdeg.Name = "RBdeg";
            this.RBdeg.Size = new System.Drawing.Size(73, 20);
            this.RBdeg.TabIndex = 1;
            this.RBdeg.TabStop = true;
            this.RBdeg.Text = "Grados";
            this.RBdeg.UseVisualStyleBackColor = true;
            // 
            // RBrad
            // 
            this.RBrad.AutoSize = true;
            this.RBrad.Location = new System.Drawing.Point(43, 30);
            this.RBrad.Name = "RBrad";
            this.RBrad.Size = new System.Drawing.Size(87, 20);
            this.RBrad.TabIndex = 2;
            this.RBrad.Text = "Radianes";
            this.RBrad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Angulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seno";
            // 
            // Tangle
            // 
            this.Tangle.Location = new System.Drawing.Point(292, 29);
            this.Tangle.Name = "Tangle";
            this.Tangle.Size = new System.Drawing.Size(100, 22);
            this.Tangle.TabIndex = 5;
            // 
            // Tsin
            // 
            this.Tsin.Location = new System.Drawing.Point(292, 59);
            this.Tsin.Name = "Tsin";
            this.Tsin.Size = new System.Drawing.Size(100, 22);
            this.Tsin.TabIndex = 6;
            // 
            // GBunit
            // 
            this.GBunit.Controls.Add(this.RBrad);
            this.GBunit.Controls.Add(this.RBdeg);
            this.GBunit.Location = new System.Drawing.Point(12, 21);
            this.GBunit.Name = "GBunit";
            this.GBunit.Size = new System.Drawing.Size(200, 100);
            this.GBunit.TabIndex = 7;
            this.GBunit.TabStop = false;
            this.GBunit.Text = "Unidades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 132);
            this.Controls.Add(this.GBunit);
            this.Controls.Add(this.Tsin);
            this.Controls.Add(this.Tangle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bres);
            this.Name = "Form1";
            this.Text = "Funcion seno";
            this.GBunit.ResumeLayout(false);
            this.GBunit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bres;
        private System.Windows.Forms.RadioButton RBdeg;
        private System.Windows.Forms.RadioButton RBrad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tangle;
        private System.Windows.Forms.TextBox Tsin;
        private System.Windows.Forms.GroupBox GBunit;
    }
}

