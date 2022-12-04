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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            string[] cumle = TB1.Text.Split('.');
            
            int sayac = 0;

            for (int i = 0; i < cumle.Length; i++)
            {
                cumle[i]=cumle[i].Trim();
                
                if (cumle[i].StartsWith("A") && cumle[i].EndsWith("s"))
                {
                    sayac++;
                }
                
            }
            MessageBox.Show(sayac.ToString());
        }
    }
}
