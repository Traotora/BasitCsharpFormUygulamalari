using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blok
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
            int x, y, z;
            x = 4;
            y = 3;
            z = (int)Math.Sqrt(x * x + y * y);
            {
                int i = 12;
                MessageBox.Show("blok içinden, z=" + z.ToString());
                MessageBox.Show("blok içinden, i=" + i.ToString()); // Hata
            }
         //   MessageBox.Show("blok dışı, z=" + z.ToString);
         //   MessageBox.Show("blok dışı, i=" + i.ToString); // Hata verir
        }
    }
}
