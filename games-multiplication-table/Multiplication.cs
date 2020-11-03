using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games_multiplication_table
{
    public partial class Multiplication : Form
    {
        public Multiplication()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is ListBox)
                {
                    (item as ListBox).Items.Clear();
                }
            }

            int number1, number2;

            for (number1 = 1; number1 <= 10; number1++)
            {
                for (number2 = 1; number2 <= 10; number2++)
                {
                    int sonuc = number1 * number2;

                    switch (number1)
                    {
                        case 1:
                            listBox1.Items.Add(number1 + " X " + number2 + " = " + sonuc);
                            break;
                        case 2:
                            listBox2.Items.Add(number1 + " X " + number2 + " = " + sonuc);
                            break;
                        case 3:
                            listBox3.Items.Add(number1 + " X " + number2 + " = " + sonuc);
                            break;
                        case 4:
                            listBox4.Items.Add(number1 + " X " + number2 + " = " + sonuc);
                            break;
                        case 5:
                            listBox5.Items.Add(number1 + " X " + number2 + " = " + sonuc);
                            break;
                        case 6:
                            listBox6.Items.Add(number1 + " X " + number2 + " = " + sonuc);
                            break;
                        case 7:
                            listBox7.Items.Add(number1 + " X " + number2 + " = " + sonuc);
                            break;
                        case 8:
                            listBox8.Items.Add(number1 + " X " + number2 + " = " + sonuc);
                            break;
                        case 9:
                            listBox9.Items.Add(number1 + " X " + number2 + " = " + sonuc);
                            break;
                        case 10:
                            listBox10.Items.Add(number1 + " X " + number2 + " = " + sonuc);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
