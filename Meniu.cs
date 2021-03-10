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
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            this.Hide();
            principal.Closed += (s, args) => this.Close();
            principal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adunare adunare = new Adunare();
            this.Hide();
            adunare.Closed += (s, args) => this.Close();
            adunare.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Scadere scadere = new Scadere();
            this.Hide();
            scadere.Closed += (s, args) => this.Close();
            scadere.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inmultire inmultire = new Inmultire();
            this.Hide();
            inmultire.Closed += (s, args) => this.Close();
            inmultire.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Impartire impartire = new Impartire();
            this.Hide();
            impartire.Closed += (s, args) => this.Close();
            impartire.Show();
        }
    }
}
