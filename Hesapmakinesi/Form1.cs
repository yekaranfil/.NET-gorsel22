namespace Hesapmakinesi
{
    public partial class Form1 : Form

    {

        float s1, s2, sonuc;
        String btnmetin = "";

       int islem=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {  }
        private void Rakambas(object sender, EventArgs e)

        {
                      
            Button butonrakam  = (Button)sender;
            textBox1.Text += butonrakam.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            s2 = float.Parse(textBox1.Text);
            if (islem == 1)
            {
                sonuc = s1 + s2;
                textBox1.Text = sonuc.ToString();
            }
            else if (islem == 2)
            {
                sonuc = s1 - s2;
                textBox1.Text = sonuc.ToString();
            }
            else if (islem == 3)
            {
               sonuc= s1 * s2;
                textBox1.Text = sonuc.ToString();

            }
            else if (islem == 4)
            {
                sonuc = s1 / s2;
                textBox1.Text = sonuc.ToString();

            }
            else if(islem == 5)
            {
                sonuc = s1 % s2;
                textBox1.Text = sonuc.ToString();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            s1 = float.Parse(textBox1.Text);
            s2 = float.Parse(textBox1.Text);
            islem = 5;
            textBox1.Clear();

        }

        private void islembass(object sender, MouseEventArgs e)
        {
            Button butonislem = (Button)sender;
            String secim = butonislem.Text;

            if (secim == "+"){
                s1 = float.Parse(textBox1.Text); islem = 1; textBox1.Clear(); 
            }
            else if (secim =="-")
            {
                s1 = float.Parse(textBox1.Text); islem = 2; textBox1.Clear();
            }
            else if (secim == "X")
            {
                s1 = float.Parse(textBox1.Text); islem = 3; textBox1.Clear();
            }
            else if (secim == "÷")
            {
                s1 = float.Parse(textBox1.Text); islem = 4; textBox1.Clear();
            }
          

            btnmetin = secim;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) < 0)
            {
                s1 = float.Parse(textBox1.Text);
                s2 = float.Parse(textBox1.Text);
                float tersislem = -s1 - -s2;
                sonuc = tersislem + -s1;
                
                textBox1.Text = sonuc.ToString();
                

            }
            else if (int.Parse(textBox1.Text) > 0)
            {
                s1 = float.Parse(textBox1.Text);
                sonuc = s1-s1*2;
                textBox1.Text = sonuc.ToString();
            }
        }

   
        private void button17_Click(object sender, EventArgs e)
        {
            s1 = s2 = 0;
            islem = 0;
            textBox1.Clear();

        }
        


    }
}