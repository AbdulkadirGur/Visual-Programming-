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
            
            
            
                int s = textBox3.Text.IndexOf(textBox1.Text);
                if (s == -1) MessageBox.Show("Aranan oge bulunamadi");
                else
                {

                    textBox3.HideSelection = false;
                    int uzunluk = textBox1.Text.Length;
                    textBox3.Select(s, uzunluk);
                    
                    

                }
            
            
           
            

        }
        int i = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            i++;
            label2.Text = i.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s = textBox3.Text.IndexOf(textBox1.Text);
            textBox3.SelectedText = textBox1.Text;
            textBox3.Select(s, textBox1.Text.Length);
        }
    }
}
