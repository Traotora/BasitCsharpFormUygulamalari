using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfKomutu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // KARŞILAŞTIRMA VE MANTIK OPERATÖRLERİ
        // - Karşılaştırma Operatörleri
        /* > büyük mü? | < Küçük mü? | >= Büyük eşit | <= Küçük eşit | == Eşit mi? | != Farklı mı?  */
        // -----------------------------
        // - Mantık Operatörleri
        /* && Ve   |   || Veya   |    ! Değildir  */
        private void Form1_Load(object sender, EventArgs e)
        {
            int ilksayi, ikincisayi;
            ilksayi = 10;
            ikincisayi = 7;
            if(ilksayi>ikincisayi)
            {
                MessageBox.Show("İlk sayı büyüktür.");
            }
            else
            {
                MessageBox.Show("İkinci sayı büyüktür.");
            }
        }
    }
}
