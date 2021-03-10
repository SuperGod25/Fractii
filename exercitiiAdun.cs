﻿using System;
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
    public partial class exercitiiAdun : Form
    {
        public exercitiiAdun()
        {
            InitializeComponent();
        }

        int numitor1, numitor2, numitor3;
        int numarator1, numarator2, numarator3;
        int puncte = 0;



        private void exercitiiAdun_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adunare adunare = new Adunare();
            this.Hide();
            adunare.Closed += (s, args) => this.Close();
            adunare.Show();
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

        

        private void button2_Click(object sender, EventArgs e)
        {
            
            numitor1 = Convert.ToInt32(textBox2.Text);
            numitor2 = Convert.ToInt32(textBox4.Text);
            numitor3 = Convert.ToInt32(textBox6.Text);
            numarator1 = Convert.ToInt32(textBox1.Text);
            numarator2 = Convert.ToInt32(textBox3.Text);
            numarator3 = Convert.ToInt32(textBox5.Text);

            if (numitor1 != numitor2)
            {
                if (numitor3 == numitor1 * numitor2 && numarator3 == numarator1 * numitor2 + numarator2 * numitor1)
                {
                    MessageBox.Show("Corect!");
                    puncte+=2;
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
            }
            else
            {
                if(numitor3==numitor2 && numarator3==numarator1+numarator2)
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
            }

            if(puncte>=5)
            {
                MessageBox.Show("Felicitari! Ai finalizat exercitiile cu adunari!");
                Meniu meniu = new Meniu();
                this.Hide();
                meniu.Closed += (s, args) => this.Close();
                meniu.Show();
            }
            else if (puncte < 0)
            {
                MessageBox.Show("MAI CITESTE TEORIA!");
                Adunare adunare = new Adunare();
                this.Hide();
                adunare.Closed += (s, args) => this.Close();
                adunare.Show();
            }
        }
    }
}
