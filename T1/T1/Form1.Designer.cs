namespace T1
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
            this.bSumar = new System.Windows.Forms.Button();
            this.lN1 = new System.Windows.Forms.Label();
            this.lN2 = new System.Windows.Forms.Label();
            this.lN3 = new System.Windows.Forms.Label();
            this.tNum1 = new System.Windows.Forms.TextBox();
            this.tNum2 = new System.Windows.Forms.TextBox();
            this.tNum3 = new System.Windows.Forms.TextBox();
            this.tSum = new System.Windows.Forms.TextBox();
            this.lTotal = new System.Windows.Forms.Label();
            this.Bdelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSumar
            // 
            this.bSumar.Location = new System.Drawing.Point(34, 227);
            this.bSumar.Name = "bSumar";
            this.bSumar.Size = new System.Drawing.Size(75, 36);
            this.bSumar.TabIndex = 0;
            this.bSumar.Text = "Sumar";
            this.bSumar.UseVisualStyleBackColor = true;
            this.bSumar.Click += new System.EventHandler(this.Bsumar_Click);
            // 
            // lN1
            // 
            this.lN1.AutoSize = true;
            this.lN1.Location = new System.Drawing.Point(56, 33);
            this.lN1.Name = "lN1";
            this.lN1.Size = new System.Drawing.Size(24, 16);
            this.lN1.TabIndex = 1;
            this.lN1.Text = "N1";
            // 
            // lN2
            // 
            this.lN2.AutoSize = true;
            this.lN2.Location = new System.Drawing.Point(59, 74);
            this.lN2.Name = "lN2";
            this.lN2.Size = new System.Drawing.Size(24, 16);
            this.lN2.TabIndex = 2;
            this.lN2.Text = "N2";
            // 
            // lN3
            // 
            this.lN3.AutoSize = true;
            this.lN3.Location = new System.Drawing.Point(59, 123);
            this.lN3.Name = "lN3";
            this.lN3.Size = new System.Drawing.Size(24, 16);
            this.lN3.TabIndex = 3;
            this.lN3.Text = "N3";
            // 
            // tNum1
            // 
            this.tNum1.Location = new System.Drawing.Point(107, 33);
            this.tNum1.Name = "tNum1";
            this.tNum1.Size = new System.Drawing.Size(100, 22);
            this.tNum1.TabIndex = 4;
            // 
            // tNum2
            // 
            this.tNum2.Location = new System.Drawing.Point(107, 71);
            this.tNum2.Name = "tNum2";
            this.tNum2.Size = new System.Drawing.Size(100, 22);
            this.tNum2.TabIndex = 5;
            // 
            // tNum3
            // 
            this.tNum3.Location = new System.Drawing.Point(107, 117);
            this.tNum3.Name = "tNum3";
            this.tNum3.Size = new System.Drawing.Size(100, 22);
            this.tNum3.TabIndex = 6;
            // 
            // tSum
            // 
            this.tSum.Location = new System.Drawing.Point(107, 175);
            this.tSum.Name = "tSum";
            this.tSum.Size = new System.Drawing.Size(100, 22);
            this.tSum.TabIndex = 8;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(59, 181);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(38, 16);
            this.lTotal.TabIndex = 7;
            this.lTotal.Text = "Total";
            // 
            // Bdelete
            // 
            this.Bdelete.Location = new System.Drawing.Point(132, 227);
            this.Bdelete.Name = "Bdelete";
            this.Bdelete.Size = new System.Drawing.Size(75, 36);
            this.Bdelete.TabIndex = 9;
            this.Bdelete.Text = "Borrar";
            this.Bdelete.UseVisualStyleBackColor = true;
            this.Bdelete.Click += new System.EventHandler(this.Bdelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 279);
            this.Controls.Add(this.Bdelete);
            this.Controls.Add(this.tSum);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.tNum3);
            this.Controls.Add(this.tNum2);
            this.Controls.Add(this.tNum1);
            this.Controls.Add(this.lN3);
            this.Controls.Add(this.lN2);
            this.Controls.Add(this.lN1);
            this.Controls.Add(this.bSumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSumar;
        private System.Windows.Forms.Label lN1;
        private System.Windows.Forms.Label lN2;
        private System.Windows.Forms.Label lN3;
        private System.Windows.Forms.TextBox tNum1;
        private System.Windows.Forms.TextBox tNum2;
        private System.Windows.Forms.TextBox tNum3;
        private System.Windows.Forms.TextBox tSum;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Button Bdelete;
    }
}

