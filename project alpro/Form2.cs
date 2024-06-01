using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ProjectAlpro
{
    public partial class FormDalamGame : Form
    {
        int soal1;
        int soal2;
        double hasil;
        int pointSoal;
        int waktu = 30;
        int total;
        List<int> Score = new List<int>();
        public FormDalamGame(FormCover _f1)
        {
            InitializeComponent();
            this.f1 = _f1;
        }
        public FormCover f1;
        public double jawaban(Random random, double hasilJawaban)
        {
            int x = random.Next(1, 3);
            double result = 0;
            if (x == 1)
            {
                int minHasil = (int) hasilJawaban - 5;
                result = random.Next(minHasil, (int)hasilJawaban);
            }
            else
            {
                int maxHasil = (int)hasilJawaban + 10;
                result = random.Next((int)hasilJawaban + 1, maxHasil);
            }
            int jawabanBulat = (int)hasilJawaban;
            double sisa = hasilJawaban - jawabanBulat;
            if (sisa > 0) 
            {
                int decInt = random.Next(1, 10);
                double koma = (double)decInt / 10;
                result -= koma;
            }
            return result;
        }
        public void Soal()
        {
            Random random= new Random();
            int x = random.Next(1, 5);
            soal1 = random.Next(1, 101);
            soal2 = random.Next(1, 11);
            hasil = 0;
            if (x == 1)
            {
                hasil = soal1 + soal2;
                label1.Text = soal1 + " + "+soal2;
            }
            else if (x == 2)
            {
                hasil = soal1 - soal2;
                label1.Text = soal1 + " - " + soal2;
            }
            else if (x== 3)
            {
                hasil = soal1 * soal2;
                label1.Text = soal1 + " x " + soal2;
            }
            else if (x == 4)
            {
                hasil = (double)soal1 / soal2;
                hasil = Math.Round(hasil,1);
                label1.Text = soal1 + " ÷ " + soal2;
            }
            radioButton1.Text = this.jawaban(random, hasil).ToString();
            radioButton2.Text = this.jawaban(random, hasil).ToString();
            radioButton3.Text = this.jawaban(random, hasil).ToString();
            radioButton1.Checked = false; 
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            int radioIndex = random.Next(1, 4);
            if (radioIndex == 1)
            {
                radioButton1.Text = hasil.ToString();
            }
            else if (radioIndex == 2)
            {
                radioButton2.Text = hasil.ToString();
            }
            else if (radioIndex == 3)
            {
                radioButton3.Text = hasil.ToString();
            }
            pointSoal = 10;
        }

        private void TotalScore()
        {
            total = 0;
            for (int i = 0; i < Score.Count; i++)
            {
                total = total + Score[i];
            }
            label3.Text = total.ToString();
        }
        private void jawabanBenar(double x)
        {
            if (hasil == x)
            {
                Score.Add(pointSoal);
            }
        }
        private void jawabanSalah (double x)
        {
            if (hasil != x)
            {
                Score.Add(-5);
            }
        }
        public void backToStart()
        {
            f1.Show();
            f1.displayPoint();
            this.Close();
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            double jawabanUser = 0;
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                timerMain.Stop();
                MessageBox.Show("Choose the answer first");
                timerMain.Start();
            }
            else 
            {
                if (radioButton1.Checked)
                {
                    jawabanUser = Convert.ToDouble(radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    jawabanUser = Convert.ToDouble(radioButton2.Text);
                }
                if (radioButton3.Checked)
                {
                    jawabanUser = Convert.ToDouble(radioButton3.Text);
                }
                jawabanBenar(jawabanUser);
                jawabanSalah(jawabanUser);
                TotalScore();
                Soal();
            }
        }
        private void timerMain_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = waktu--.ToString();
            if (waktu == 0)
            {
                FormGameOver f3 = new FormGameOver(total, this.f1);
                timerMain.Stop();
                f3.Show();
                this.Close();
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.backToStart();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void FormDalamGame_Load(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
