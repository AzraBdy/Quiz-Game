using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Software : Form
    {
        private int score = 0;

        public Software()
        {
            InitializeComponent();

        }


        private void HomePb_Click(object sender, EventArgs e)
        {
            
                Main main = new Main();
                main.Show();
            
        }

        private void ClosePb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try Again!");
        }

        // Buton B'ye tıklanınca yanlış mesajı verir
        private void BButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
            score++;
            PointTb.Text = score.ToString();
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
      
    }
}
