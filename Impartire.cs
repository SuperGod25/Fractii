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
    public partial class Impartire : Form
    {
        public Impartire()
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

        private void button2_Click(object sender, EventArgs e)
        {
            exercitiiImpart exercitiiImpart = new exercitiiImpart();
            this.Hide();
            exercitiiImpart.Closed += (s, args) => this.Close();
            exercitiiImpart.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inmultire inmultire = new Inmultire();
            this.Hide();
            inmultire.Closed += (s, args) => this.Close();
            inmultire.Show();
        }
    }
}
