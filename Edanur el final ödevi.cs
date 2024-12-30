using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace eda_ödev
{
    internal class Program
    {
        public class otobusler
        {
            public int Id { get; set; }
            public string Guzergah { get; set; }
            public int Kapasite { get; set; }
            public decimal YetiskinFiyat { get; set; }
            public decimal CocukFiyat { get; set; }
        }

        static void Main(string[] args)
        {
            int yetiskin_bilet = 0;
            int cocuk_bilet = 0;
            int toplam_bilet = 0;
            List<otobusler> seferler = new List<otobusler>
            {
                new otobusler {Id=1, Guzergah = "eskişehir-ankara arası", Kapasite = 25, YetiskinFiyat = 500, CocukFiyat = 350 },
                new otobusler {Id=2, Guzergah = "eskişehir-istanbul arası", Kapasite = 25, YetiskinFiyat = 500, CocukFiyat = 350 },
                new otobusler {Id=3, Guzergah = "ankara-istanbul arası", Kapasite = 25, YetiskinFiyat = 500, CocukFiyat = 350 }
            };

            foreach (otobusler product in seferler)
            {
                Console.WriteLine($"Sefer numarası :{product.Id}, Sefer güzergahı :{product.Guzergah}, Otobüs kapasitesi :{product.Kapasite}, Yetişkin bilet fiyatı :{product.YetiskinFiyat}, Çocuk bilet fiyatı :{product.CocukFiyat}");
            }

            Console.WriteLine("Terminale hoşgeldiniz...");
            Console.WriteLine("Gitmek istediğiniz seferin numarasını giriniz.");
            int id = Convert.ToInt32(Console.ReadLine());

            var seciliSefer = seferler.FirstOrDefault(o => o.Id == id);
            if (seciliSefer == null)
            {
                Console.WriteLine("Geçersiz sefer numarası!");
                return;
            }

            Console.WriteLine("Kaç yetişkin bileti almak istiyorsunuz?");
            yetiskin_bilet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kaç çocuk bileti almak istiyorsunuz?");
            cocuk_bilet = Convert.ToInt32(Console.ReadLine());

            int toplamYolcu = yetiskin_bilet + cocuk_bilet;

            if (seciliSefer.Kapasite >= toplamYolcu)
            {
                toplam_bilet = (yetiskin_bilet * (int)seciliSefer.YetiskinFiyat) + (cocuk_bilet * (int)seciliSefer.CocukFiyat);
                seciliSefer.Kapasite -= toplamYolcu;

                Console.WriteLine($"Toplam bilet ücreti: {toplam_bilet} TL");
                Console.WriteLine($"Kalan kapasite: {seciliSefer.Kapasite}");
            }
            else
            {
                Console.WriteLine("Yeterli kapasite yok!");
            }
        }
    }
}