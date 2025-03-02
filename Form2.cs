namespace OyunProje
{


    public partial class Form2 : Form

    {

        private Oyun oyun;
        private int hamleSayisi = 0;
        private int alanBoyutu;
        private int mayinSayisi;
        private string kullaniciAdi;
        private Skorboard skorboard;
        private Random random = new Random();
        int a = 0;   //zaman 

        public Form2(int alanBoyutu, int mayinSayisi, string kullaniciAdi, Skorboard skorboard)
        {
            InitializeComponent();

            oyun = new Oyun(this, mayinSayisi, skorboard);
            this.alanBoyutu = alanBoyutu;
            this.mayinSayisi = mayinSayisi;
            this.kullaniciAdi = kullaniciAdi;
            this.skorboard = skorboard;


            // TableLayoutPanel oyun alanı için 
            TableLayoutPanel.ColumnCount = alanBoyutu;
            TableLayoutPanel.RowCount = alanBoyutu;
            TableLayoutPanel.ColumnStyles.Clear();
            TableLayoutPanel.RowStyles.Clear();


            //alan -grid 
            for (int i = 0; i < alanBoyutu; i++)
            {
                TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / alanBoyutu));
                TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / alanBoyutu));
            }

            // grid deki kutular için buton
            for (int satir = 0; satir < alanBoyutu; satir++)
            {
                for (int sutun = 0; sutun < alanBoyutu; sutun++)
                {
                    Button btn = new Button
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(0),
                        Name = $"Button_{satir}_{sutun}"
                    };
                    btn.Click += Buton_Click;         
                    btn.MouseUp += Buton_MouseUp;    
                    TableLayoutPanel.Controls.Add(btn, sutun, satir);
                }
            }

            // mayınları yerleştiricez
            MayinYerleştir();

        }
        public string KullaniciAdi => kullaniciAdi;

        private void MayinYerleştir() //mayınları rastgele yerleştiriyoruz
        {
            int yerleştirilenMayin = 0;

            while (yerleştirilenMayin < mayinSayisi)
            {
                int satir = random.Next(alanBoyutu);
                int sutun = random.Next(alanBoyutu);

               //hücreye bakıyouz boş mu boşsa mayın ekliyoruz
                Button btn = (Button)TableLayoutPanel.GetControlFromPosition(sutun, satir);
                if (btn != null && btn.Tag?.ToString() == null)
                {
                    btn.Tag = "Mayin";
                    yerleştirilenMayin++;
                }
            }
        }
            
        //sol tıklama ile kutuları açma işlemi
        private void Buton_Click(object? sender, EventArgs e)
        {
            if (sender is Button tıklananButon)  
            {
                if (tıklananButon.BackColor != Color.Green) // bayrak koyulmuşsa kutuyu açmıcaz
                {
                    hamleSayisi++; 
                    LabelHamle.Text = $" {hamleSayisi}";
                   
                    if (tıklananButon.Tag?.ToString() == "Mayin")
                    {
                        oyun.MayinaBasildi(); 
                    }
                    else
                    {
                        TemizleVeGoster(tıklananButon);
                    }
                }
            }
        }


        private void TemizleVeGoster(Button btn) //kutuyu açan fonskiyon
        {
            btn.BackColor = Color.Gray; 
            btn.Enabled = false; 


            //çevredeki mayın sayısını  hesaplıyoruz
            int çevresindekiMayinSayisi = ÇevresindekiMayinSayısınıHesapla(btn);
          
            if (çevresindekiMayinSayisi > 0)
            {
                btn.Text = çevresindekiMayinSayisi.ToString();
                btn.ForeColor = Color.Black; 
                btn.Font = new Font(btn.Font, FontStyle.Bold); 
            }
            else
            {
                // eğer çevrede mayın yoksa, komşu hücreleri aç
                KomşuHücreleriAç(btn);
            }
        }

        private void KomşuHücreleriAç(Button btn)
        {
            TableLayoutPanelCellPosition pos = TableLayoutPanel.GetPositionFromControl(btn);

            for (int i = pos.Row - 1; i <= pos.Row + 1; i++)
            {
                for (int j = pos.Column - 1; j <= pos.Column + 1; j++)
                {
                    // sınırları kontrol ediyoruz
                    if (i >= 0 && i < alanBoyutu && j >= 0 && j < alanBoyutu)
                    {
                        Button komşuButon = (Button)TableLayoutPanel.GetControlFromPosition(j, i);

                        if (komşuButon != null && komşuButon.Enabled && komşuButon.BackColor != Color.Gray)
                        {
                            int komsuMayinSayisi = ÇevresindekiMayinSayısınıHesapla(komşuButon);

                            TemizleVeGoster(komşuButon);
                        }
                    }
                }
            }
        }

        //bayrak koyma
        private void Buton_MouseUp(object? sender, MouseEventArgs e)
        {
            if (sender is Button tıklananButon)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (tıklananButon != null)
                    {
                        if (tıklananButon.BackColor == Color.Green)
                        {
                            tıklananButon.BackColor = SystemColors.Control;
                            tıklananButon.Text = ""; 
                        }
                        else //bayrak yoksa bayrak koyma işlemi
                        {
                            tıklananButon.BackColor = Color.Green;
                            tıklananButon.Text = "🚩";
                            oyun.BayrakKontrol(tıklananButon); 
                        }
                    }
                }
            }
        }
        // çevredeki mayın sayısını hesaplayan fonksiyon
        private int ÇevresindekiMayinSayısınıHesapla(Button btn)
        {
            int mayinSayisi = 0;
            TableLayoutPanelCellPosition pos = TableLayoutPanel.GetPositionFromControl(btn);

            for (int i = pos.Row - 1; i <= pos.Row + 1; i++)
            {
                for (int j = pos.Column - 1; j <= pos.Column + 1; j++)
                {
                    //kutunun dışındakihücreleri kontol ediyoruz
                    if (i >= 0 && i < alanBoyutu && j >= 0 && j < alanBoyutu && !(i == pos.Row && j == pos.Column))
                    {
                        Button komşuButon = (Button)TableLayoutPanel.GetControlFromPosition(j, i);

                        // komşu hücrede mayın olup olmadığını kontrol ediyouz
                        if (komşuButon != null && komşuButon.Tag?.ToString() == "Mayin")
                        {
                            mayinSayisi++;
                        }
                    }
                }
            }
            return mayinSayisi;
        }

        private void MayinBasildi(Button btn)
        {
            btn.BackColor = Color.Red; 
            btn.Text = "💣"; 
            btn.Enabled = false; 

            skorboard.SkorKaydet(kullaniciAdi, hamleSayisi);//skoru kaydediyor
            Form3 form3 = new Form3(skorboard);
            form3.Show();
        }
        public void DurdurTimer()
        {
            timer1.Stop();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            a++;
            timerLabel.Text = a.ToString();
            oyun.SureGuncelle(a); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 yeni = new Form3(skorboard);
            yeni.Show();
            // this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
