using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_calcular_gasosa
{
    
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Maximum = 100;
            circularProgressBar1.Minimum = 0;
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            
        }

        public double kmlitro, preco, abasteceu, resultado, aux;

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            metroTextBox3.Clear();
        }

        // kmlitro = x
        // preco = p
        // abasteceu = d
        // aux = r


        private void metroButton1_Click(object sender, EventArgs e)
        {


            kmlitro = Convert.ToDouble(metroTextBox1.Text);
            preco = Convert.ToDouble(metroTextBox2.Text);
            abasteceu = Convert.ToDouble(metroTextBox3.Text);

            aux = abasteceu / preco;
            resultado = aux * kmlitro;

            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(5);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
                
            }
                circularProgressBar1.Text = "" + resultado + "km";
        }

        
        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Clear();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            metroTextBox2.Clear();
        }
    }
}
