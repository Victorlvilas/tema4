using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.BackColor = Color.FromArgb(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text));
            }

        private void button3_Click(object sender, EventArgs e)
            {
            label1.BackgroundImage =  new Bitmap(textBox4.Text);
            }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {             
                if (control is TextBox)
                {      
                    control.Text = string.Empty;
                }
                this.BackColor = SystemColors.Control; 
            }
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
            this.AcceptButton = button2;
        }

        private void textBoxImg_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = button3;
        }
    }
    }
    
