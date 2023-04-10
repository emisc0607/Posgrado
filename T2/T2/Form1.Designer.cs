namespace T2
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
            this.Bcalc = new System.Windows.Forms.Button();
            this.Bclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tnum = new System.Windows.Forms.TextBox();
            this.Tres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bcalc
            // 
            this.Bcalc.Location = new System.Drawing.Point(41, 80);
            this.Bcalc.Name = "Bcalc";
            this.Bcalc.Size = new System.Drawing.Size(88, 51);
            this.Bcalc.TabIndex = 0;
            this.Bcalc.Text = "Calcular";
            this.Bcalc.UseVisualStyleBackColor = true;
            this.Bcalc.Click += new System.EventHandler(this.Bcalc_Click);
            // 
            // Bclear
            // 
            this.Bclear.Location = new System.Drawing.Point(149, 80);
            this.Bclear.Name = "Bclear";
            this.Bclear.Size = new System.Drawing.Size(88, 51);
            this.Bclear.TabIndex = 1;
            this.Bclear.Text = "Limpiar";
            this.Bclear.UseVisualStyleBackColor = true;
            this.Bclear.Click += new System.EventHandler(this.Bclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "sqr(";
            // 
            // Tnum
            // 
            this.Tnum.Location = new System.Drawing.Point(82, 41);
            this.Tnum.Name = "Tnum";
            this.Tnum.Size = new System.Drawing.Size(43, 22);
            this.Tnum.TabIndex = 3;
            // 
            // Tres
            // 
            this.Tres.Location = new System.Drawing.Point(158, 41);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(68, 22);
            this.Tres.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = ") =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 172);
            this.Controls.Add(this.Tres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bclear);
            this.Controls.Add(this.Bcalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bcalc;
        private System.Windows.Forms.Button Bclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tnum;
        private System.Windows.Forms.TextBox Tres;
        private System.Windows.Forms.Label label2;
    }
}

