using System;
using System.Windows.Forms;

namespace Tarea5
{
    public partial class Form1 : Form
    {
        double res = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Bequal_Click(object sender, EventArgs e)
        {

        }

        private void selection(int num)
        {
            string n, prev;
            prev = TBnum.Text;
            switch (num)
            {
                case 0:
                    n = "0";
                    if (prev != "0")
                        TBnum.Text = prev + n;
                    else TBnum.Text = n;
                    break;
                case 1:
                    n = "1";
                    TBnum.Text = prev + n;
                    break;
                case 2:
                    n = "2";
                    TBnum.Text = prev + n;
                    break;
                case 3:
                    n = "3";
                    TBnum.Text = prev + n;
                    break;
                case 4:
                    n = "4";
                    TBnum.Text = prev + n;
                    break;
                case 5:
                    n = "5";
                    TBnum.Text = prev + n;
                    break;
                case 6:
                    n = "6";
                    TBnum.Text = prev + n;
                    break;
                case 7:
                    n = "7";
                    TBnum.Text = prev + n;
                    break;
                case 8:
                    n = "8";
                    TBnum.Text = prev + n;
                    break;
                case 9:
                    n = "9";
                    TBnum.Text = prev + n;
                    break;
                case 10:
                    n = ".";
                    TBnum.Text = prev + n;
                    break;
                case 11:
                    n = "(";
                    if (prev != "0")
                        TBnum.Text = prev + n;
                    break;
                case 12:
                    n = ")";
                    if (prev != "0")
                        TBnum.Text = prev + n;
                    else TBnum.Text = n;
                    break;

                default:
                    break;

            }

        }

        private void B0_Click(object sender, EventArgs e)
        {
            selection(0);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            selection(1);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            selection(2);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            selection(3);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            selection(4);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            selection(5);
        }

        private void B6_Click(object sender, EventArgs e)
        {
            selection(6);
        }

        private void B7_Click(object sender, EventArgs e)
        {
            selection(7);
        }

        private void B8_Click(object sender, EventArgs e)
        {
            selection(8);
        }

        private void B9_Click(object sender, EventArgs e)
        {
            selection(9);
        }

        private void Bdot_Click(object sender, EventArgs e)
        {
            selection(10);
            Bdot.Enabled = false;
        }

        private void operation(int o)
        {
            string eq;
            string pnum = TBnum.Text;
            string peq = TBeq.Text;
            double.TryParse(TBnum.Text, out double n1);
            double.TryParse(TBeq.Text, out double n2);
            switch (o)
            {
                case 0:
                    if(peq != "")
                    {
                        eq = peq + " + " + pnum;
                    }
                    else
                    {
                        eq = pnum;
                    }
                    TBeq.Text = eq;
                    break;
                case 1:
                    if(peq != "")
                    {
                        eq = peq + " - " + pnum;
                    }
                    else
                    {
                        eq = pnum;
                    }
                    TBeq.Text = eq;
                    break;
                case 2:
                    if(peq != "")
                    {
                        eq = peq + " x " + pnum;
                    }
                    else
                    {
                        eq = pnum;
                    }
                    TBeq.Text = eq;
                    break;
                case 3:
                    if(peq != "")
                    {
                        eq = peq + " / " + pnum;
                    }
                    else
                    {
                        eq = pnum;
                    }
                    TBeq.Text = eq;
                    break;
                default:
                    break;
            }

            TBnum.Text = string.Empty;
        }

        private void Bsum_Click(object sender, EventArgs e)
        {
            operation(0);
            Bdot.Enabled = true;

        }

        private void Bres_Click(object sender, EventArgs e)
        {
            operation(1);
            Bdot.Enabled = true;

        }

        private void Bmult_Click(object sender, EventArgs e)
        {
            operation(2);
            Bdot.Enabled = true;

        }

        private void Bdiv_Click(object sender, EventArgs e)
        {
            operation(3);
            Bdot.Enabled = true;
       

        }

        private void BclearAll_Click(object sender, EventArgs e)
        {
            TBeq.Text = string.Empty;
            TBnum.Text = string.Empty;
            Bdot.Enabled = true;

        }

        private void Bclear_Click(object sender, EventArgs e)
        {
            TBnum.Text = string.Empty;
            Bdot.Enabled = true;
        }

        private void BpOpen_Click(object sender, EventArgs e)
        {
            selection(11);
        }

        private void BpClose_Click(object sender, EventArgs e)
        {
            selection(12);
        }
    }
}
