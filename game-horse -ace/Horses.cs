using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_horse__ace
{
    public partial class Horses : Form
    {
        int horse1Left, horse2Left,horse3Left;
        Random random = new Random();
        private void timerHorse_Tick(object sender, EventArgs e)
        {
            int horse1Genis = pictureBirHorse.Width;
            int horse2Genis = picture3Horse.Width;
            int horse3Genis = picture2Horse.Width;

            int finish = lblFinish.Left;

            pictureBirHorse.Left = pictureBirHorse.Left + random.Next(5, 10);
            picture3Horse.Left = picture3Horse.Left + random.Next(5, 10);
            picture2Horse.Left = picture2Horse.Left + random.Next(5, 10);

            if (horse1Genis + pictureBirHorse.Left >= finish)
            {
                timerHorse.Enabled = false;
                lblText.Text = "1 Nolu at yarışı kazandı!.";
                btnNewGame.Visible = true;
                btnStart.Visible = false;
                pictureBox1.ImageLocation = @"C:\Users\urems\source\repos\games\game-horse -ace\images\hors.gif";
            }
            if (horse2Genis + picture2Horse.Left >= finish)
            {
                timerHorse.Enabled = false;
                lblText.Text = "2 Nolu at yarışı kazandı!.";
                btnNewGame.Visible = true;
                btnStart.Visible = false;
                pictureBox1.ImageLocation = @"C:\Users\urems\source\repos\games\game -horse-ace\images\hors.gif";
            }
            if (horse3Genis + picture3Horse.Left >= finish)
            {
                timerHorse.Enabled = false;
                lblText.Text = "3 Nolu at yarışı kazandı!.";
                btnNewGame.Visible = true;
                btnStart.Visible = false;
                pictureBox1.ImageLocation = @"C:\Users\urems\source\repos\games\game -horse-ace\images\hors.gif";
            }

            if (pictureBirHorse.Left > picture2Horse.Left + 5 &&
                pictureBirHorse.Left > picture3Horse.Left + 5 )
            {
                lblText.Text = " 1 numaralı at önde gidiyor.";
            }
            if (picture2Horse.Left > pictureBirHorse.Left + 5 &&
                picture2Horse.Left > picture3Horse.Left + 5 )
            {
                lblText.Text = " 2 numaralı at iyi bir atak yaptı.";
            }
            if (picture3Horse.Left > pictureBirHorse.Left + 5 &&
                picture3Horse.Left > picture2Horse.Left + 5 )
            {
                lblText.Text = " 3 numaralı at atağa kalktı.";
            }
           
        }

        private void Horses_Load(object sender, EventArgs e)
        {
            horse1Left = pictureBirHorse.Left;
            horse2Left = picture3Horse.Left;
            horse3Left = picture2Horse.Left;
        }

        public Horses()
        {
            InitializeComponent();
            btnNewGame.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            timerHorse.Enabled = true;
            pictureBox1.Visible = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Horses form = new Horses();
            form.Show();
            this.Hide();
        }
    }
}
