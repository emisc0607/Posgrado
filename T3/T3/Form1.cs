using System;
using System.Windows.Forms;

namespace T3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bres_Click(object sender, EventArgs e)
        {
            double seno;
            double.TryParse(Tangle.Text, out double ang);
            if (RBdeg.Checked)
            {
                ang *= (Math.PI / 180);
            }
            seno = Math.Sin(ang);
            Tsin.Text = Math.Round(seno, 2).ToString();
        }
    }
}