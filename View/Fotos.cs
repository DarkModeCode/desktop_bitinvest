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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string nome = openFileDialog1.FileName;
                bmp = new Bitmap(nome);
                pictureBox1.Image = bmp;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream memory = new MemoryStream();
            bmp.Save(memory, ImageFormat.Bmp);
            byte[] foto = memory.ToArray();
            Cliente.Foto = foto;

        }
    }
}
