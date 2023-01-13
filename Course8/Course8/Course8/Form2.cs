using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //DateTime y = DateTime.Now;
            
            //timer1.Interval = 10 * 24 * 60 * 60 * 1000;
            //timer1.Interval = 1000;
           
            DateTime x = Tarih.Value;

            Metin.Text = x.AddDays(i).ToString();
            
            listBox1.Items.Add( Metin.Text.ToString());


          //************sayac**********
             i = i + 10;
            label4.Text = i.ToString();

        }

        private void Basla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
                




        }

        private void Metin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Tarih_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*DateTime x = Tarih.Value;
            Metin.Text = x.ToString();*/
        }

        
    }
}
