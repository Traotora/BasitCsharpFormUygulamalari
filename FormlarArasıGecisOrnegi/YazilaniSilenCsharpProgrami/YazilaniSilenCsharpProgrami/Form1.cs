using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilaniSilenCsharpProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.AutoSize = true;
            button2.AutoSize = true;
            button3.AutoSize = true;
            button1.Text = "TextBox'a yaz.";
            button2.Text = "Sil";
            button3.Text = "programı kapat";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Merhaba. Bu benim ilk programım değil.";
            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
