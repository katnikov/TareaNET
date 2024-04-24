using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaViernes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero1 = txtVarUno.Text;
            string numero2 = txtVarDos.Text;
            int numero1_int = 0;
            int numero2_int = 0;

            if (numero1.Length > 0 && numero2.Length > 0)
            {
                try
                {
                    numero1_int = (int)Convert.ToDouble(numero1);
                    numero2_int = Convert.ToInt32(numero2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtVarUno.Text = "";
                    txtVarDos.Text = "";
                }
            }
            else 
            {
                MessageBox.Show("Por favor, agrege una variable");
            }

            int resultado = numero1_int + numero2_int;
            lblResultado.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numero1 = txtVarUno.Text;
            string numero2 = txtVarDos.Text;
            int numero1_int = 0;
            int numero2_int = 0;

            if (numero1.Length > 0 && numero2.Length > 0)
            {
                try
                {
                    numero1_int = (int)Convert.ToDouble(numero1);
                    numero2_int = Convert.ToInt32(numero2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtVarUno.Text = "";
                    txtVarDos.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Por favor, agrege una variable");
            }

            int resultado = numero1_int - numero2_int;
            lblResultado.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string numero1 = txtVarUno.Text;
            string numero2 = txtVarDos.Text;
            int numero1_int = 0;
            int numero2_int = 0;

            if (numero1.Length > 0 && numero2.Length > 0)
            {
                try
                {
                    numero1_int = (int)Convert.ToDouble(numero1);
                    numero2_int = Convert.ToInt32(numero2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtVarUno.Text = "";
                    txtVarDos.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Por favor, agrege una variable");
            }

            int resultado = numero1_int * numero2_int;
            lblResultado.Text = resultado.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string numero1 = txtVarUno.Text;
            string numero2 = txtVarDos.Text;
            int numero1_int = 0;
            int numero2_int = 0;
            double numero1_double = 0;

            if(numero2 != "0")
            {
                if (numero1.Length > 0 && numero2.Length > 0)
                {
                    try
                    {
                        numero1_int = Convert.ToInt32(numero1);
                        numero1_double = Convert.ToDouble(numero1_int);
                        numero2_int = Convert.ToInt32(numero2);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txtVarUno.Text = "";
                        txtVarDos.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, agrege una variable");
                }
                double resultado = numero1_double / numero2_int;
                lblResultado.Text = resultado.ToString("0.####");
            } else
            {
                MessageBox.Show("Error detectado: No es posible llevar dividir por 0");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
