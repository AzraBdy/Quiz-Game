using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourProjectNamespace;

namespace QuizGame
{
    public partial class Main : Form
    {
        private Software softwareForm;
        private Cinema cinemaForm;
        public Main()
        {
            InitializeComponent();


        }

        // Formun Load olayında butonları devre dışı bırakıyoruz
        private void Main_Load(object sender, EventArgs e)
        {
            CinemaB.Enabled = false;
            SoftwareB.Enabled = false;
        }



        // CinemaB butonuna tıklanıldığında
      

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void NickTb_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(NickTb.Text))
            {
                MessageBox.Show("Bir Nick Oluşturun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (softwareForm == null || softwareForm.IsDisposed)
            {
                softwareForm = new Software();
                softwareForm.Show();
            }

            // Software formundaki NickLbl'ye, Main formdaki NickTb'yi aktaralım
            softwareForm.SetNick(NickTb.Text);

            // Eğer Cinema formu açıksa, Cinema formundaki NickLbl'ye aktaralım
            if (cinemaForm != null && cinemaForm.Visible)
            {
                cinemaForm.SetNick(NickTb.Text);
            }

            // Main formu gizleyebiliriz
            this.Hide();
        }

        // Software formuna gitmek için bir buton
        private void SoftwareB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NickTb.Text))
            {
                MessageBox.Show("Bir Nick Oluşturun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nick girildiyse, Software formunu açıyoruz
            softwareForm = new Software();
            softwareForm.SetNick(NickTb.Text);  // Nick'i aktarıyoruz
            softwareForm.Show();
            this.Hide(); // Ana formu gizliyoruz
        }

        // Cinema formuna gitmek için bir buton
        private void CinemaB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NickTb.Text))
            {
                MessageBox.Show("Bir Nick Oluşturun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nick girildiyse, Cinema formunu açıyoruz
            cinemaForm = new Cinema();
            cinemaForm.SetNick(NickTb.Text);  // Nick'i aktarıyoruz
            cinemaForm.Show();
            this.Hide(); // Ana formu gizliyoruz
        }
    }



}
    

    // MainForm.cs




