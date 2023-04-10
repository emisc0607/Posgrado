namespace Tarea2
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
            this.RBdeg = new System.Windows.Forms.RadioButton();
            this.RBrad = new System.Windows.Forms.RadioButton();
            this.Bcalc = new System.Windows.Forms.Button();
            this.Bclean = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBtetha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBsin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBcos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBtan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBcot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBsec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBcsc = new System.Windows.Forms.TextBox();
            this.CBinversas = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBdeg
            // 
            this.RBdeg.AutoSize = true;
            this.RBdeg.Checked = true;
            this.RBdeg.Location = new System.Drawing.Point(6, 21);
            this.RBdeg.Name = "RBdeg";
            this.RBdeg.Size = new System.Drawing.Size(73, 20);
            this.RBdeg.TabIndex = 0;
            this.RBdeg.TabStop = true;
            this.RBdeg.Text = "Grados";
            this.RBdeg.UseVisualStyleBackColor = true;
            // 
            // RBrad
            // 
            this.RBrad.AutoSize = true;
            this.RBrad.Location = new System.Drawing.Point(6, 47);
            this.RBrad.Name = "RBrad";
            this.RBrad.Size = new System.Drawing.Size(87, 20);
            this.RBrad.TabIndex = 1;
            this.RBrad.Text = "Radianes";
            this.RBrad.UseVisualStyleBackColor = true;
            // 
            // Bcalc
            // 
            this.Bcalc.Location = new System.Drawing.Point(46, 192);
            this.Bcalc.Name = "Bcalc";
            this.Bcalc.Size = new System.Drawing.Size(101, 50);
            this.Bcalc.TabIndex = 2;
            this.Bcalc.Text = "Calcular";
            this.Bcalc.UseVisualStyleBackColor = true;
            this.Bcalc.Click += new System.EventHandler(this.Bcalc_Click);
            // 
            // Bclean
            // 
            this.Bclean.Location = new System.Drawing.Point(190, 192);
            this.Bclean.Name = "Bclean";
            this.Bclean.Size = new System.Drawing.Size(101, 50);
            this.Bclean.TabIndex = 3;
            this.Bclean.Text = "Limpiar";
            this.Bclean.UseVisualStyleBackColor = true;
            this.Bclean.Click += new System.EventHandler(this.Bclean_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBdeg);
            this.groupBox1.Controls.Add(this.RBrad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unidad";
            // 
            // TBtetha
            // 
            this.TBtetha.Location = new System.Drawing.Point(56, 101);
            this.TBtetha.Name = "TBtetha";
            this.TBtetha.Size = new System.Drawing.Size(70, 22);
            this.TBtetha.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tetha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "sin(Tetha) = ";
            // 
            // TBsin
            // 
            this.TBsin.Location = new System.Drawing.Point(250, 12);
            this.TBsin.Name = "TBsin";
            this.TBsin.Size = new System.Drawing.Size(86, 22);
            this.TBsin.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "cos(Tetha) = ";
            // 
            // TBcos
            // 
            this.TBcos.Location = new System.Drawing.Point(250, 40);
            this.TBcos.Name = "TBcos";
            this.TBcos.Size = new System.Drawing.Size(86, 22);
            this.TBcos.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "tan(Tetha) = ";
            // 
            // TBtan
            // 
            this.TBtan.Location = new System.Drawing.Point(250, 68);
            this.TBtan.Name = "TBtan";
            this.TBtan.Size = new System.Drawing.Size(86, 22);
            this.TBtan.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "cot(Tetha) = ";
            // 
            // TBcot
            // 
            this.TBcot.Location = new System.Drawing.Point(250, 96);
            this.TBcot.Name = "TBcot";
            this.TBcot.Size = new System.Drawing.Size(86, 22);
            this.TBcot.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "sec(Tetha) = ";
            // 
            // TBsec
            // 
            this.TBsec.Location = new System.Drawing.Point(250, 124);
            this.TBsec.Name = "TBsec";
            this.TBsec.Size = new System.Drawing.Size(86, 22);
            this.TBsec.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "csc(Tetha) = ";
            // 
            // TBcsc
            // 
            this.TBcsc.Location = new System.Drawing.Point(250, 152);
            this.TBcsc.Name = "TBcsc";
            this.TBcsc.Size = new System.Drawing.Size(86, 22);
            this.TBcsc.TabIndex = 17;
            // 
            // CBinversas
            // 
            this.CBinversas.AutoSize = true;
            this.CBinversas.Location = new System.Drawing.Point(11, 129);
            this.CBinversas.Name = "CBinversas";
            this.CBinversas.Size = new System.Drawing.Size(80, 20);
            this.CBinversas.TabIndex = 19;
            this.CBinversas.Text = "Inversas";
            this.CBinversas.UseVisualStyleBackColor = true;
            this.CBinversas.CheckedChanged += new System.EventHandler(this.CBinversas_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 262);
            this.Controls.Add(this.CBinversas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBcsc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBsec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBcot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBtan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBcos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBsin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBtetha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bclean);
            this.Controls.Add(this.Bcalc);
            this.Name = "Form1";
            this.Text = "Funciones trigonométricas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBdeg;
        private System.Windows.Forms.RadioButton RBrad;
        private System.Windows.Forms.Button Bcalc;
        private System.Windows.Forms.Button Bclean;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBtetha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBsin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBcos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBtan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBcot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBsec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBcsc;
        private System.Windows.Forms.CheckBox CBinversas;
    }
}

