using desktop_bitinvest_v1.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_bitinvest_v1.View
{
    public partial class Fotos : Form
    {
        public Fotos()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
               

                

                this.Close();

            

        }

        private void btnFotoFrente_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string nome = openFileDialog1.FileName;
                bmp = new Bitmap(nome);
                pictureBox1.Image = bmp;
                MemoryStream memory = new MemoryStream();
                bmp.Save(memory, ImageFormat.Jpeg);
                byte[] foto = memory.ToArray();
                memory.Position = 0;
                memory.Read(foto, 0, foto.Length);
                Cliente.Foto_Frente = foto;
            }
        }

        private void btnFotoTras_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string nome = openFileDialog1.FileName;
                bmp = new Bitmap(nome);
                pictureBox2.Image = bmp;

                MemoryStream memory = new MemoryStream();
                bmp.Save(memory, ImageFormat.Jpeg);
                byte[] fotoT = memory.ToArray();
                memory.Position = 0;
                memory.Read(fotoT, 0, fotoT.Length);
                Cliente.Foto_Tras = fotoT;
            }
        }

        private void btnFotoSelfie_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string nome = openFileDialog1.FileName;
                bmp = new Bitmap(nome);
                pictureBox3.Image = bmp;
                MemoryStream memory = new MemoryStream();
                bmp.Save(memory, ImageFormat.Jpeg);

                byte[] fotoS = memory.ToArray();
                memory.Position = 0;
                memory.Read(fotoS, 0, fotoS.Length);
                Cliente.Foto_Selfie = fotoS;
            }
        }
    }
}
