using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          int ana = Convert.ToInt32(textBox1.Text);
          string[] vade =comboBox1.Text.Split(' ');
          string[] faiz =comboBox2.Text.Split('%');
          int vade1 = Convert.ToInt32(vade[0]);
          int  faiz1 = Convert.ToInt32(faiz[1]);
          double sonuc = ana + ana * vade1 * faiz1 / 12;
            
                MessageBox.Show(sonuc.ToString());
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a=comboBox1.SelectedIndex;
            comboBox2.SelectedIndex = a;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = comboBox2.SelectedIndex;
            comboBox1.SelectedIndex = b;
        }
    }
}
