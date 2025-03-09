using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Cinema : Form
    {
        private int score = 0;

        public Cinema()
        {
            InitializeComponent();

        }

   
  
        private void HomePb_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
            score++;
            PointTb.Text = score.ToString();

        }

        // Buton B'ye tıklanınca yanlış mesajı verir
        private void BButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try Again!");
        }

        // Buton C'ye tıklanınca yanlış mesajı verir
        private void CButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try Again!");
        }

        // Buton D'ye tıklanınca yanlış mesajı verir
        private void DButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try Again!");
        }

        public void SetNick(string nick)
        {
            GamerTb.Text = nick;  // Nick değeri, Software formundaki GamerTb'ye aktarılır.
        }
        private void PointTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClosePb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void GamerTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void NickLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
