using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("¿Seguro que desea salir?", "Ejercicio 2",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int red = Int32.Parse(txtRgb1.Text);
                int green = Int32.Parse(txtRgb2.Text);
                int blue = Int32.Parse(txtRgb3.Text);

                if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255)
                {
                    throw new ArgumentOutOfRangeException("Los valores RGB deben estar entre 0 y 255.");
                }

                this.BackColor = Color.FromArgb(red, green, blue);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Los valores introducidos no son válidos. Por favor, use números enteros.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error de rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Error de desbordamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string imagePath = txtPath.Text;
                if (string.IsNullOrWhiteSpace(imagePath))
                {
                    throw new FileNotFoundException("La ruta de la imagen no puede estar vacía.");
                }

                lblImagen.BackgroundImage = new Bitmap(imagePath);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Se ha producido un error de entrada/salida: " + ex.Message, "Error IO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error al intentar cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }

            this.BackColor = SystemColors.Control;

            lblImagen.BackgroundImage = null;
        }


        private void buttons_MouseEnter(object sender, EventArgs e)
        {

            ((Button)sender).BackColor = Color.Chartreuse;

        }

        private void buttons_MouseLeave(object sender, EventArgs e)
        {

            ((Button)sender).BackColor = SystemColors.Control;

        }

        private void textBoxColor_Enter(object sender, EventArgs e)
        {

            this.AcceptButton = btnColor;

        }

        private void textBoxImg_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnPath;

        }
    }
}
