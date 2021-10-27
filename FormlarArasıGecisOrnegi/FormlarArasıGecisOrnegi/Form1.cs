using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasıGecisOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2(); // fr2 yerine f2'de diyebiliriz. Bu bize kalmış bir şey. 
            fr2.Show(); // Bu this.Hide ve this. Close'u kullanmak için .Show yazılmalı. Diğer türlü çalışmıyor o ikisi.
            this.Hide(); // Önceki formu gizler. Yani Ana Sayfadan, 2. Sayfa seçimini yaptıktan sonra Ana Sayfa gizlenir.
            // Başına this. yazmasakta olur.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3(); // fr3'ü kafamıza göre isimlendiriyoruz. Değişken yani. 
            fr3.ShowDialog(); // Sadece fr3.Show yazsaydık. Açılan pencerede 2. sayfatı seçtikten sonra bile Ana Sayfadaki butonları kullabilirdik.
                              // ShowDialog'ta Yuykarıda bahsettiğimi yapmaya kalksan uyarsı sesi verir. Ana sayfadaki butonlara basamazdın. 
            // this.Close();   //  Önceki formu kapatır. Yani Ana Sayfadan, 2. Sayfa seçimini yaptıktan sonra Ana Sayfa kapanır.
            // Başına this. yazmasakta olur.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Çıkış işlşemi yapar.
           // Environment.Exit(0); // Çıkış işlemi yapar. (Alternatif)

        }
    }
}
