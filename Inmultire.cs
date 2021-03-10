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
    public partial class Inmultire : Form
    {
        public Inmultire()
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

        private void Inmultire_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            exercitiiInmult exercitiiInmult = new exercitiiInmult();
            this.Hide();
            exercitiiInmult.Closed += (s, args) => this.Close();
            exercitiiInmult.Show();
        }
    }
}
