namespace Tarea3
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
            this.Bclear = new System.Windows.Forms.Button();
            this.Lfuncion = new System.Windows.Forms.Label();
            this.TBa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBb = new System.Windows.Forms.TextBox();
            this.TBc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBx1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBx2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bclear
            // 
            this.Bclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclear.Location = new System.Drawing.Point(195, 183);
            this.Bclear.Name = "Bclear";
            this.Bclear.Size = new System.Drawing.Size(98, 64);
            this.Bclear.TabIndex = 0;
            this.Bclear.Text = "Limpiar";
            this.Bclear.UseVisualStyleBackColor = true;
            this.Bclear.Click += new System.EventHandler(this.Bclear_Click);
            // 
            // Lfuncion
            // 
            this.Lfuncion.AutoSize = true;
            this.Lfuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lfuncion.Location = new System.Drawing.Point(153, 30);
            this.Lfuncion.Name = "Lfuncion";
            this.Lfuncion.Size = new System.Drawing.Size(177, 25);
            this.Lfuncion.TabIndex = 1;
            this.Lfuncion.Text = "AX^2 + BX + C = 0";
            // 
            // TBa
            // 
            this.TBa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBa.Location = new System.Drawing.Point(13, 72);
            this.TBa.Name = "TBa";
            this.TBa.Size = new System.Drawing.Size(100, 30);
            this.TBa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "X^2 +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "X +";
            // 
            // TBb
            // 
            this.TBb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBb.Location = new System.Drawing.Point(177, 72);
            this.TBb.Name = "TBb";
            this.TBb.Size = new System.Drawing.Size(100, 30);
            this.TBb.TabIndex = 5;
            // 
            // TBc
            // 
            this.TBc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBc.Location = new System.Drawing.Point(332, 72);
            this.TBc.Name = "TBc";
            this.TBc.Size = new System.Drawing.Size(100, 30);
            this.TBc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "= 0";
            // 
            // TBx1
            // 
            this.TBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx1.Location = new System.Drawing.Point(107, 122);
            this.TBx1.Name = "TBx1";
            this.TBx1.Size = new System.Drawing.Size(100, 30);
            this.TBx1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "X1 =";
            // 
            // TBx2
            // 
            this.TBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx2.Location = new System.Drawing.Point(288, 122);
            this.TBx2.Name = "TBx2";
            this.TBx2.Size = new System.Drawing.Size(100, 30);
            this.TBx2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "X2 =";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raicesToolStripMenuItem,
            this.funcionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raicesToolStripMenuItem
            // 
            this.raicesToolStripMenuItem.Name = "raicesToolStripMenuItem";
            this.raicesToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.raicesToolStripMenuItem.Text = "Raices";
            this.raicesToolStripMenuItem.Click += new System.EventHandler(this.raicesToolStripMenuItem_Click);
            // 
            // funcionToolStripMenuItem
            // 
            this.funcionToolStripMenuItem.Name = "funcionToolStripMenuItem";
            this.funcionToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.funcionToolStripMenuItem.Text = "Funcion";
            this.funcionToolStripMenuItem.Click += new System.EventHandler(this.funcionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 259);
            this.Controls.Add(this.TBx2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBx1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBa);
            this.Controls.Add(this.Lfuncion);
            this.Controls.Add(this.Bclear);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cuadraticas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bclear;
        private System.Windows.Forms.Label Lfuncion;
        private System.Windows.Forms.TextBox TBa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBb;
        private System.Windows.Forms.TextBox TBc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBx1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBx2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionToolStripMenuItem;
    }
}

