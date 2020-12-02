using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace login_calcular_gasosa
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Thread nt;
        public Form1()
        {
      
            InitializeComponent();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            pictureBox2.Image = Properties.Resources.userred;
            pictureBox3.Image = Properties.Resources.password__1_;
            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.White;
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.user_silhouette;
            pictureBox3.Image = Properties.Resources.keyred;
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.Red;
            textBox2.Clear();
            textBox2.PasswordChar = '*';
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.user_silhouette;
            pictureBox3.Image = Properties.Resources.password__1_;
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            textBox2.PasswordChar = '*';

        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (textBox1.Text == "veronesi" && textBox2.Text == "123")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }else
            {
                MessageBox.Show("Usuario ou Senha Invalida!");
            }
        }

        private void novoForm()
        {
         
            Application.Run(new Form2());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
