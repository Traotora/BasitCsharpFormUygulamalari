﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlinanNotaGoreGecmeKalmaDurmunuHersaplaynProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = Convert.ToInt32(textBox1.Text);
            if((sonuc>100)||(sonuc<0))
            {
                MessageBox.Show("Lütfen 100 ile 0 arasında bir değer girin.");
            }
            else if(sonuc>60)
            {
                MessageBox.Show("Geçtiniz.");
            }
            else
            {
                MessageBox.Show("Kaldınız..");
            }
        }
    }
}
