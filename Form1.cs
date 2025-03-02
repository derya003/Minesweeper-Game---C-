namespace OyunProje
{
    public partial class Form1 : Form
    {

        private Skorboard skorboard;
        public Form1()
        {
            InitializeComponent();
            skorboard = new Skorboard();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            string kullaniciAdi = IsimtextBox.Text;
            int alanBoyutu;
            int mayinSayisi;

            // kullan�c� ad� i�in kontrol
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || kullaniciAdi.Any(char.IsDigit))
            {
                SonucLabel.Text = "Ge�erli bir kullan�c� ad� giriniz (sadece harfler).";
                return;
            }

            // alan boyutu ve may�n say�s�n�n say� olup olmad���n� kontrol ediyoruz
            if (!int.TryParse(AlantextBox.Text, out alanBoyutu) || !int.TryParse(MayintextBox.Text, out mayinSayisi))
            {
                SonucLabel.Text = "Alan boyutu ve may�n say�s� sadece say� olmal�d�r.";
                return;
            }

            // alan boyutu ve may�n say�s� de�erlerinin istenilen aral�kta oldu�unu kontrol ediyoruz 
            if (mayinSayisi >= 10 && alanBoyutu <= 30)
            {
                Form2 yeni = new Form2(alanBoyutu, mayinSayisi, kullaniciAdi,skorboard);
                yeni.Show();
                this.Hide();
            }
            else
            {
                SonucLabel.Text = "Tekrar deneyiniz. Alan boyutu 30'dan k���k ve may�n say�s� 10'dan b�y�k olmal�d�r.";
            }
        }


        private void AlantextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
