using System;
using System.Windows.Forms;

namespace T1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bsumar_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, t = 0;
            int.TryParse(tNum1.Text, out a);
            int.TryParse(tNum2.Text, out b);
            int.TryParse(tNum3.Text, out c);

            t = a + b + c;
            tSum.Text = "$" + t.ToString() + " MXN";

        }

        private void Bdelete_Click(object sender, EventArgs e)
        {
            tNum1.Text = "";
            tNum2.Text = "";
            tNum3.Text = "";
            tSum.Text = "";
        }
    }
}
