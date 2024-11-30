using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirImagen()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG files (*.png)|*.png|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string nombreImagen = Path.GetFileName(openFileDialog.FileName);
                    filePath = openFileDialog.FileName;

                    try
                    {
                        Image image = Image.FromFile(filePath);

                        Form2 f = new Form2(image, nombreImagen);

                        if (chkModal.Checked)
                        {
                            f.ShowDialog();
                        }
                        else
                        {
                            f.Show();
                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("El archivo seleccionado no es una imagen válida.", "Error al cargar la imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirImagen();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModal.Checked)
            {
                chkModal.ForeColor = Color.Red;
            }
            else
            {
                chkModal.ForeColor = Color.Black;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
