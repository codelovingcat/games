using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_supporter
{
    public partial class Supporties : Form
    {
        int saniye = 0;
        public Supporties()
        {
            InitializeComponent();
        }

        private void checkBesiktas_CheckedChanged(object sender, EventArgs e)
        {
            checkTrabzon.Checked = false;
            checkFener.Checked = false;
            checkGalata.Checked = false;

            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\urems\source\repos\games\game-supporter\music\besiktas.mp3";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(lblSaniye.Text);
            saniye++;
            lblSaniye.Text = saniye.ToString();

            if (checkBesiktas.Checked == true)
            {
                if (saniye % 5 == 0)
                {
                    btn1.BackColor = Color.White;
                    btn2.BackColor = Color.Black;
                    btn3.BackColor = Color.White;
                    btn4.BackColor = Color.Black;

                    btn5.BackColor = Color.Black;
                    btn6.BackColor = Color.White;
                    btn7.BackColor = Color.Black;
                    btn8.BackColor = Color.White;
                }
                if (saniye % 10 == 0)
                {
                    btn1.BackColor = Color.Black;
                    btn2.BackColor = Color.White;
                    btn3.BackColor = Color.Black;
                    btn4.BackColor = Color.White;

                    btn5.BackColor = Color.White;
                    btn6.BackColor = Color.Black;
                    btn7.BackColor = Color.White;
                    btn8.BackColor = Color.Black;
                }
            }
            if (checkTrabzon.Checked == true)
            {
                if (saniye % 5 == 0)
                {
                    btn1.BackColor = Color.Blue;
                    btn2.BackColor = Color.DarkRed;
                    btn3.BackColor = Color.Blue;
                    btn4.BackColor = Color.DarkRed;

                    btn5.BackColor = Color.DarkRed;
                    btn6.BackColor = Color.Blue;
                    btn7.BackColor = Color.DarkRed;
                    btn8.BackColor = Color.Blue;
                }
                if (saniye % 10 == 0)
                {
                    btn1.BackColor = Color.DarkRed;
                    btn2.BackColor = Color.Blue;
                    btn3.BackColor = Color.DarkRed;
                    btn4.BackColor = Color.Blue;

                    btn5.BackColor = Color.Blue;
                    btn6.BackColor = Color.DarkRed;
                    btn7.BackColor = Color.Blue;
                    btn8.BackColor = Color.DarkRed;
                }
            }
            if (checkFener.Checked == true)
            {
                if (saniye % 5 == 0)
                {
                    btn1.BackColor = Color.Yellow;
                    btn2.BackColor = Color.DarkBlue;
                    btn3.BackColor = Color.Yellow;
                    btn4.BackColor = Color.DarkBlue;

                    btn5.BackColor = Color.DarkBlue;
                    btn6.BackColor = Color.Yellow;
                    btn7.BackColor = Color.DarkBlue;
                    btn8.BackColor = Color.Yellow;
                }
                if (saniye % 10 == 0)
                {
                    btn1.BackColor = Color.DarkBlue;
                    btn2.BackColor = Color.Yellow;
                    btn3.BackColor = Color.DarkBlue;
                    btn4.BackColor = Color.Yellow;

                    btn5.BackColor = Color.Yellow;
                    btn6.BackColor = Color.DarkBlue;
                    btn7.BackColor = Color.Yellow;
                    btn8.BackColor = Color.DarkBlue;
                }
            }
            if (checkGalata.Checked == true)
            {
                if (saniye % 5 == 0)
                {
                    btn1.BackColor = Color.Yellow;
                    btn2.BackColor = Color.Red;
                    btn3.BackColor = Color.Yellow;
                    btn4.BackColor = Color.Red;

                    btn5.BackColor = Color.Red;
                    btn6.BackColor = Color.Yellow;
                    btn7.BackColor = Color.Red;
                    btn8.BackColor = Color.Yellow;
                }
                if (saniye % 10 == 0)
                {
                    btn1.BackColor = Color.Red;
                    btn2.BackColor = Color.Yellow;
                    btn3.BackColor = Color.Red;
                    btn4.BackColor = Color.Yellow;

                    btn5.BackColor = Color.Yellow;
                    btn6.BackColor = Color.Red;
                    btn7.BackColor = Color.Yellow;
                    btn8.BackColor = Color.Red;
                }
            }
        }

        private void checkTrabzon_CheckedChanged(object sender, EventArgs e)
        {
            checkBesiktas.Checked = false;
            checkFener.Checked = false;
            checkGalata.Checked = false;

            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\urems\source\repos\games\game-supporter\music\trabzon.mp3";
        }

        private void checkFener_CheckedChanged(object sender, EventArgs e)
        {
            checkTrabzon.Checked = false;
            checkBesiktas.Checked = false;
            checkGalata.Checked = false;

            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\urems\source\repos\games\game-supporter\music\fener.mp3";
        }

        private void checkGalata_CheckedChanged(object sender, EventArgs e)
        {
            checkTrabzon.Checked = false;
            checkFener.Checked = false;
            checkBesiktas.Checked = false;

            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\urems\source\repos\games\game-supporter\music\galatasaray.mp3";
        }

        private void Supporties_Load(object sender, EventArgs e)
        {

        }
    }
}
