using System;
using System.Windows.Forms;

namespace T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bclear_Click(object sender, EventArgs e)
        {
            Tres.Text = "";
            Tnum.Text = "";
        }

        private void Bcalc_Click(object sender, EventArgs e)
        {
            double num = 0.0, res = 0.0;
            double.TryParse(Tnum.Text, out num);
            if(num < 0)
            {
                MessageBox.Show("No introduzca numeros negativos", "Error!", MessageBoxButtons.OK);
            }
            else
            {
                res = Math.Sqrt(num);
                Tres.Text = Math.Round(res, 2).ToString();
            }
        }
    }
}