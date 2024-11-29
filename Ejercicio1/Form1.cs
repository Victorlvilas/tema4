#define TECLA
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CrearBotones();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int mouseX = e.X;
            int mouseY = e.Y;

            this.Text = $"X: {mouseX} Y:{mouseY}";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void buttons_Click(object sender, EventArgs e)
        {

            ((Button)sender).BackColor = (Color)((Button)sender).Tag;
        }

#if TECLA

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             
           if (e.KeyCode == Keys.Escape)
                {
                this.Text = "Mouse Tester";
                }
            else
                {
                this.Text = e.KeyCode.ToString();
                }
            }
#else

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = e.KeyChar.ToString();
        }


#endif

        private void Boton_Click(object sender, EventArgs e)
        {

            this.Text = ((Button)sender).Text;


        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
         MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
          == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }




    }
}


