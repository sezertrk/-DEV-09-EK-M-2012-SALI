using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {               
            int hm = int.Parse(textBox1.Text);
            int ha = int.Parse(textBox2.Text);
            if (hm < 0)
            {
                MessageBox.Show("Adam Akıllı Sayı Gir Adamı Hasta Etme"); 
            }

            int hson = 0;
            hson = hm * ha;
            textBox3.Text = hson.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hson = int.Parse(textBox3.Text);
            int sf = int.Parse(textBox4.Text);
            int tut = 0;
            tut = hson * sf;
            textBox5.Text = tut.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int hson = int.Parse(textBox3.Text);
            int sf = int.Parse(textBox4.Text);
            int tut = 0;
            tut = hson * sf;
            if (tut > 7500)
            {
                MessageBox.Show("Kar " + tut.ToString());
            }
            else
            {
                MessageBox.Show("Zarar " + tut.ToString());
            }
        }
    }
}
