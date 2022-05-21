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

namespace FandG
{
    public partial class wejscie : Form
    {
        public wejscie()
        {
            InitializeComponent();
            this.button1.TabStop = false;
            this.button2.TabStop = false;
            this.button3.TabStop = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zasady zasady = new zasady();
            this.Hide();
            zasady.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //losowanie przypadku gry 
            Random ranGame = new Random();

            int numGame = ranGame.Next(3); 

            if (numGame == 0)
            {
                brazowy organic = new brazowy();
                this.Hide();
                organic.Show();
            }

            else if (numGame == 1)
            {
                zielony glass = new zielony();
                this.Hide();
                glass.Show();
            }

            else if (numGame == 2)
            {
                zolty metal = new zolty();
                this.Hide();
                metal.Show();
            }

        }
    }
}
