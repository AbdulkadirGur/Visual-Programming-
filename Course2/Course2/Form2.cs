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
    public partial class Form2 : Form
    {
        Form1 god;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 x)
        {
            // called to form1
            InitializeComponent();
            this.god = x;
            x.button1.Text = "Form2'den yazildi";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Button in Form2 clicked ";
            god.button1.Text = "F2_Button";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose ();
            god.Dispose();
        }
    }
}
