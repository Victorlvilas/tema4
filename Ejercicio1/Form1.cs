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
            int mouseX = 0;
            int mouseY = 0;
            Point posicion;

            if (sender is Button)
            {
                Button boton = (Button)sender;
                posicion = e.Location;

                mouseX = e.X + posicion.X;
                mouseY = e.Y + posicion.Y;
            }
            else
            {
                mouseX = e.X;
                mouseY = e.Y;
            }
            this.Text = $"X: {mouseX} Y:{mouseY}";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

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

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Transparent;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Transparent;
            }
            else
            {
                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = (Color)button1.Tag;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = (Color)button2.Tag;
            }
            else
            {
                button1.BackColor = (Color)button1.Tag;
                button2.BackColor = (Color)button2.Tag;
            }
        }

        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            this.Text = e.KeyChar.ToString();
        }
    }
}


