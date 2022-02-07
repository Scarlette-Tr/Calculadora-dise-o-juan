using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarnum (object sender, EventArgs e) {
            var botton = ((Button)sender);
            if (texresul.Text == "0")
                texresul.Text = "";
            
            texresul.Text += botton.Text;


        }
        private void clioperador(object sender, EventArgs e)
        {
            var botton = ((Button)sender);
            num1 = Convert.ToDouble(texresul.Text);
            operador = Convert.ToChar(botton.Tag);

            texresul.Text = "0";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
       

            texresul.Text = texresul.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(texresul.Text);

            if (operador == '+')
            {
                texresul.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(texresul.Text);

            }
            else if (operador == '-')
            {
                texresul.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(texresul.Text);

            }
            else if (operador == 'X')
            {
                texresul.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(texresul.Text);

            }
            else if (operador == '/')
            {
                texresul.Text = (num1 / num2).ToString();
                num1 = Convert.ToDouble(texresul.Text);

            }
        }



        private void bpunto_Click(object sender, EventArgs e)
        {
            texresul.Text = texresul.Text + ",";

        }

        private void borrar_Click(object sender, EventArgs e)
        {
           if (texresul.Text.Length > 1)
            {
                texresul.Text = texresul.Text.Substring(0, texresul.Text.Length - 1);
            }
           else
            {
                texresul.Text = "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        int pX, pY;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                pX = e.X;
                pY = e.Y;
            }
            else
            {
                Left = Left + (e.X - pX);
                Top = Top + (e.Y - pY);
            }
        }

        private void borrart_Click(object sender, EventArgs e)
        {
            texresul.Text = " ";

        }
    }
}
