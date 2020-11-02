using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games_random_player
{
    public partial class Form1 : Form
    {
        int number = 0;
        Random randomNumber = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\urems\source\repos\games\games-random-player\image-music\videoplayback.mp4";
            pictureBox1.ImageLocation = @"C:\Users\urems\source\repos\games\games-random-player\image-music\game-of-thrones.jpg";
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\urems\source\repos\games\games-random-player\image-music\videoplayback (1).mp4";
            pictureBox1.ImageLocation = @"C:\Users\urems\source\repos\games\games-random-player\image-music\got.jpg";
        }


    }
}
