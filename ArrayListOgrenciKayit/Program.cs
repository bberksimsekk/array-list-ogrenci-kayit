using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListOgrenciKayit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ogrenciler = new ArrayList();

            //Berk Şimşek

            string secenek = "e";

            while (secenek == "e")
            {
                Öğrenci ogr = new Öğrenci();
                Console.WriteLine("Lütfen öğrencinin adını giriniz");
                ogr.Isim = Console.ReadLine();

                Console.WriteLine("Lütfen öğrencinin soyadını giriniz");
                ogr.Soyisim = Console.ReadLine();

                Console.WriteLine("Lütfen öğrencinin numarasını giriniz");
                ogr.OkulNo = Convert.ToInt32(Console.ReadLine());

                ogrenciler.Add(ogr);
                Console.WriteLine("Öğrenci eklemeye devam edilsin mi ? Evet/Hayır");
                secenek = Console.ReadLine();
            }

            Console.WriteLine("*-*-*-*-*Öğrenciler*-*-*-*-*");
            for (int i = 0; i < ogrenciler.Count; i++)
            {
                Öğrenci veri = (Öğrenci)ogrenciler[i];
                Console.WriteLine(" No = " + veri.OkulNo + ") " + veri.Isim + " " + veri.Soyisim);
            }
        }
    }

    class Öğrenci
    {
        public int OkulNo { get; set; }

        public string Isim { get; set; }

        public string Soyisim { get; set; }
    }
}
