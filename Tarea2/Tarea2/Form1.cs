using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tarea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bclean_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            TBsin.Text = string.Empty;
            TBcos.Text = string.Empty;
            TBtan.Text = string.Empty;
            TBcot.Text = string.Empty;
            TBsec.Text = string.Empty;
            TBcsc.Text = string.Empty;
            TBtetha.Text = string.Empty;
        }
        private void Bcalc_Click(object sender, EventArgs e)
        {
            if (CBinversas.Checked)
            {
                TBcot.Enabled = false;
                TBcsc.Enabled = false;
                TBsec.Enabled = false;
                invertir();

            }
            else
            {
                TBcot.Enabled = true;
                TBcsc.Enabled = true;
                TBsec.Enabled = true;
                calculo();
            }
        }
        private void calculo()
        {
            double sen, cos, tan, cosec, cotan, sec;
            string data;
            double.TryParse(TBtetha.Text, out double tetha);
            if (RBdeg.Checked)
            {
                tetha *= (Math.PI / 180);
            }
            sen = Math.Round(Math.Sin(tetha));
            cos = Math.Round(Math.Cos(tetha));
            tan = Math.Round(Math.Tan(tetha));
            if (sen != 0)
            {
                cosec = 1.0 / sen;
                data = Math.Round(cosec, 2).ToString();
                TBcsc.Text = data;
            }
            else
            {
                data = "Indef.";
                TBcsc.Text = data;
            }
            if (cos != 0)
            {
                sec = 1.0 / cos;
                data = Math.Round(sec, 2).ToString();
                TBsec.Text = data;
            }
            else
            {
                data = "Indef.";
                TBsec.Text = data;
            }
            if (tan != 0)
            {
                cotan = 1.0 / tan;
                data = Math.Round(cotan, 2).ToString();
                TBcot.Text = data;
            }
            else
            {
                data = "Indef.";
                TBcot.Text = data;
            }
            TBsin.Text = sen.ToString();
            TBcos.Text = cos.ToString();
            TBtan.Text = tan.ToString();
        }
        private void invertir()
        {
            int ft;
            string inversa;
            double sen, cos, tan;
            if (TBsin.Text != "")
            {
                inversa = TBsin.Text;
                ft = 0;
            }
            else if (TBcos.Text != "")
            {
                inversa = TBcos.Text;
                ft = 1;
            }
            else
            {
                inversa = TBtan.Text;
                ft = 2;
            }
            double.TryParse(inversa, out double TethaI);

            switch (ft)
            {
                case 0:
                    sen = Math.Round(Math.Asin(TethaI), 2);
                    if (RBdeg.Checked)
                    {
                        sen *= 180 / Math.PI;
                    }
                    TBtetha.Text = Math.Round(sen, 2).ToString();
                    break;
                case 1:
                    cos = Math.Round(Math.Acos(TethaI), 2);
                    if (RBdeg.Checked)
                    {
                        cos *= 180 / Math.PI;
                    }
                    TBtetha.Text = Math.Round(cos, 2).ToString();
                    break;
                case 2:
                    tan = Math.Round(Math.Atan(TethaI), 2);
                    if (RBdeg.Checked)
                    {
                        tan *= 180 / Math.PI;
                    }
                    TBtetha.Text = Math.Round(tan, 2).ToString();
                    break;
                default: break;

            }
        }
        private void CBinversas_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            if (CBinversas.Checked)
            {
                TBcot.Enabled = false;
                TBcsc.Enabled = false;
                TBsec.Enabled = false;
            }
            else
            {
                TBcot.Enabled = true;
                TBcsc.Enabled = true;
                TBsec.Enabled = true;
              
            }
        }
    }
}
