using System;
using System.Drawing;
using System.Windows.Forms;

namespace T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bprocess_Click(object sender, EventArgs e)
        {
            Bitmap b1 = new Bitmap(PBimage.Width, PBimage.Height);
            Color c;
            for (int i = 0; i < b1.Height; i++)
            {
                for (int j = 0; j < b1.Width; j++)
                {
                    c = Color.FromArgb(125, 5, 253);
                    b1.SetPixel(j, i, c);

                }
                PBimage.Image = b1;
            }
        }
    }
}