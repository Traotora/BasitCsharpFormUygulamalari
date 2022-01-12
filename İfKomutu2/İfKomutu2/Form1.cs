using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İfKomutu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int ilksayi, ikincisayi;
            ilksayi = 10;
            ikincisayi = 7;
            bool sonuc = false;
            sonuc = (ilksayi > ikincisayi);
            if(sonuc)
            {
                MessageBox.Show("İlk sayı büyüktür");

            }
            else
            {
                MessageBox.Show("İkinci sayı büyüktür");
            }


        }
    }
}
