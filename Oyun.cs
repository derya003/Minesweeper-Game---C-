using System;
using System.Windows.Forms;
using System.Drawing;

namespace OyunProje
{
    public class Oyun
    {
        private Form2 form2;
        private int toplamMayin;
        private int doğruİsaretlenmişMayin;
        private int oyunSuresi;
        private Skorboard skorboard;
        public Oyun(Form2 form2, int toplamMayin, Skorboard skorboard)
        {
            this.form2 = form2;
            this.toplamMayin = toplamMayin;
            this.doğruİsaretlenmişMayin = 0;
            this.oyunSuresi = 0;
            this.skorboard = skorboard;
        }

        public void MayinaBasildi()
        {
            // mayına basılırsa oyun bitiyor ve skor hesaplanacak
            OyunBitir();
            SkorHesapla();
        }

        public void BayrakKontrol(Button btn)
        {
            // bayrağın mayına yerleştirilip yerleştirilmediğini kontrol ediyoruz
            if (btn.Tag?.ToString() == "Mayin")
            {
                doğruİsaretlenmişMayin++;
            }
        }

        public void SureGuncelle(int saniye)
        {
            oyunSuresi = saniye;
        }



        private void OyunBitir()


        {
            form2.DurdurTimer(); // form2'de tanımlı DurdurTimer fonksiiyonunu çağır

            // tüm mayınları gösteriyoruz oyun bitince
            foreach (Control control in form2.TableLayoutPanel.Controls)
            {
                Button btn = control as Button;
                if (btn != null && btn.Tag?.ToString() == "Mayin")
                {
                    btn.BackColor = Color.Red;
                    btn.Text = "💣";
                }
                
            }

        }
        private void SkorHesapla() //skoru hesaplayıp skor tablsouna kaydediyoruz
        {
            int skor = 0;
            if (oyunSuresi > 0)
            {
                // skor = (doğru işaretlenen mayın / oyun süresi) * 1000
                skor = (doğruİsaretlenmişMayin * 1000) / oyunSuresi;
            }

            // skoru skor tablosuna kaydediyoruz
            skorboard.SkorKaydet(form2.KullaniciAdi, skor);

            MessageBox.Show($"Oyun bitti! Skorunuz: {skor}");

           //skorlar form3 te gösteriliyor 
            Form3 form3 = new Form3(skorboard);
            form3.Show();
            form2.Hide();
        }


    }
}
 