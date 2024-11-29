using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio3
{
    public partial class Form2 : Form
    {
        private System.Drawing.Image image;
        private string nombreImagen;

        public Form2(System.Drawing.Image image, string nombreImagen)
        {
            this.image = image;
            this.nombreImagen = nombreImagen;

            InitializeComponent();

            this.Text = nombreImagen;

            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Dock = DockStyle.Fill;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            pictureBox1.Width = this.ClientSize.Width;
            pictureBox1.Height = this.ClientSize.Height;
        }
    }
}
