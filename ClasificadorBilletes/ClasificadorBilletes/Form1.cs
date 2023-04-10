using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClasificadorBilletes
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection camaras_disponibles;
        private VideoCaptureDevice camara;
        public Form1()
        {
            InitializeComponent();
        }

        public void video_NuevoMarco(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            oldCode(imagen);
            Pvideo.Image = imagen;

        }
        private void oldCode(Bitmap img)
        {
            Bitmap b2 = new Bitmap(img.Width, img.Height);         
            int i, j, green = 0, red = 0, blue = 0, t, gr, s = 0, ss = 0, x = 0;
            Color c, c1;
            string den = "";

            for (i = 0; i < img.Height; i++)
                for (j = 0; j < img.Width; j++)
                {
                    c = img.GetPixel(j, i);
                    c1 = Color.FromArgb(c.R, c.G, c.B);
                    b2.SetPixel(j, i, c1);
                    red = red + c.R;
                    blue = blue + c.B;
                    green = green + c.G;
                }
            t = img.Height * img.Width;
            red = (int)(red * 1.0 / t);
            blue = (int)(blue * 1.0 / t);
            green = (int)(green * 1.0 / t);
            x = (int)((red + blue + green) * 1.0 / 3);
            for (i = 0; i < img.Height; i++)
                for (j = 0; j < img.Width; j++)
                {
                    c = img.GetPixel(j, i);
                    c1 = Color.FromArgb(c.R, c.G, c.B);
                    gr = (int)((c.R + c.B + c.G) * 1.0 / 3);
                    ss = ss + ((gr - x) * (gr - x));
                }
            if (ss < 0)
                ss = ss * -1;
            s = (int)Math.Sqrt(ss * 1.0 / t);
            if (RBbilletes.Checked == true)
            {
                if (red >= 130)
                {
                    if (green >= 134)
                        
                        den = "$200";
                    else
                        if (blue >= 118 && blue <= 123)
                        den = "$100";
                    else
                            if (blue >= 124 && blue <= 126)
                    {
                        if (x == 125)
                            den = "$50";
                        else
                            den = "$500";
                    }
                    else
                        den = "$50";
                }
                else
                    den = "$20";
            }
            else
            {
                if (x >= 130)
                {
                    if (x >= 135)
                        den = "$10";
                    else
                        if (s >= 25)
                        den = "$2";
                    else
                        den = "$0.50";
                }
                else
                {
                    if (x >= 120)
                        den = "$1";
                    else
                        den = "$5";
                }
            }
            using (Graphics graphics = Graphics.FromImage(img))
            {
                // Configurar la fuente y el color del mensaje
                Font fuente = new Font("Arial", 28);
                Brush brush = new SolidBrush(Color.Red);

                // Dibujar el mensaje en la imagen
                graphics.DrawString(den, fuente, brush, new PointF(100, 50));
            }
        }
        private void Biniciar_Click(object sender, EventArgs e)
        {
            if (Biniciar.Text == "INICIAR")
            {
                camara = new VideoCaptureDevice(camaras_disponibles[CBlista.SelectedIndex].MonikerString);
                camara.NewFrame += new NewFrameEventHandler(video_NuevoMarco);
                camara.Start();
                Biniciar.Text = "DETENER";
            }
            else
            {
                if (camara.IsRunning)
                {
                    camara.Stop();
                    Biniciar.Text = "INICIAR";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            camaras_disponibles = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            for (int i = 0; i < camaras_disponibles.Count; i++)
                CBlista.Items.Add(camaras_disponibles[i].Name);

            CBlista.Text = CBlista.Items[0].ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            camara.Stop();
        }
    }
}
