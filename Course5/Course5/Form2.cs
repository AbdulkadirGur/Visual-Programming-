using System;
using System.Collections;
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
            /*string[] cumle = TB1.Text.Split('.');            
            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                cumle[i]=cumle[i].Trim();                                
                if (cumle[i].StartsWith("A") && cumle[i].EndsWith("s"))
                {
                    sayac++;
                }                
            }
            MessageBox.Show(sayac.ToString());*/            
            /*string a =TB1.Text;
            string[] tmp1 =a.Split ('.');
            int count = 0;
            for (int i = 0; i < tmp1.Length-1; i++)
            {
                tmp1[i] = tmp1[i].Trim();

                if (tmp1[i][0] == 'A' && tmp1[i][tmp1[i].Length-1]=='s')
                {
                    count++;               
                }
                else                   
            }
            MessageBox.Show("Cumle saysi :" + count);*/

            

            /*ArrayList arlist = new ArrayList ();
            ArrayList arlist2 = new ArrayList();
            string a =TB1.Text;
            string[] tmp1 =a.Split ('.');
            int count = 0;
            for (int i = 0; i < tmp1.Length-1; i++)
            {
                tmp1[i] = tmp1[i].Trim();

                if (tmp1[i][0] == 'A' && tmp1[i][tmp1[i].Length-1]=='s')
                {
                    count++;
                    arlist.Add (tmp1[i]);
                }
                else
                    arlist2.Add (tmp1[i]);
            }
            MessageBox.Show("Cumle saysi :" + count);

            MessageBox.Show("Olanlar");
            for (int i = 0; i < arlist.Count; i++)
            {
                MessageBox.Show(arlist[i].ToString());

            }
            MessageBox.Show("Olmayanlar");
            for (int i = 0; i < arlist2.Count; i++)
            {
                MessageBox.Show(arlist2[i].ToString());

            }*/




        }
    }
}
