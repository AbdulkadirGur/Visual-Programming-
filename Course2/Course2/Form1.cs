using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course2
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Abdulkadir" && textBox2.Text=="123")
            {
                //Form2 form2 = new Form2(); 
                Form2 form2 = new Form2(this);
                //this.Visible = false;
                 form2.Show();
               //form2.ShowDialog(); // if you don't close this window you can't open other window
            }
            else
            {
                MessageBox.Show("Please enter the right password or username !!!");
            }
        }
    }
}
