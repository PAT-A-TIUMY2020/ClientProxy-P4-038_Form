using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_038_Form
{
    public partial class Form1 : Form
    {
        ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
        ServiceReference1.Koordinat a = new ServiceReference1.Koordinat();
        ServiceReference1.Koordinat b = new ServiceReference1.Koordinat();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a + b;
            textBox3.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox4.Text);
            b = Convert.ToInt32(textBox5.Text);
            c = a - b;
            textBox6.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox7.Text);
            b = Convert.ToInt32(textBox8.Text);
            c = a * b;
            textBox9.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox10.Text);
            b = Convert.ToInt32(textBox11.Text);
            c = a / b;
            textBox12.Text = c.ToString();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                a.X = Int32.Parse(textBox13.Text);
                a.Y = Int32.Parse(textBox15.Text);
                b.X = Int32.Parse(textBox14.Text);
                b.Y = Int32.Parse(textBox16.Text);

                double XKoordinat = a.X - b.X;
                double YKoordinat = a.Y - b.Y;
                double HasilKoordinat = Math.Sqrt(Math.Pow(XKoordinat, 2) +
                Math.Pow(YKoordinat, 2));

                textBox17.Text = HasilKoordinat.ToString();

            }
            catch { }
        }
    }
}
