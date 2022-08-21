using System;
using System.Collections.Generic;

namespace generic_list{

    class Program{

        static void Main(string[] args){

            //List<T> class
            //System.Collection.Generic
            //T-> object türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yesil");

            //count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("yesil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinden çıkarıldı");             
            }
            //eleman ile indexe erişim
            Console.WriteLine(renkListesi.BinarySearch("sarı"));

            //Diziyi liste cevirme
            string[] hayvanlar = {"kedi","köpek","kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı = new Kullanıcılar();
            kullanıcı.Isim = "ayşe";
            kullanıcı.Soyisim = "Yılaz";
            kullanıcı.Yas = 26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "özcan";
            kullanıcı2.Soyisim = "çalışkan";
            kullanıcı2.Yas = 26;


            kullanıcıListesi.Add(kullanıcı);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

            yeniListe.Add(new Kullanıcılar(){
                Isim = "deniz",
                Soyisim = "arda",
                Yas = 24
                
            });

            foreach (var kullanıcıı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
                Console.WriteLine("kullanıcı Yaş:" + kullanıcı.Yas);
            }

            





        }
    }
}

public class Kullanıcılar{

    private string isim;
    private string soyisim;
    private int yas ;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}