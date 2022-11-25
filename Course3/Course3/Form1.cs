using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bul_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uzunluk = textBox1.Text.Length;
            try
            {
                int bas = textBox3.Text.IndexOf(textBox1.Text);
                textBox3.Select(bas, uzunluk);
            }
            catch (Exception)
            {
                MessageBox.Show("Bulunamadi!!!");
              
            }
           
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.SelectedText = textBox2.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Herhangi bir alani secmediniz");
                throw;
            }
            
            
            
        }
    }
}
