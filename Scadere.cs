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
    public partial class Scadere : Form
    {
        public Scadere()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            this.Hide();
            meniu.Closed += (s, args) => this.Close();
            meniu.Show();
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
            exercitiiScad exercitiiScad = new exercitiiScad();
            this.Hide();
            exercitiiScad.Closed += (s, args) => this.Close();
            exercitiiScad.Show();
        }
    }
}
