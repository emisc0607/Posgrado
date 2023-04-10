using System;
using System.Drawing;
using System.Windows.Forms;

namespace T5
{
    public partial class Form1 : Form
    {
        Bitmap b1, b2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Bprocess_Click(object sender, EventArgs e)
        {
            Color c;
            for (int i = 0; i < b1.Height; i++)
            {
                for (int j = 0; j < b1.Width; j++)
                {
                    c = b1.GetPixel(j, i);
                    b2.SetPixel(b1.Width - j - 1, i, c);
                }
            }
            Pout.Image = b2;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                b1 = new Bitmap(openFileDialog1.FileName);
                b2 = new Bitmap(b1.Width, b1.Height);
                Pin.Image = b1;

            }
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color c;
            for (int i = 0; i < b1.Height; i++)
            {
                for (int j = 0; j < b1.Width; j++)
                {
                    c = b1.GetPixel(j, i);
                    c = Color.FromArgb(c.R, 0, 0);
                    b2.SetPixel(j, i, c);
                }
            }
            Pout.Image = b2;
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color c;
            for (int i = 0; i < b1.Height; i++)
            {
                for (int j = 0; j < b1.Width; j++)
                {
                    c = b1.GetPixel(j, i);
                    c = Color.FromArgb(0, c.G, 0);
                    b2.SetPixel(j, i, c);
                }
            }
            Pout.Image = b2;
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color c;
            for (int i = 0; i < b1.Height; i++)
            {
                for (int j = 0; j < b1.Width; j++)
                {
                    c = b1.GetPixel(j, i);
                    c = Color.FromArgb(0, 0, c.B);
                    b2.SetPixel(j, i, c);
                }
            }
            Pout.Image = b2;
        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color c;
            for (int i = 0; i < b1.Height; i++)
            {
                for (int j = 0; j < b1.Width; j++)
                {
                    c = b1.GetPixel(j, i);
                    int gris = (int)(0.114 * c.B + 0.587 * c.G + 0.299 * c.R);
                    c = Color.FromArgb(gris, gris, gris);
                    b2.SetPixel(j, i, c);
                }
            }
            Pout.Image = b2;
        }

        private void binariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color c;
            for (int i = 0; i < b1.Height; i++)
            {
                for (int j = 0; j < b1.Width; j++)
                {
                    c = b1.GetPixel(j, i);
                    int gris = (int)(0.114 * c.B + 0.587 * c.G + 0.299 * c.R);
                    if (gris > 128)
                    {
                        gris = 255;
                    }
                    else gris = 0;
                    c = Color.FromArgb(gris, gris, gris);
                    b2.SetPixel(j, i, c);
                }
            }
            Pout.Image = b2;
        }

        private void escalaDeGrisesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Color c;
            for (int i = 0; i < b1.Height; i++)
            {
                for (int j = 0; j < b1.Width; j++)
                {
                    c = b1.GetPixel(j, i);
                    int gris = (int)(0.114 * c.B + 0.587 * c.G + 0.299 * c.R);
                    int neg = 255 - gris;
                    c = Color.FromArgb(neg, neg, neg);
                    b2.SetPixel(j, i, c);
                }
            }
            Pout.Image = b2;
        }

        private void binariaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Color c;
            for (int i = 0; i < b1.Height; i++)
            {
                for (int j = 0; j < b1.Width; j++)
                {
                    c = b1.GetPixel(j, i);
                    int gris = (int)(0.114 * c.B + 0.587 * c.G + 0.299 * c.R);
                    if (gris > 128)
                    {
                        gris = 255;
                    }
                    else gris = 0;
                    int neg = 255 - gris;
                    c = Color.FromArgb(neg, neg, neg);
                    b2.SetPixel(j, i, c);
                }
            }
            Pout.Image = b2;
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color c;
            for (int i = 0; i < b1.Height; i++)
            {
                for (int j = 0; j < b1.Width; j++)
                {
                    c = b1.GetPixel(j, i);
                    c = Color.FromArgb(255 - c.R, 255 - c.B, 255 - c.G);
                    b2.SetPixel(j, i, c);
                }
            }
            Pout.Image = b2;
        }

        private void umbralizaciónDeOtsuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otsu();
        }

        private void Bopen_Click(object sender, EventArgs e)
        {
            Pin.Image = Pout.Image;
        }
        private void otsu()
        {
            double[] hist = new double[256];
            double[] prob = new double[256];
            double media = 0.0;
            int a;
            Color c;
            //Escala de grises
            for (int i = 0; i < b1.Height; i++)
            {
                for (int j = 0; j < b1.Width; j++)
                {
                    c = b1.GetPixel(j, i);
                    int gris = (int)(0.114 * c.B + 0.587 * c.G + 0.299 * c.R);
                    int neg = 255 - gris;
                    c = Color.FromArgb(neg, neg, neg);
                    b2.SetPixel(j, i, c);
                }
            }
            //Histograma
            for (int i = 0; i < b1.Height; i++)
            {
                for (int j = 0; j < b1.Width; j++)
                {
                    c = b2.GetPixel(j, i);
                    a = c.R;
                    hist[a]++;
                }
            }
            //Probabilidad de gris
            double nPixels = b2.Width * b2.Height;
            for (int i = 0; i < 256; i++)
            {
                prob[i] = hist[i] / nPixels;
            }
            //Calculo de la media
            for (int i = 0; i < 256; i++)
            {
                media += i + prob[i];
            }
            // Buscar el umbral óptimo
            double maxVar = 0;
            int umbral = 0;
            for (int t = 0; t < 256; t++)
            {
                // Calcular la probabilidad y la media de cada clase
                double w1 = 0, w2 = 0, m1 = 0, m2 = 0;
                for (int i = 0; i < t; i++)
                {
                    w1 += prob[i];
                    m1 += i * prob[i];
                }
                m1 /= w1;

                for (int i = t; i < 256; i++)
                {
                    w2 += prob[i];
                    m2 += i * prob[i];
                }
                m2 /= w2;

                // Calcular la varianza entre clases
                double var = w1 * w2 * (m1 - m2) * (m1 - m2);

                // Actualizar el umbral óptimo si se encontró una varianza mayor
                if (var > maxVar)
                {
                    maxVar = var;
                    umbral = t;
                }
            }
            for (int i = 0; i < b2.Height; i++)
            {
                for (int j = 0; j < b2.Width; j++)
                {
                    c = b2.GetPixel(j, i);
                    int valor = c.R > umbral ? 255 : 0;
                    c = Color.FromArgb(valor, valor, valor);
                    b2.SetPixel(j, i, c);
                }
            }
            Pout.Image = b2;
        }
    }
}