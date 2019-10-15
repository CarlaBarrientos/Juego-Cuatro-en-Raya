using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Juego4enRaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "A:/PABLO/UPB/CUARTO SEMESTRE/INGENIERIA DE SOFTWARE/PROYECTOSGIT/Sonar1.wav";
            Player.Play();
        
    }
    }
}
