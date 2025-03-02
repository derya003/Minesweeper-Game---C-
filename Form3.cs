using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace OyunProje
{
    public partial class Form3 : Form
    {
        private Skorboard skorboard;
        public Form3(Skorboard skorboard)
        {
            InitializeComponent();
            ListeleSkorlar(skorboard);
            this.skorboard = skorboard;
      
        }

        private void ListeleSkorlar(Skorboard skorboard) //listview e skorları ekliyoruz
        {
            var enIyiSkorlar = skorboard.SkorlarıYükle();

             // listview e skorlara göre satır ekliyoruz
            foreach (var (KullaniciAdi, Skor) in enIyiSkorlar)
            {
                ListViewItem item = new ListViewItem(KullaniciAdi);
                item.SubItems.Add(Skor.ToString());
                listView1.Items.Add(item);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                //yeniden ounaya bastığımızda form1 ekranı açılacak yeni oyuna başlıcaz.
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }
    }
}
