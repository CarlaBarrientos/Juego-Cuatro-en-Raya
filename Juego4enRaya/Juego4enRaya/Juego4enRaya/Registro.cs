using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego4enRaya
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void buttonJUGAR_Click(object sender, EventArgs e)
        {
            string player1 = PrimerJugador.Text;
            string player2 = SegundaJugador.Text;
            Form1 f1 = new Form1();
            f1.labelp1.Text = player1;
            f1.labelp2.Text = player2;
            f1.label.Text = player2;
            this.Hide();
            f1.Show();
        }
    }
}
