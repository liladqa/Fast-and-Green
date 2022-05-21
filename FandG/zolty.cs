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
    public partial class zolty : Form
    {
        bool goLeft, goRight;
        int speed = 3;
        public static int score = 0;
        int missed = 0;
        int cDown = 5;
        public bool endGame = false;
        int gameTimeS = 0;
        int gameTimeM = 0;

        Random randX = new Random();
        Random randY = new Random();



        PictureBox trash_hit = new PictureBox();

        private void MainGameTimer(object sender, EventArgs e)
        {
            labScore.Text = "PUNKTY: " + score; //wyswietlanie zmiennej score w labelu
           

            //przesuwanie gracza w zaleznosci od 
            //player.Left pozwala na okreslenie odleglosci danego elementu od krawedzi kontenerwa, w ktorym element sie znajduje 
            if (goLeft == true && player.Left > 1)
            {
                player.Left -= 35; //przesuwanie gracza o 30 px w lewo z kazdym kliknieciem strzalki
                player.BackgroundImage = Properties.Resources.zol_lewy; //zmiana obrazu gracza na "lewy"
                player.BackgroundImageLayout = ImageLayout.Stretch;
            }


            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += 35; //szybkosc, z jaka gracz moze przesuwac obiektem w prawo
                player.BackgroundImage = Properties.Resources.zol_prawy; //zmiana obrazu gracza na "prawy"
                player.BackgroundImageLayout = ImageLayout.Stretch;
            }

            //zmiana koloru serduszek 
            if (missed == 1)
            {
                this.chance1.BackgroundImage = Properties.Resources.zlamane;
                this.chance1.Size = new System.Drawing.Size(22, 22);
                this.chance1.Location = new Point(218, 22);
            }

            if (missed == 2)
            {
                this.chance2.BackgroundImage = Properties.Resources.zlamane;
                this.chance2.Size = new System.Drawing.Size(22, 22);
                this.chance2.Location = new Point(175, 22);
            }

            if (missed == 3)
            {
                this.chance3.BackgroundImage = Properties.Resources.zlamane;
                this.chance3.Size = new System.Drawing.Size(22, 22);
                this.chance3.Location = new Point(129, 22);
            }

            if (missed == 4)
            {
                this.chance4.BackgroundImage = Properties.Resources.zlamane;
                this.chance4.Size = new System.Drawing.Size(22, 22);
                this.chance4.Location = new Point(83, 22);
            }

            if (missed == 5)
            {
                this.chance5.BackgroundImage = Properties.Resources.zlamane;
                this.chance5.Size = new System.Drawing.Size(22, 22);
                this.chance5.Location = new Point(37, 22);
            }


            //obsluga spadania smieci z gory 
            foreach (Control x in this.Controls)
            {
                //jesli kontrolka x jest typu PictureBox i ma tag smieci
                if (x is PictureBox && ((string)x.Tag == "can" || (string)x.Tag == "bottle" || (string)x.Tag == "core"))
                {
                    x.Top += speed; //Top - pobiera odleglosc miedzy gornba krawedzia kontrolki a gorna krawedzia kontenera



                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        if ((string)x.Tag == "can")
                        {
                            trash_hit.BackgroundImage = Properties.Resources.pusz_zbita1;

                            //okreslanie parametrow PictureBoxa odpowiadajacemu pominietemu smieciowi 
                            trash_hit.Location = x.Location;
                            trash_hit.Height = 73;
                            trash_hit.Width = 61;
                            trash_hit.BackgroundImageLayout = ImageLayout.Stretch;
                            trash_hit.BackColor = Color.Transparent;

                            this.Controls.Add(trash_hit); //w miejscu w ktorym wystapi pomioniety smiec pojawi sie symbolizujacy to obrazek

                            //losowanie polozenia spadjaych jaj wzgledem gornej i lewej krawedzi kontenera 
                            x.Top = randY.Next(50, 100) * -1;
                            x.Left = randX.Next(10, this.ClientSize.Width - x.Width);

                            missed += 1;
                            player.BackgroundImage = Properties.Resources.zol_zbity; //w sensie jak ominie jakiegos smiecia co mial zebrac
                            player.BackgroundImageLayout = ImageLayout.Stretch;
                        }

                        else if ((string)x.Tag == "core")
                        {

                            //losowanie polozenia spadjaych puszek wzgledem gornej i lewej krawedzi kontenera 
                            x.Top = randY.Next(30, 500) * -1;
                            x.Left = randX.Next(10, this.ClientSize.Width - x.Width);


                        }

                        else if ((string)x.Tag == "bottle")
                        {

                            //losowanie polozenia spadjaych butelek wzgledem gornej i lewej krawedzi kontenera 
                            x.Top = randY.Next(50, 200) * -1;
                            x.Left = randX.Next(10, this.ClientSize.Width - x.Width);

                        }

                    }

                    //co sie stanie gdy gracz dotkanie krawedzi kontrolki, ktora spada 
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if ((string)x.Tag == "can")
                        {
                            x.Top = randY.Next(50, 100) * -1;
                            x.Left = randX.Next(10, this.ClientSize.Width - x.Width);
                            score += 1;
                        }

                        else if ((string)x.Tag == "core" || (string)x.Tag == "bottle")
                        {
                            x.Top = randY.Next(50, 100) * -1;
                            x.Left = randX.Next(10, this.ClientSize.Width - x.Width);
                            missed += 1;

                            player.BackgroundImage = Properties.Resources.zol_zbity; //w sensie jak ominie jakiegos smiecia co mial zebrac
                            player.BackgroundImageLayout = ImageLayout.Stretch;

                        }
                    }

                }
            }

            //przyspieszanie predkosci spadajacych elementow jesli zdobedzie sie 10 punktow 
            if (score > 10)
            {
                speed = 10;
            }

            if (score > 20)
            {
                speed = 15;
            }

            if (score > 30)
            {
                speed = 20;
            }

            //koniec gry i wyswietlenie powiadomienia jesli nie zbierze sie 5 smieci 
            if (missed == 5)
            {
                endGame = true;

            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void Count_Tick(object sender, EventArgs e)
        {
            this.labCount.Text = Convert.ToString(cDown);
            cDown--;

            if (cDown < 0)
            {
                this.GameTimer.Start();
                this.Clock.Start();
                this.labCount.Visible = false;
                if (endGame == true)
                {

                    this.Count.Enabled = false;


                    System.Threading.Thread.Sleep(2000);

                    string score2 = Convert.ToString(score);
                    wyjscie out_form = new wyjscie(score2);
                    this.Hide();
                    out_form.Show();
                }
            }
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            gameTimeS++;
            labClock.Text = String.Format("{00:00}", gameTimeS);
            labClock2.Text = "CZAS: " + String.Format("{00:00:}", gameTimeM);

            if (gameTimeS == 60)
            {
                gameTimeS = 0;
                gameTimeM++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wejscie wej = new wejscie();
            this.Hide();
            wej.Show();
        }

        public zolty()
        {
            InitializeComponent();
            this.button1.TabStop = false;
        }


    }
}
