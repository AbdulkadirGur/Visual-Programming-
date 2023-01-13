using System.Numerics;

namespace Course7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hesapla_Click(object sender, EventArgs e)
        {

            string vadeler = Vade.Text;//10 Aylik - 12 Aylik            
            //***************Vade************************ 
            string[] v1 = vadeler.Split('-');// v1[0]=10 Aylik;   v1[1]= 12 Aylik;
            string[] v2 = v1[0].Split(" "); //  v2[0]=10;         v2[1]=Aylik;
            string[] v3 = v1[1].Split(" "); //  v3[0]=" ";        v3[1]=12;        v3[2]=Aylik;     
            int  sayi1=  Convert.ToInt32(v2[0]);
            int sayi2 = Convert.ToInt32(v3[1]);
            int Vade1=(sayi1+sayi2)/2;

            //***************Faiz************************ 
            string faizler = Faiz.Text;//10% - 13%

            string[] f1 = faizler.Split('-');// f1[0]=10% ;   f1[1]= 13%;
            string[] f2 = f1[0].Split("%"); //  f2[0]=10;         f2[1]= ; 
            string[] f3 = f1[1].Split("%"); //  f3[0]= 13;        f3[1]= ;       
            f3[0].Trim();
            int sayi3 = Convert.ToInt32(f2[0]);
            int sayi4 = Convert.ToInt32(f3[0]);
            int Faiz1 = (sayi3 + sayi4) / 2;
            int Ana1 =Convert.ToInt32(Ana.Text);
            float sonuc = Ana1 + Ana1 * Vade1 * Faiz1 / 12;

            MessageBox.Show(sonuc.ToString());


        }

        private void Vade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faiz.SelectedIndex = Vade.SelectedIndex;
            /*
            int secilen = Vade.SelectedIndex;
            if (secilen >= 0)
            {
                Faiz.SelectedIndex = secilen;
            }*/



        }

        private void Faiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vade.SelectedIndex = Faiz.SelectedIndex;    
        }
    }
}