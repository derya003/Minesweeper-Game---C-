using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OyunProje
{
    public class Skorboard
    {
        private string dosyaYolu = "skorlar.txt"; // skorların kaydedileceği dosya

        public void SkorKaydet(string kullaniciAdi, int skor)
        {
            // skorları dosyadan yükle
            var skorlar = SkorlarıYükle().ToList();

            // aynı kullanıcı adına sahip skoru kontrol et ve varsa güncelliyoruz

            var mevcutSkorIndex = skorlar.FindIndex(x => x.KullaniciAdi == kullaniciAdi);
            if (mevcutSkorIndex != -1)
            {
                // yeni skoru daha yüksekse güncelle 
                if (skorlar[mevcutSkorIndex].Skor < skor)
                {
                    skorlar[mevcutSkorIndex] = (kullaniciAdi, skor);
                }
            }
            else
            {
               // yeni kullanıcının adını ve skorunu ekle
                skorlar.Add((kullaniciAdi, skor));
            }

            // skorları sıralayıp en iyi 10 skoru yazdırıyoruz
            var enIyiSkorlar = skorlar.OrderByDescending(x => x.Skor).Take(10).ToList();

            // skorları dosyaya yazın
            File.WriteAllLines(dosyaYolu, enIyiSkorlar.Select(x => $"{x.KullaniciAdi},{x.Skor}"));
        }
        public IEnumerable<(string KullaniciAdi, int Skor)> SkorlarıYükle()
        {
            // dosyadan skoru yüklüyoruz
            if (!File.Exists(dosyaYolu))
            {
                return new List<(string, int)>();
            }
            // dosyadaki kodları satır satır okuyo
            var skorlar = File.ReadAllLines(dosyaYolu)
                           .Select(line =>
                           {
                               var parts = line.Split(',');
                               return (parts[0], int.Parse(parts[1]));
                           });



            return skorlar;
        }


    }
}
