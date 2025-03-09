using QuizGame;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace YourProjectNamespace
{
    static class Program
    {
        private static PrivateFontCollection _fontCollection = new PrivateFontCollection();

        [STAThread]
        static void Main()
        {
            // Fontu yükle

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Her formda bu fontu kullanmak için Global fontu ayarla
            Application.Run(new Main());
        }

        public static Font GetCustomFont(float size)
        {
            return new Font(_fontCollection.Families[0], size);
        }
    }
}
