namespace Tarea_1
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
            this.RBsuma = new System.Windows.Forms.RadioButton();
            this.RBresta = new System.Windows.Forms.RadioButton();
            this.RBmult = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBa11 = new System.Windows.Forms.TextBox();
            this.TBa12 = new System.Windows.Forms.TextBox();
            this.TBa13 = new System.Windows.Forms.TextBox();
            this.TBa21 = new System.Windows.Forms.TextBox();
            this.TBa22 = new System.Windows.Forms.TextBox();
            this.TBa23 = new System.Windows.Forms.TextBox();
            this.TBa31 = new System.Windows.Forms.TextBox();
            this.TBa32 = new System.Windows.Forms.TextBox();
            this.TBa33 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBb33 = new System.Windows.Forms.TextBox();
            this.TBb32 = new System.Windows.Forms.TextBox();
            this.TBb31 = new System.Windows.Forms.TextBox();
            this.TBb23 = new System.Windows.Forms.TextBox();
            this.TBb22 = new System.Windows.Forms.TextBox();
            this.TBb21 = new System.Windows.Forms.TextBox();
            this.TBb13 = new System.Windows.Forms.TextBox();
            this.TBb12 = new System.Windows.Forms.TextBox();
            this.TBb11 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TBres33 = new System.Windows.Forms.TextBox();
            this.TBres32 = new System.Windows.Forms.TextBox();
            this.TBres31 = new System.Windows.Forms.TextBox();
            this.TBres23 = new System.Windows.Forms.TextBox();
            this.TBres22 = new System.Windows.Forms.TextBox();
            this.TBres21 = new System.Windows.Forms.TextBox();
            this.TBres13 = new System.Windows.Forms.TextBox();
            this.TBres12 = new System.Windows.Forms.TextBox();
            this.TBres11 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBsuma
            // 
            this.RBsuma.AutoSize = true;
            this.RBsuma.Checked = true;
            this.RBsuma.Location = new System.Drawing.Point(6, 21);
            this.RBsuma.Name = "RBsuma";
            this.RBsuma.Size = new System.Drawing.Size(63, 20);
            this.RBsuma.TabIndex = 0;
            this.RBsuma.TabStop = true;
            this.RBsuma.Text = "Suma";
            this.RBsuma.UseVisualStyleBackColor = true;
            // 
            // RBresta
            // 
            this.RBresta.AutoSize = true;
            this.RBresta.Location = new System.Drawing.Point(6, 47);
            this.RBresta.Name = "RBresta";
            this.RBresta.Size = new System.Drawing.Size(64, 20);
            this.RBresta.TabIndex = 1;
            this.RBresta.Text = "Resta";
            this.RBresta.UseVisualStyleBackColor = true;
            // 
            // RBmult
            // 
            this.RBmult.AutoSize = true;
            this.RBmult.Location = new System.Drawing.Point(6, 73);
            this.RBmult.Name = "RBmult";
            this.RBmult.Size = new System.Drawing.Size(109, 20);
            this.RBmult.TabIndex = 2;
            this.RBmult.Text = "Multiplicación";
            this.RBmult.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBsuma);
            this.groupBox1.Controls.Add(this.RBmult);
            this.groupBox1.Controls.Add(this.RBresta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operación";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBa33);
            this.groupBox2.Controls.Add(this.TBa32);
            this.groupBox2.Controls.Add(this.TBa31);
            this.groupBox2.Controls.Add(this.TBa23);
            this.groupBox2.Controls.Add(this.TBa22);
            this.groupBox2.Controls.Add(this.TBa21);
            this.groupBox2.Controls.Add(this.TBa13);
            this.groupBox2.Controls.Add(this.TBa12);
            this.groupBox2.Controls.Add(this.TBa11);
            this.groupBox2.Location = new System.Drawing.Point(135, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 115);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mat A";
            // 
            // TBa11
            // 
            this.TBa11.Location = new System.Drawing.Point(7, 21);
            this.TBa11.Name = "TBa11";
            this.TBa11.Size = new System.Drawing.Size(39, 22);
            this.TBa11.TabIndex = 0;
            // 
            // TBa12
            // 
            this.TBa12.Location = new System.Drawing.Point(52, 21);
            this.TBa12.Name = "TBa12";
            this.TBa12.Size = new System.Drawing.Size(39, 22);
            this.TBa12.TabIndex = 1;
            // 
            // TBa13
            // 
            this.TBa13.Location = new System.Drawing.Point(97, 21);
            this.TBa13.Name = "TBa13";
            this.TBa13.Size = new System.Drawing.Size(39, 22);
            this.TBa13.TabIndex = 2;
            // 
            // TBa21
            // 
            this.TBa21.Location = new System.Drawing.Point(7, 49);
            this.TBa21.Name = "TBa21";
            this.TBa21.Size = new System.Drawing.Size(39, 22);
            this.TBa21.TabIndex = 3;
            // 
            // TBa22
            // 
            this.TBa22.Location = new System.Drawing.Point(52, 49);
            this.TBa22.Name = "TBa22";
            this.TBa22.Size = new System.Drawing.Size(39, 22);
            this.TBa22.TabIndex = 4;
            // 
            // TBa23
            // 
            this.TBa23.Location = new System.Drawing.Point(97, 49);
            this.TBa23.Name = "TBa23";
            this.TBa23.Size = new System.Drawing.Size(39, 22);
            this.TBa23.TabIndex = 5;
            // 
            // TBa31
            // 
            this.TBa31.Location = new System.Drawing.Point(7, 77);
            this.TBa31.Name = "TBa31";
            this.TBa31.Size = new System.Drawing.Size(39, 22);
            this.TBa31.TabIndex = 6;
            // 
            // TBa32
            // 
            this.TBa32.Location = new System.Drawing.Point(52, 77);
            this.TBa32.Name = "TBa32";
            this.TBa32.Size = new System.Drawing.Size(39, 22);
            this.TBa32.TabIndex = 7;
            // 
            // TBa33
            // 
            this.TBa33.Location = new System.Drawing.Point(97, 77);
            this.TBa33.Name = "TBa33";
            this.TBa33.Size = new System.Drawing.Size(39, 22);
            this.TBa33.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TBb33);
            this.groupBox3.Controls.Add(this.TBb32);
            this.groupBox3.Controls.Add(this.TBb31);
            this.groupBox3.Controls.Add(this.TBb23);
            this.groupBox3.Controls.Add(this.TBb22);
            this.groupBox3.Controls.Add(this.TBb21);
            this.groupBox3.Controls.Add(this.TBb13);
            this.groupBox3.Controls.Add(this.TBb12);
            this.groupBox3.Controls.Add(this.TBb11);
            this.groupBox3.Location = new System.Drawing.Point(301, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 115);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mat B";
            // 
            // TBb33
            // 
            this.TBb33.Location = new System.Drawing.Point(97, 77);
            this.TBb33.Name = "TBb33";
            this.TBb33.Size = new System.Drawing.Size(39, 22);
            this.TBb33.TabIndex = 8;
            // 
            // TBb32
            // 
            this.TBb32.Location = new System.Drawing.Point(52, 77);
            this.TBb32.Name = "TBb32";
            this.TBb32.Size = new System.Drawing.Size(39, 22);
            this.TBb32.TabIndex = 7;
            // 
            // TBb31
            // 
            this.TBb31.Location = new System.Drawing.Point(7, 77);
            this.TBb31.Name = "TBb31";
            this.TBb31.Size = new System.Drawing.Size(39, 22);
            this.TBb31.TabIndex = 6;
            // 
            // TBb23
            // 
            this.TBb23.Location = new System.Drawing.Point(97, 49);
            this.TBb23.Name = "TBb23";
            this.TBb23.Size = new System.Drawing.Size(39, 22);
            this.TBb23.TabIndex = 5;
            // 
            // TBb22
            // 
            this.TBb22.Location = new System.Drawing.Point(52, 49);
            this.TBb22.Name = "TBb22";
            this.TBb22.Size = new System.Drawing.Size(39, 22);
            this.TBb22.TabIndex = 4;
            // 
            // TBb21
            // 
            this.TBb21.Location = new System.Drawing.Point(7, 49);
            this.TBb21.Name = "TBb21";
            this.TBb21.Size = new System.Drawing.Size(39, 22);
            this.TBb21.TabIndex = 3;
            // 
            // TBb13
            // 
            this.TBb13.Location = new System.Drawing.Point(97, 21);
            this.TBb13.Name = "TBb13";
            this.TBb13.Size = new System.Drawing.Size(39, 22);
            this.TBb13.TabIndex = 2;
            // 
            // TBb12
            // 
            this.TBb12.Location = new System.Drawing.Point(52, 21);
            this.TBb12.Name = "TBb12";
            this.TBb12.Size = new System.Drawing.Size(39, 22);
            this.TBb12.TabIndex = 1;
            // 
            // TBb11
            // 
            this.TBb11.Location = new System.Drawing.Point(7, 21);
            this.TBb11.Name = "TBb11";
            this.TBb11.Size = new System.Drawing.Size(39, 22);
            this.TBb11.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TBres33);
            this.groupBox4.Controls.Add(this.TBres32);
            this.groupBox4.Controls.Add(this.TBres31);
            this.groupBox4.Controls.Add(this.TBres23);
            this.groupBox4.Controls.Add(this.TBres22);
            this.groupBox4.Controls.Add(this.TBres21);
            this.groupBox4.Controls.Add(this.TBres13);
            this.groupBox4.Controls.Add(this.TBres12);
            this.groupBox4.Controls.Add(this.TBres11);
            this.groupBox4.Location = new System.Drawing.Point(467, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 115);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mat Res";
            // 
            // TBres33
            // 
            this.TBres33.Enabled = false;
            this.TBres33.Location = new System.Drawing.Point(97, 77);
            this.TBres33.Name = "TBres33";
            this.TBres33.Size = new System.Drawing.Size(39, 22);
            this.TBres33.TabIndex = 8;
            // 
            // TBres32
            // 
            this.TBres32.Enabled = false;
            this.TBres32.Location = new System.Drawing.Point(52, 77);
            this.TBres32.Name = "TBres32";
            this.TBres32.Size = new System.Drawing.Size(39, 22);
            this.TBres32.TabIndex = 7;
            // 
            // TBres31
            // 
            this.TBres31.Enabled = false;
            this.TBres31.Location = new System.Drawing.Point(7, 77);
            this.TBres31.Name = "TBres31";
            this.TBres31.Size = new System.Drawing.Size(39, 22);
            this.TBres31.TabIndex = 6;
            // 
            // TBres23
            // 
            this.TBres23.Enabled = false;
            this.TBres23.Location = new System.Drawing.Point(97, 49);
            this.TBres23.Name = "TBres23";
            this.TBres23.Size = new System.Drawing.Size(39, 22);
            this.TBres23.TabIndex = 5;
            // 
            // TBres22
            // 
            this.TBres22.Enabled = false;
            this.TBres22.Location = new System.Drawing.Point(52, 49);
            this.TBres22.Name = "TBres22";
            this.TBres22.Size = new System.Drawing.Size(39, 22);
            this.TBres22.TabIndex = 4;
            // 
            // TBres21
            // 
            this.TBres21.Enabled = false;
            this.TBres21.Location = new System.Drawing.Point(7, 49);
            this.TBres21.Name = "TBres21";
            this.TBres21.Size = new System.Drawing.Size(39, 22);
            this.TBres21.TabIndex = 3;
            // 
            // TBres13
            // 
            this.TBres13.Enabled = false;
            this.TBres13.Location = new System.Drawing.Point(97, 21);
            this.TBres13.Name = "TBres13";
            this.TBres13.Size = new System.Drawing.Size(39, 22);
            this.TBres13.TabIndex = 2;
            // 
            // TBres12
            // 
            this.TBres12.Enabled = false;
            this.TBres12.Location = new System.Drawing.Point(52, 21);
            this.TBres12.Name = "TBres12";
            this.TBres12.Size = new System.Drawing.Size(39, 22);
            this.TBres12.TabIndex = 1;
            // 
            // TBres11
            // 
            this.TBres11.Enabled = false;
            this.TBres11.Location = new System.Drawing.Point(7, 21);
            this.TBres11.Name = "TBres11";
            this.TBres11.Size = new System.Drawing.Size(39, 22);
            this.TBres11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 184);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Operaciones con matrices";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RBsuma;
        private System.Windows.Forms.RadioButton RBresta;
        private System.Windows.Forms.RadioButton RBmult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBa33;
        private System.Windows.Forms.TextBox TBa32;
        private System.Windows.Forms.TextBox TBa31;
        private System.Windows.Forms.TextBox TBa23;
        private System.Windows.Forms.TextBox TBa22;
        private System.Windows.Forms.TextBox TBa21;
        private System.Windows.Forms.TextBox TBa13;
        private System.Windows.Forms.TextBox TBa12;
        private System.Windows.Forms.TextBox TBa11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TBb33;
        private System.Windows.Forms.TextBox TBb32;
        private System.Windows.Forms.TextBox TBb31;
        private System.Windows.Forms.TextBox TBb23;
        private System.Windows.Forms.TextBox TBb22;
        private System.Windows.Forms.TextBox TBb21;
        private System.Windows.Forms.TextBox TBb13;
        private System.Windows.Forms.TextBox TBb12;
        private System.Windows.Forms.TextBox TBb11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TBres33;
        private System.Windows.Forms.TextBox TBres32;
        private System.Windows.Forms.TextBox TBres31;
        private System.Windows.Forms.TextBox TBres23;
        private System.Windows.Forms.TextBox TBres22;
        private System.Windows.Forms.TextBox TBres21;
        private System.Windows.Forms.TextBox TBres13;
        private System.Windows.Forms.TextBox TBres12;
        private System.Windows.Forms.TextBox TBres11;
    }
}

