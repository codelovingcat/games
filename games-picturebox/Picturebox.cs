using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games_picturebox
{
    public partial class Picturebox : Form
    {
        public Picturebox()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right)
                x -= 5;
            else if (e.KeyCode == Keys.Up && y > 0)
                y -= 5;
            else if (e.KeyCode == Keys.Down && y < 410)
                y += 5;
            pictureBox1.Location = new Point(x, y);

            if (x < 100 && y < 100)
            {
                MessageBox.Show(" Tebrikler Kordinatları Buldunuz!!!.");
                pictureBox1.Location = new Point(250, 250);
            }
        }
    }
}
