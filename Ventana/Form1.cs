using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana
{
    public partial class Form1 : Form
    {
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (x==0)
            {
                label1.Text = "Juliana";
                x= 1;
            }
            else
            {
                label1.Text = "bienvenido";
                x = 0;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //declara variables
            int num1;
            int num2;
            int resultado;
            string rs;

            //guarda los datos de los textBox en las variables
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            //aqui se hace la multiplicacion
            resultado = num1 * num2;

            rs = Convert.ToString(resultado);  

            txbresultado.Text = rs;



        }
    }
}
