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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void katsayi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dugme_Click(object sender, EventArgs e)
        {
            string[] arti = girdi.Text.Split('+');
            for (int i = 0; i < arti.Length-1; i++)
            {
               // MessageBox.Show(arti[i]);
            }
            int artiuzunluk = arti.Length;
            for (int i = 0; i < artiuzunluk -1; i++)
            {
                string[] xx = arti[i].Split('x');
                string[] yy = arti[i].Split('^');
                katsayi.Items.Add(xx[0]);
                us.Items.Add(yy[0]);
            }
            string[] t = arti[artiuzunluk - 1].Split('=') ;
           // MessageBox.Show(t[1]);
            string[] xy = t[0].Split('x');         
            string[] y2 = t[0].Split('^');
            katsayi.Items.Add(xy[0]);
            us.Items.Add(y2[0]);    
        }
    }
}
