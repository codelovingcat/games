using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games_puzzle
{
    public partial class Puzzle : Form
    {
        private Point bosYer;
        private int saniye = 0;
        private int dakika = 0;

        List<Image> resimParcalari = new List<Image>();
        List<PictureBox> resimAlanlari = new List<PictureBox>();
        Bitmap CurrentBitmapImage;
        public Puzzle()
        {
            InitializeComponent();
        }
        private void YeniOyun()
        {

            for (int i = 0; i < resimAlanlari.Count; i++)
            {
                this.Controls.Remove(resimAlanlari[i]);
            }

            resimAlanlari.Clear();
            resimParcalari.Clear();

            pictureBox1.Location = new Point(550, 30);
            //pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Size = new System.Drawing.Size(300, 350);
            pictureBox1.Image = CurrentBitmapImage.Clone(new Rectangle(new Point(0, 0), new Size(375, 275)), System.Drawing.Imaging.PixelFormat.DontCare);

            for (int i = 0; i < 9; i++)
            {
                resimParcalari.Add(CurrentBitmapImage.Clone(new Rectangle(new Point(i / 3 * 125, i % 3 * 125), new Size(125, 125)), System.Drawing.Imaging.PixelFormat.DontCare));
            }

            List<int> resimDagilimi = new List<int>();
            Random rastgele = new Random();

            for (int i = 0; i < 8; i++)
            {
                int resimNo = rastgele.Next(8);
                if (!resimDagilimi.Contains(resimNo))
                {
                    resimDagilimi.Add(resimNo);
                }
                else
                {
                    i--;
                }

            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (!(j == 2 && i == 2))
                    {
                        PictureBox resim = new PictureBox();
                        resim.Click += new EventHandler(p_Click);
                        resim.Location = new Point(125 * i + 30, 125 * j + 30);
                        resim.BorderStyle = BorderStyle.FixedSingle;
                        resim.Size = new System.Drawing.Size(125, 125);
                        resim.Tag = resimDagilimi[i * 3 + j].ToString();
                        resim.Image = resimParcalari[resimDagilimi[i * 3 + j]];
                        resimAlanlari.Add(resim);
                        this.Controls.Add(resim);
                    }
                    else
                    {
                        bosYer = new Point(125 * 2 + 30, 125 * 2 + 30);
                    }
                }
            }

            timer1.Enabled = true;
            saniye = 0;
            dakika = 0;
            lblDakika.Text = dakika.ToString("00");
            lblSaniye.Text = saniye.ToString("00");
        }
        void p_Click(object sender, EventArgs e)
        {
            PictureBox resim = (PictureBox)sender;

            if ((resim.Location.X - 125 == bosYer.X) && (resim.Location.Y == bosYer.Y))
            {
                resim.Location = bosYer;
                bosYer.X += 125;
                this.Focus();
            }
            else if (resim.Location.X + 125 == bosYer.X && (resim.Location.Y == bosYer.Y))
            {
                resim.Location = bosYer;
                bosYer.X -= 125;
                this.Focus();
            }
            else if (resim.Location.Y - 125 == bosYer.Y && (resim.Location.X == bosYer.X))
            {
                resim.Location = bosYer;
                bosYer.Y += 125;
                this.Focus();
            }

            else if (resim.Location.Y + 125 == bosYer.Y && (resim.Location.X == bosYer.X))
            {
                resim.Location = bosYer;
                bosYer.Y -= 125;
                this.Focus();
            }

            bool durum = OyunDurumunuKontrolEt();

            if (durum)
            {
                timer1.Enabled = false;

                MessageBox.Show("Tebrikler oyunu tamamladınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private bool OyunDurumunuKontrolEt()
        {
            bool durum = true;
            for (int i = 0; i < resimAlanlari.Count; i++)
            {
                int id = int.Parse(resimAlanlari[i].Tag.ToString());

                if (!(resimAlanlari[i].Location.X == (id / 3) * 125 + 50 && resimAlanlari[i].Location.Y == (id % 3) * 125 + 50))
                {
                    durum = false;
                    break;
                }
            }


            return durum;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            YeniOyun();
        }

        private void Puzzle_Load(object sender, EventArgs e)
        {
            CurrentBitmapImage = new Bitmap(games_puzzle.Properties.Resources.resim, new Size(375, 375));

            YeniOyun();
        }

        private void btnNextTo_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye++ == 60)
            {
                lblDakika.Text = dakika++.ToString("00");
                saniye = 0;
            }

            lblSaniye.Text = saniye.ToString("00");
        }
    }
}
