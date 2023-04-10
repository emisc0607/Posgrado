using System;
using System.Windows.Forms;

namespace Tarea4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bcalc_Click(object sender, EventArgs e)
        {
            double.TryParse(TBv.Text, out double vin);
            double req = 0, it, va;
            double[] r = new double[3];
            double[] vres = new double[3];
            string[] tb = { TBr1.Text, TBr2.Text, TBr3.Text };
            for (int j = 0; j < 3; j++)
            {
                double.TryParse(tb[j], out r[j]);
                req += r[j];
            }
            it = vin / req;
            for(int j = 0; j < 3; j++)
            {
                vres[j] = it * r[j];
               
            }
            va = vin - vres[0];
            TBva.Text = Math.Round(va, 2).ToString();
            TBvr1.Text = Math.Round(vres[0], 2).ToString();
            TBvr2.Text = Math.Round(vres[1], 2).ToString();
            TBvr3.Text = Math.Round(vres[2], 2).ToString();
            TBreq.Text = Math.Round(req, 2).ToString();
            TBit.Text = Math.Round(it, 6).ToString();

        }

        private void Bclear_Click(object sender, EventArgs e)
        {
            TBr1.Text = string.Empty;
            TBr2.Text = string.Empty;
            TBr3.Text = string.Empty;
            TBv.Text = string.Empty;

            TBit.Text = string.Empty;
            TBva.Text = string.Empty;
            TBvr1.Text = string.Empty;
            TBvr2.Text = string.Empty;
            TBvr3.Text = string.Empty;
            TBreq.Text = string.Empty;

        }
    }
}
