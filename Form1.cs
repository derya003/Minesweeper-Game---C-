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

            // kullanýcý adý için kontrol
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || kullaniciAdi.Any(char.IsDigit))
            {
                SonucLabel.Text = "Geçerli bir kullanýcý adý giriniz (sadece harfler).";
                return;
            }

            // alan boyutu ve mayýn sayýsýnýn sayý olup olmadýðýný kontrol ediyoruz
            if (!int.TryParse(AlantextBox.Text, out alanBoyutu) || !int.TryParse(MayintextBox.Text, out mayinSayisi))
            {
                SonucLabel.Text = "Alan boyutu ve mayýn sayýsý sadece sayý olmalýdýr.";
                return;
            }

            // alan boyutu ve mayýn sayýsý deðerlerinin istenilen aralýkta olduðunu kontrol ediyoruz 
            if (mayinSayisi >= 10 && alanBoyutu <= 30)
            {
                Form2 yeni = new Form2(alanBoyutu, mayinSayisi, kullaniciAdi,skorboard);
                yeni.Show();
                this.Hide();
            }
            else
            {
                SonucLabel.Text = "Tekrar deneyiniz. Alan boyutu 30'dan küçük ve mayýn sayýsý 10'dan büyük olmalýdýr.";
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
