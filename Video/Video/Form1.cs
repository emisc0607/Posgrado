using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;


namespace Video
{
  
    public partial class Form1 : Form
    {
        private FilterInfoCollection camaras_disponibles;
        private VideoCaptureDevice camara;
        Bitmap b1;
        public Form1()
        {
            InitializeComponent();
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
        public void video_NuevoMarco(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            AForge.Imaging.Filters.Grayscale gray = new AForge.Imaging.Filters.Grayscale(0.299, 0.589, 0.114);
            imagen = gray.Apply(imagen);
            Pvideo.Image = imagen;

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
