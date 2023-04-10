using System;
using System.Windows.Forms;

namespace Tarea3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void raicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double.TryParse(TBa.Text, out double a);
            double.TryParse(TBb.Text, out double b);
            double.TryParse(TBc.Text, out double c);
            double x1, x2, root;
            root = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            TBa.Text = root.ToString();
            x1 = (-b + root) / 2 * a;
            x2 = (-b - root) / 2 * a;
            TBx1.Text = Math.Round(x1, 2).ToString();
            TBx2.Text = Math.Round(x2, 2).ToString();
            Lfuncion.Text = "AX^2 + BX + C = 0";
        }

        private void funcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double.TryParse(TBx1.Text, out double x1);
            double.TryParse(TBx2.Text, out double x2);
            string sign = "";
            a = Math.Pow(x1, 2);
            b = 2 * x1 * x2;
            c = Math.Pow(x2, 2);
            if (b > 0)
            {
                sign = "+";
            }
            Lfuncion.Text = a.ToString() + "X^2 " + sign + b.ToString() + "X + " + c.ToString() + "= 0";

        }

        private void Bclear_Click(object sender, EventArgs e)
        {
            TBa.Text = string.Empty;
            TBb.Text = string.Empty;
            TBc.Text = string.Empty;
            TBx1.Text = string.Empty;
            TBx2.Text = string.Empty;
            Lfuncion.Text = "AX^2 + BX + C = 0";
        }
    }
}
