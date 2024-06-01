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
    public partial class FormCover : Form
    {
        public FormCover()
        {
            InitializeComponent();
            this.displayPoint();
        }
        public void displayPoint() 
        {
            listBox.Items.Clear();
            for (int i = 0; i < myList.Count; i++) 
            {
                int gameKe = i + 1;
                listBox.Items.Add("Game " + gameKe + " : " + myList[i]);
            }
        }
        public List<int> myList = new List<int>();
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDalamGame f2 = new FormDalamGame(this);
            f2.Show();
            f2.Soal();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
