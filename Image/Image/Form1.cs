using System;
using System.Drawing;
using System.Windows.Forms;

namespace Image
{
    public partial class Form1 : Form
    {
        Bitmap b1, b2;
        public Form1()
        {
            InitializeComponent();
        }

        private void grisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AForge.Imaging.Filters.Grayscale gray = new AForge.Imaging.Filters.Grayscale(0.299, 0.589, 0.114);
            b2 = gray.Apply(b1);
            AForge.Imaging.Filters.OtsuThreshold binary = new AForge.Imaging.Filters.OtsuThreshold();
            b2 = binary.Apply(b2);
            PBout.Image = b2;
        }

        private void negativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AForge.Imaging.Filters.Invert negativa = new AForge.Imaging.Filters.Invert();
            b2 = negativa.Apply(b1);
            PBout.Image = b2;
        }

        private void deteccionDeBordesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AForge.Imaging.Filters.Grayscale gray = new AForge.Imaging.Filters.Grayscale(0.299, 0.589, 0.114);
            b2 = gray.Apply(b1);
            AForge.Imaging.Filters.CannyEdgeDetector border = new AForge.Imaging.Filters.CannyEdgeDetector();
            b2 = border.Apply(b2);
            PBout.Image = b2;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                b1 = new Bitmap(openFileDialog1.FileName);
                b2 = new Bitmap(b1.Width, b1.Height);
                PBin.Image = b1;
            }
        }
    }
}
