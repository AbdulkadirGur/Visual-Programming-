namespace Course6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tarih = dateTimePicker1.Value;
            MessageBox.Show(tarih.ToShortDateString());
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Enabled= true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }
        bool bayrak = false;
        int sayac =0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            int BX = pictureBox1.Location.X;
            int BY = pictureBox1.Location.Y;
            if (bayrak == false)
            {
                pictureBox1.Location = new Point(BX + 100, BY);
            }
            else
            {
                pictureBox1.Location = new Point(BX - 100, BY);

            }
            int durkonum = this.Size.Width - pictureBox1.Size.Width;// 800
            if (durkonum == pictureBox1.Location.X)
            {
                bayrak = true;
                pictureBox1.Location = new Point(BX , BY +100);
                    timer3.Enabled = true; 
            }
            if (pictureBox1.Location.X == 0)
            {
                bayrak = false;
                sayac++;
            }
            //dur kontrolu 
            if (sayac != 0)
            {
                timer4.Enabled = false;
            }

            //pictureBox1.Location = new Point(BX +5, BY);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer4.Enabled= false;
        }
    }
}