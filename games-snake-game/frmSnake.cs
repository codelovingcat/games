using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games_snake_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] SnakePart = new PictureBox[4]; 
        int LastIndex = 0; 
        int HeadIndex = 0;
        bool GameStatus = false; 
        char SnakeWay = (char)0;
        bool SnakeCrashed = false;

        private void CreateSnake() 
        {
            SnakePart = new PictureBox[4];
            for (int i = 0; i < SnakePart.Length; i++)
            {
                SnakePart[i] = new PictureBox();
                SnakePart[i].Width = 15;
                SnakePart[i].Height = 15;
                SnakePart[i].Top = 0;
                SnakePart[i].Left = i * (SnakePart[i].Width + 1);
                SnakePart[i].BackColor = Color.White;
                pbGame.Controls.Add(SnakePart[i]);
            }
            HeadIndex = SnakePart.Length - 1;
        }

        private void DeleteSnake()
        {
            for (int i = 0; i < SnakePart.Length; i++)
            {
                pbGame.Controls.Remove(SnakePart[i]);
            }
        }

        private void SnakePartAdd()
        {
            Array.Resize(ref SnakePart, SnakePart.Length + 1);
            SnakePart[SnakePart.Length - 1] = new PictureBox();
            SnakePart[SnakePart.Length - 1].Width = 15;
            SnakePart[SnakePart.Length - 1].Height = 15;
            
            SnakePart[SnakePart.Length - 1].Top = -20;
            SnakePart[SnakePart.Length - 1].Left = -20; 
            SnakePart[SnakePart.Length - 1].BackColor = Color.Black;
            pbGame.Controls.Add(SnakePart[SnakePart.Length - 1]);
        }
        
        private void SnakeCrashControl() 
        {
            for (int i = 0; i < SnakePart.Length; i++) 
            {

                float mutlakX = Math.Abs((SnakePart[HeadIndex].Left + (SnakePart[HeadIndex].Width / 2)) - (SnakePart[i].Left + (SnakePart[i].Width / 2)));
                float mutlakY = Math.Abs((SnakePart[HeadIndex].Top + (SnakePart[HeadIndex].Height / 2)) - (SnakePart[i].Top + (SnakePart[i].Height / 2)));
                float farkGenislik = (SnakePart[HeadIndex].Width / 2) + (SnakePart[i].Width / 2);
                float farkYukselik = (SnakePart[HeadIndex].Height / 2) + (SnakePart[i].Height / 2);
                if ((farkGenislik > mutlakX) && (farkYukselik > mutlakY) && i != HeadIndex)
                {
                    SnakeCrashed = true;
                    break;
                }
            }

            if (SnakePart[HeadIndex].Left >= pbGame.Width - SnakePart[HeadIndex].Width)
            {
                SnakeCrashed = true;
            }
            else if (SnakePart[HeadIndex].Top >= pbGame.Height - SnakePart[HeadIndex].Height)
            {
                SnakeCrashed = true;
            }
            else if (SnakePart[HeadIndex].Top <= -1)
            {
                SnakeCrashed = true;
            }
            else if (SnakePart[HeadIndex].Left <= -1)
            {
                SnakeCrashed = true;
            }

            if (SnakeCrashed)
            {
                GameStatus = false;
                timer1.Enabled = false;
                MessageBox.Show("Eyvah!!!. Oyunu Kaybettiniz. Score : " + Score.ToString(), "Dikkat");
            }
        }

        int GoLeft = 0, GoTop = 0;
        private void SnakeMove(int top, int left)
        {
            SnakePart[LastIndex].Left = SnakePart[HeadIndex].Left + left;
            SnakePart[LastIndex].Top = SnakePart[HeadIndex].Top + top;

            if (LastIndex == SnakePart.Length - 1)
            {
                LastIndex = 0;
                HeadIndex = SnakePart.Length - 1;
            }
            else
            {
                LastIndex++;
                HeadIndex = LastIndex - 1;
            }
        }

        Random r = new Random();
        PictureBox Food;
        int Score = 0;

        private void CreateFood()
        {
            int FoodTop = 16 * r.Next(1, 30);
            int FoodLeft = 16 * r.Next(1, 30);
            Food = new PictureBox();
            Food.Width = 15;
            Food.Height = 15;
            Food.Left = FoodLeft;
            Food.Top = FoodTop;
            Food.BackColor = Color.White;
            pbGame.Controls.Add(Food);
        }

        bool FoodEat = false;
        private void FoodEatControl()
        {
            float mutlakX = Math.Abs((SnakePart[HeadIndex].Left + (SnakePart[HeadIndex].Width / 2)) - (Food.Left + (Food.Width / 2)));
            float mutlakY = Math.Abs((SnakePart[HeadIndex].Top + (SnakePart[HeadIndex].Height / 2)) - (Food.Top + (Food.Height / 2)));
            float farkGenislik = (SnakePart[HeadIndex].Width / 2) + (Food.Width / 2);
            float farkYukselik = (SnakePart[HeadIndex].Height / 2) + (Food.Height / 2);
            if ((farkGenislik > mutlakX) && (farkYukselik > mutlakY))
            {
                FoodEat = true;
            }

            if (FoodEat)
            {      
                SnakePartAdd();
                Score += 10;
                lblScore.Text = "Score : " + Score.ToString();
                DeleteFood();
                CreateFood();
                FoodEat = false;
            }
        }

        private void DeleteFood()
        {
            pbGame.Controls.Remove(Food);
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            duraklatToolStripMenuItem.Text = "Duraklat";
            lblScore.Text = "Score : 0";
            Score = 0;
            FoodEat = false;
            GoLeft = 16; GoTop = 0;
            SnakeWay = 'R';
            SnakeCrashed = false;
            GameStatus = true;
            LastIndex = 0;

            DeleteSnake();
            CreateSnake();

            DeleteFood();
            CreateFood();

            timer1.Enabled = true;
        }

        private void duraklatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GameStatus || duraklatToolStripMenuItem.Text == "Devam Et")
            {
                if (duraklatToolStripMenuItem.Text == "Duraklat")
                {
                    timer1.Enabled = false;
                    GameStatus = false;
                    duraklatToolStripMenuItem.Text = "Devam Et";
                }
                else
                {
                    timer1.Enabled = true;
                    GameStatus = true;
                    duraklatToolStripMenuItem.Text = "Duraklat";
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (GameStatus)
            {
                if (e.KeyCode == Keys.Right && SnakeWay != 'L')
                {
                    GoLeft = 0; GoTop = 0;
                    GoLeft = 16;
                    SnakeWay = 'R';
                }
                else if (e.KeyCode == Keys.Left && SnakeWay != 'R')
                {
                    GoLeft = 0; GoTop = 0;
                    GoLeft = -16;
                    SnakeWay = 'L';
                }
                else if (e.KeyCode == Keys.Up && SnakeWay != 'D')
                {
                    GoLeft = 0; GoTop = 0;
                    GoTop = -16;
                    SnakeWay = 'U';
                }
                else if (e.KeyCode == Keys.Down && SnakeWay != 'U')
                {
                    GoLeft = 0; GoTop = 0;
                    GoTop = 16;
                    SnakeWay = 'D';
                }  
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GameStatus)
            {
                SnakeMove(GoTop, GoLeft);
                SnakeCrashControl();
                FoodEatControl();
            }
        }
    }
}
