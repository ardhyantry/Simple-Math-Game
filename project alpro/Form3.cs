using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAlpro
{
    public partial class FormGameOver : Form
    {
        public FormGameOver(int total, FormCover _f1)
        {
            InitializeComponent();
            label1.Text = " Total Score :" + total;
            this.f1 = _f1;
            this.f1.myList.Add(total);
        }
        public FormCover f1;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void buttonTryAgain_Click(object sender, EventArgs e)
        {
            FormDalamGame f2 = new FormDalamGame(this.f1);
            f2.Show();
            f2.Soal();
            this.Close();
        }
        private void buttonBackToStart_Click(object sender, EventArgs e)
        {
            f1.Show();
            f1.displayPoint();
            this.Close();
        }
        private void FormGameOver_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
