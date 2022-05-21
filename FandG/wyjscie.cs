using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FandG
{
    public partial class wyjscie : Form
    {
        public wyjscie(string score) //konsturktor klasy wyjscie
        {
            InitializeComponent();

            this.button1.TabStop = false;
            this.button2.TabStop = false;
            
            //string score2 = Convert.ToString(brazowy.score);
            this.labScore2.Text = score;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //losowanie przypadku gry 
            Random ranGame = new Random();

            int numGame = ranGame.Next(3);

            if (numGame == 0)
            {
                brazowy organic = new brazowy();
                brazowy.score = 0;
                this.Hide();
                organic.Show();
            }

            else if (numGame == 1)
            {
                zielony glass = new zielony();
                zielony.score = 0;
                this.Hide();
                glass.Show();
            }

            else if (numGame == 2)
            {
                zolty metal = new zolty();
                zolty.score = 0;
                this.Hide();
                metal.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            wejscie wej = new wejscie();
            this.Hide();
            wej.Show();
        }
    }
}
