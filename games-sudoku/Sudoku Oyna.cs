using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games_sudoku
{
    public partial class Form1 : Form
    {
        int[,] sudoku = new int[3, 3];
        Random r = new Random();
        int random = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sudoku[i, j] = 0;
                }
            }
            random = r.Next(1, 4);
            for (int f = 0; f < 3; f++)
            {
                for (int i = 0; i < 3; i++)
                {
                    while (ControlRows(sudoku, f, random) == false || ControlColumn(sudoku, i, random) == false)
                    {
                        random = r.Next(1, 4);
                    }
                    sudoku[f, i] = random;
                }
            }
            txt1.Text = sudoku[0, 0].ToString();
            txt2.Text = sudoku[0, 1].ToString();
            txt3.Text = sudoku[0, 2].ToString();
            txt4.Text = sudoku[1, 0].ToString();
            txt5.Text = sudoku[1, 1].ToString();
            txt6.Text = sudoku[1, 2].ToString();
            txt7.Text = sudoku[2, 0].ToString();
            txt8.Text = sudoku[2, 1].ToString();
            txt9.Text = sudoku[2, 2].ToString();

        }
        public bool ControlRows(int[,] sudoku, int satir, int kontrol)
        {
            for (int i = 0; i < 3; i++)
            {
                if (sudoku[satir, i] == kontrol)
                {
                    return false;
                }
            }
            return true;
        }
        public bool ControlColumn(int[,] sudoku, int sutun, int kontrol)
        {
            for (int i = 0; i < 3; i++)
            {
                if (sudoku[i, sutun] == kontrol)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
