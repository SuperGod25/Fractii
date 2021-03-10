using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractii___new
{
    public partial class exercitiiInmult : Form
    {
        public exercitiiInmult()
        {
            InitializeComponent();
        }
        int numitor1, numitor2, numitor3;
        int numarator1, numarator2, numarator3;
        int puncte = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            Inmultire inmultire = new Inmultire();
            this.Hide();
            inmultire.Closed += (s, args) => this.Close();
            inmultire.Show();
        }

        void numereRandom()
        {
            Random randomElement = new Random();
            int rndmNMT1 = randomElement.Next(1, 10);
            textBox2.Text = rndmNMT1.ToString();

            int rndmNMT2 = randomElement.Next(1, 10);
            textBox4.Text = rndmNMT2.ToString();

            int rndmNMRT1 = randomElement.Next(1, 10);
            textBox1.Text = rndmNMRT1.ToString();

            int rndmNMRT2 = randomElement.Next(1, 10);
            textBox3.Text = rndmNMRT2.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            numereRandom();
            textBox6.Clear();
            textBox5.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numitor1 = Convert.ToInt32(textBox2.Text);
            numitor2 = Convert.ToInt32(textBox4.Text);
            numitor3 = Convert.ToInt32(textBox6.Text);
            numarator1 = Convert.ToInt32(textBox1.Text);
            numarator2 = Convert.ToInt32(textBox3.Text);
            numarator3 = Convert.ToInt32(textBox5.Text);

            
            
                if (numitor3 == numitor1 * numitor2 && numarator3 == numarator1 * numarator2)
                {
                    MessageBox.Show("Corect!");
                    puncte += 2;
                    textBox7.Text = puncte.ToString();
                    numereRandom();
                    textBox5.Clear();
                    textBox6.Clear();

                }
                else
                {
                    MessageBox.Show("Incorect");
                    puncte--;
                    textBox7.Text = puncte.ToString();


                }
            
           
            
            if (puncte >= 5)
            {
                MessageBox.Show("Felicitari! Ai terminat exercitiile cu inmultiri");
                Meniu meniu = new Meniu();
                
                this.Hide();
                meniu.Closed += (s, args) => this.Close();
                meniu.Show();
            }
            else if (puncte < 0)
            {
                MessageBox.Show("MAI CITESTE TEORIA!");
                Inmultire inmultire = new Inmultire();
                this.Hide();
                inmultire.Closed += (s, args) => this.Close();
                inmultire.Show();
               
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
