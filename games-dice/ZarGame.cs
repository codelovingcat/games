using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games_dice
{
    public partial class ZarGame : Form
    {
        Random random = new Random();
        int toplam1 = 0;
        int toplam2 = 0;
        public ZarGame()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart2.Enabled = true;

            int zar1 = random.Next(1, 7);
            int zar2 = random.Next(1, 7);

            if (zar1 == 1)
            {
                pictureZar1.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\zar1.png";
            }
            if (zar1 == 2)
            {
                pictureZar1.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\Dice-2.png";
            }
            if (zar1 == 3)
            {
                pictureZar1.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\zar3.png";
            }
            if (zar1 == 4)
            {
                pictureZar1.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\dice4.png";
            }
            if (zar1 == 5)
            {
                pictureZar1.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\dice-5.png";
            }
            if (zar1 == 6)
            {
                pictureZar1.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\zar6.png";
            }

            if (zar2 == 1)
            {
                pictureZar2.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\zar1.png";
            }
            if (zar2 == 2)
            {
                pictureZar2.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\Dice-2.png";
            }
            if (zar2 == 3)
            {
                pictureZar2.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\zar3.png";
            }
            if (zar2 == 4)
            {
                pictureZar2.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\dice4.png";
            }
            if (zar2 == 5)
            {
                pictureZar2.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\dice-5.png";
            }
            if (zar2 == 6)
            {
                pictureZar2.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\zar6.png";
            }

            lblZar1.Text = zar1.ToString();
            lblZar2.Text = zar2.ToString();

            toplam1 = toplam1 + zar1 + zar2;
            lblToplamPuan.Text = toplam1.ToString();

            lbl1OyuncuPuan.Text = toplam1.ToString();

            if (toplam1 >= 100)
            {
                lblToplamPuan.Text = "Tebrikler Kazandın!!!";

                btnStart.Enabled = false;
                btnStart2.Enabled = false;
                MessageBox.Show(toplam1 + " Puanla 1. Oyuncu Kazandı!!!.");
                btnNewGame.Visible = true;
            }
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStart2.Enabled = false;

            int zar1 = random.Next(1, 7);
            int zar2 = random.Next(1, 7);

            if (zar1 == 1)
            {
                picture2Zar1.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\zar1.png";
            }
            if (zar1 == 2)
            {
                picture2Zar1.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\Dice-2.png";
            }
            if (zar1 == 3)
            {
                picture2Zar1.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\zar3.png";
            }
            if (zar1 == 4)
            {
                picture2Zar1.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\dice4.png";
            }
            if (zar1 == 5)
            {
                picture2Zar1.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\dice-5.png";
            }
            if (zar1 == 6)
            {
                picture2Zar1.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\zar6.png";
            }

            if (zar2 == 1)
            {
                picture2Zar2.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\zar1.png";
            }
            if (zar2 == 2)
            {
                picture2Zar2.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\Dice-2.png";
            }
            if (zar2 == 3)
            {
                picture2Zar2.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\zar3.png";
            }
            if (zar2 == 4)
            {
                picture2Zar2.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\dice4.png";
            }
            if (zar2 == 5)
            {
                picture2Zar2.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\dice-5.png";
            }
            if (zar2 == 6)
            {
                picture2Zar2.ImageLocation = @"C:\Users\urems\source\repos\games\games-dice\images\zar6.png";
            }

            lbl2Zar1.Text = zar1.ToString();
            lbl2Zar2.Text = zar2.ToString();

            toplam2 = toplam2 + zar2 + zar1;
            lblToplam2.Text = toplam2.ToString();

            lbl2OyuncuPuan.Text = toplam2.ToString();
            if (toplam2 >= 100)
            {
                lblToplam2.Text = "Tebrikler Kazandın!!!";
                btnStart.Enabled = false;
                btnStart2.Enabled = false;

                MessageBox.Show(toplam2 + " Puanla 2. Oyuncu Kazandı!!!.");
                btnNewGame.Visible = true;
            }
        }

        private void ZarGame_Load(object sender, EventArgs e)
        {
            btnNewGame.Visible = false;
            btnStart.Enabled = true;
            btnStart2.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ZarGame form1 = new ZarGame();
            form1.Show();
            this.Hide();
        }
    }
    
}
