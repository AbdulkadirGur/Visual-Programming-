using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String [] edizisi =textBox1.Text.Split('e');
            int sayac = 0;
            for (int i = 0; i < edizisi.Length-2 i++)
            {
                sayac++;
            }
            MessageBox.Show(sayac.ToString());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
