namespace Course8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            Ana.ShowDialog(); // Dosya secme panelijni acar
            label4.Text = Ana.FileName; // labele dosyaynin uzanti adresini yazar
            try
            {
                Resim.Image = Image.FromFile(Ana.FileName);// PicturBoxa resim atar
            }
            catch 
            {

               MessageBox.Show("Dosya Secilemedi");
            }
            string[] x = Ana.FileName.Split('\\');
            for (int i = 0; i < x.Length; i++)
            {
                
                if (x[i].IndexOf("D") == 0 && x[i].IndexOf("s") == x[i].Length-1)
                {
                    Liste.Items.Add(x[i]);
                }
                /*if (x[i].StartsWith("D") && x[i].EndsWith("s"))
                {
                    Liste.Items.Add(x[i]);

                }*/
                    
            }           
            /*
            string dosya = x[x.Length-1];
            string[] y= dosya.Split(".");
            MessageBox.Show(y[0].ToString());
            MessageBox.Show(y[y.Length-1].ToString());*/

        }

        private void Ana_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}