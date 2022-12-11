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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 40;int b = 66; int c = 24; int i = 1;

            while(a!=b || b != c || a != c)
            {
                if (a % i == 0)
                {
                    a= a / 2; ; b= b / 3; c = c / 4;
                }
                if (b % i == 1)
                {
                    a = a +2; ; b = b - 3; c = c + 4;
                }
                if (c % i == 1)
                {
                    a = a - 1; ; b = b + 1; c = c + 2;
                }
                listBox1.Items.Add(a.ToString() + "-" + b.ToString() + "-" + c.ToString());

               // MessageBox.Show(a.ToString()+"-"+b.ToString() +"-"+c.ToString());
                i++;

            }
            MessageBox.Show("i="+i.ToString());
        }
    }
}
