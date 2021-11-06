using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegerVeReferansTipiDegiskenTanimlamaOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string mesaj = "Ana Program tarafından oluşturulan mesaj. ";
            MessageBox.Show(mesaj);
            mesajyaz(ref mesaj); // ref: referans türüne dönüştürür.
            MessageBox.Show(mesaj); // 
        }

        private void mesajyaz(ref string mesaj) // ref: refarans türüne dönüştürür.
        {
            mesaj = "Metod tarafından oluştırulan mesaj. ";
        }
        /* 24. ve 28. satırlara ref yazılmasa aşağıdaki durum olacaktı;
           Programı çalıştırdığımızda "Ana Program tarfından oluşturulan mesaj." yazısı iki kere ekrana gelirdi. Çünkü
           değer tipinde tanımladığımız için, mesaj değişkenini içeriğinde yapılan değişiklik ana programdaki mesaj
           değişkeninin içeriğini etkilememektedir. */
    }

}
