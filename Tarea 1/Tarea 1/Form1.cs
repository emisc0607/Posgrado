using System;
using System.Windows.Forms;

namespace Tarea_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RBsuma.Checked)
            {
                suma();
            }
            else if (RBresta.Checked)
            {
                resta();
            }
            else
            {
                multiplicacion();
            }
        }
        private void suma()
        {

            double[,] a = new double[3, 3];
            double[,] b = new double[3, 3];
            double[,] r = new double[3, 3];
            string[,] matA = {
                { TBa11.Text, TBa12.Text, TBa13.Text },
                { TBa21.Text, TBa22.Text, TBa23.Text },
                { TBa31.Text, TBa32.Text, TBa33.Text }
            };
            string[,] matB = {
                { TBb11.Text, TBb12.Text, TBb13.Text },
                { TBb21.Text, TBb22.Text, TBb23.Text },
                { TBb31.Text, TBb32.Text, TBb33.Text }
            };
            string[,] matR = {
                { TBres11.Text, TBres12.Text, TBres13.Text },
                { TBres21.Text, TBres22.Text, TBres23.Text },
                { TBres31.Text, TBres32.Text, TBres33.Text }
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    double.TryParse(matA[i, j], out a[i, j]);
                    double.TryParse(matB[i, j], out b[i, j]);
                    r[i, j] = a[i, j] + b[i, j];
                }
            }
            showRes(r);

        }
        private void resta()
        {
            double[,] a = new double[3, 3];
            double[,] b = new double[3, 3];
            double[,] r = new double[3, 3];
            string[,] matA = {
                { TBa11.Text, TBa12.Text, TBa13.Text },
                { TBa21.Text, TBa22.Text, TBa23.Text },
                { TBa31.Text, TBa32.Text, TBa33.Text }
            };
            string[,] matB = {
                { TBb11.Text, TBb12.Text, TBb13.Text },
                { TBb21.Text, TBb22.Text, TBb23.Text },
                { TBb31.Text, TBb32.Text, TBb33.Text }
            };
            string[,] matR = {
                { TBres11.Text, TBres12.Text, TBres13.Text },
                { TBres21.Text, TBres22.Text, TBres23.Text },
                { TBres31.Text, TBres32.Text, TBres33.Text }
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    double.TryParse(matA[i, j], out a[i, j]);
                    double.TryParse(matB[i, j], out b[i, j]);
                    r[i, j] = a[i, j] - b[i, j];
                }
            }
            showRes(r);
        }
        private void multiplicacion()
        {
            double[,] a = new double[3, 3];
            double[,] b = new double[3, 3];
            double[,] r = new double[3, 3];
            string[,] matA = {
                { TBa11.Text, TBa12.Text, TBa13.Text },
                { TBa21.Text, TBa22.Text, TBa23.Text },
                { TBa31.Text, TBa32.Text, TBa33.Text }
            };
            string[,] matB = {
                { TBb11.Text, TBb12.Text, TBb13.Text },
                { TBb21.Text, TBb22.Text, TBb23.Text },
                { TBb31.Text, TBb32.Text, TBb33.Text }
            };
            string[,] matR = {
                { TBres11.Text, TBres12.Text, TBres13.Text },
                { TBres21.Text, TBres22.Text, TBres23.Text },
                { TBres31.Text, TBres32.Text, TBres33.Text }
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    double.TryParse(matA[i, j], out a[i, j]);
                    double.TryParse(matB[i, j], out b[i, j]);

                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k <= 2; k++)
                        r[i, j] = (r[i, j] + (a[i, k] * b[k, j]));
                }
            }
            showRes(r);
        }
        private void showRes(double[,] r)
        {
            TBres11.Text = (Math.Round(r[0, 0], 1)).ToString();
            TBres12.Text = (Math.Round(r[0, 1], 1)).ToString();
            TBres13.Text = (Math.Round(r[0, 2], 1)).ToString();
            TBres21.Text = (Math.Round(r[1, 0], 1)).ToString();
            TBres22.Text = (Math.Round(r[1, 1], 1)).ToString();
            TBres23.Text = (Math.Round(r[1, 2], 1)).ToString();
            TBres31.Text = (Math.Round(r[2, 0], 1)).ToString();
            TBres32.Text = (Math.Round(r[2, 1], 1)).ToString();
            TBres33.Text = (Math.Round(r[2, 2], 1)).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TBa11.Text = string.Empty;
            TBa12.Text = string.Empty;
            TBa13.Text = string.Empty;
            TBa21.Text = string.Empty;
            TBa22.Text = string.Empty;
            TBa23.Text = string.Empty;
            TBa31.Text = string.Empty;
            TBa32.Text = string.Empty;
            TBa33.Text = string.Empty;

            TBb11.Text = string.Empty;
            TBb12.Text = string.Empty;
            TBb13.Text = string.Empty;
            TBb21.Text = string.Empty;
            TBb22.Text = string.Empty;
            TBb23.Text = string.Empty;
            TBb31.Text = string.Empty;
            TBb32.Text = string.Empty;
            TBb33.Text = string.Empty;

            TBres11.Text = string.Empty;
            TBres12.Text = string.Empty;
            TBres13.Text = string.Empty;
            TBres21.Text = string.Empty;
            TBres22.Text = string.Empty;
            TBres23.Text = string.Empty;
            TBres31.Text = string.Empty;
            TBres32.Text = string.Empty;
            TBres33.Text = string.Empty;
        }
    }
}
