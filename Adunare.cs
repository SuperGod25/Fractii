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
    public partial class Adunare : Form
    {
        public Adunare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            this.Hide();
            meniu.Closed += (s, args) => this.Close();
            meniu.Show();
        }

        private void Adunare_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            exercitiiAdun exercitiiAdun = new exercitiiAdun();
            this.Hide();
            exercitiiAdun.Closed += (s, args) => this.Close();
            exercitiiAdun.Show();
        }
    }
}
