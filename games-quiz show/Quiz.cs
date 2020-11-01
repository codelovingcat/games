using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games_quiz_show
{
    public partial class Quiz : Form
    {
        int sayac = 60;
        int question = 0;
        int dogru = 0, yanlis = 0;
        public Quiz()
        {
            InitializeComponent();
            lblDogruCevap.Visible = false;
            lblEslestirme.Visible = false;
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnD.Enabled = true;
            btnC.Enabled = true;

            btnA.BackColor = Color.LightGray;
            btnB.BackColor = Color.LightGray;
            btnC.BackColor = Color.LightGray;
            btnD.BackColor = Color.LightGray;

            btnIleri.Text = "İleri";
            question++;
            lblSoru.Text = question.ToString();
            if (question == 1)
            {
                richTextBox1.Text = " 1) Mustafa Kemal Atatürk kaç yılında doğmuştur?";
                btnA.Text = "1888";
                btnB.Text = "1981";
                btnC.Text = "1881";
                btnD.Text = "1882";

                lblDogruCevap.Text = "1881";
            }
            if (question == 2)
            {
                richTextBox1.Text = " 2) Anıtkabir hangi ilimizdedir?";
                btnA.Text = "Ankara";
                btnB.Text = "İstanbul";
                btnC.Text = "İzmir";
                btnD.Text = "Bursa";

                lblDogruCevap.Text = "Ankara";
            }
            if (question == 3)
            {
                richTextBox1.Text = " 3) Türkiye de kaç coğrafi bölge vardır?";
                btnA.Text = "15";
                btnB.Text = "5";
                btnC.Text = "10";
                btnD.Text = "7";

                lblDogruCevap.Text = "7";
            }
            if (question == 4)
            {
                richTextBox1.Text = " 4) Türkiye nin en kalabalık nüfusa sahip ili hangisidir?";
                btnA.Text = "Ankara";
                btnB.Text = "Konya";
                btnC.Text = "Adana";
                btnD.Text = "İstanbul";

                lblDogruCevap.Text = "İstanbul";
            }
            if (question == 5)
            {
                richTextBox1.Text = " 5) İstiklal marşı kaç kıtadan oluşmaktadır?";
                btnA.Text = "11";
                btnB.Text = "10";
                btnC.Text = "8";
                btnD.Text = "12";

                lblDogruCevap.Text = "10";

                btnIleri.Enabled = false;
                btnBitir.Visible = true;

            }
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            btnBitir.Visible = false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnC.Enabled = false;
            btnB.Enabled = false;
            btnD.Enabled = false;
            btnA.Enabled = false;


            lblEslestirme.Text = btnA.Text;
            if (lblEslestirme.Text == lblDogruCevap.Text)
            {
                timer1.Enabled = false;
                sayac = sayac + 3;
                lblSayac.Text = sayac.ToString();
                btnA.BackColor = Color.Green;
                richTextBox1.Text = " Cevabınız Doğru";
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                sayac = sayac - 3;
                lblSayac.Text = sayac.ToString();
                lblYanlis.Text = yanlis.ToString();
                richTextBox1.Text = " Cevabınız Yanlış";
                btnA.BackColor = Color.Red;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnB.Enabled = false;


            lblEslestirme.Text = btnB.Text;
            if (lblEslestirme.Text == lblDogruCevap.Text)
            {
                timer1.Enabled = false;
                sayac = sayac + 3;
                lblSayac.Text = sayac.ToString();
                btnB.BackColor = Color.Green;
                richTextBox1.Text = " Cevabınız Doğru";
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                sayac = sayac - 3;
                lblSayac.Text = sayac.ToString();
                lblYanlis.Text = yanlis.ToString();
                richTextBox1.Text = " Cevabınız Yanlış";
                btnB.BackColor = Color.Red;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblEslestirme.Text = btnC.Text;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnD.Enabled = false;
            btnC.Enabled = false;

            if (lblEslestirme.Text == lblDogruCevap.Text)
            {
                timer1.Enabled = false;
                sayac = sayac + 3;
                lblSayac.Text = sayac.ToString();
                btnC.BackColor = Color.Green;
                richTextBox1.Text = " Cevabınız Doğru";
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                sayac = sayac - 3;
                lblSayac.Text = sayac.ToString();
                lblYanlis.Text = yanlis.ToString();
                richTextBox1.Text = " Cevabınız Yanlış";
                btnC.BackColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac = Convert.ToInt32(lblSayac.Text);

            sayac = sayac - 1;
            lblSayac.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer1.Enabled = false;
                btnIleri.Enabled = false;
                MessageBox.Show("Süre Bitti !!! ");
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnD.Enabled = false;
            btnC.Enabled = false;

            lblEslestirme.Text = btnD.Text;
            if (lblEslestirme.Text == lblDogruCevap.Text)
            {
                timer1.Enabled = false;
                sayac = sayac + 3;
                lblSayac.Text = sayac.ToString();
                btnD.BackColor = Color.Green;
                richTextBox1.Text = " Cevabınız Doğru";
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                sayac = sayac - 3;
                lblSayac.Text = sayac.ToString();
                lblYanlis.Text = yanlis.ToString();
                richTextBox1.Text = " Cevabınız Yanlış";
                btnD.BackColor = Color.Red;
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            Quiz form = new Quiz();
            form.Show();
            this.Hide();
        }
    }
}
