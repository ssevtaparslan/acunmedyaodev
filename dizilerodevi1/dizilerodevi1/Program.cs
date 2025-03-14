// See https://aka.ms/new-console-template for more information


using System ;

/* 
* class YasKategorisi
{
   static void Main()
   {
       Console.Write("Yaşınızı girin: ");
       int yas = Convert.ToInt32(Console.ReadLine());
       string sonuc = YasKategorisiBelirle(yas);
       Console.WriteLine("Kategori: " + sonuc);
   }
   static string YasKategorisiBelirle (int yas)
   {
       if (yas < 0 || yas > 99)
       {
           return "Ya hiç doğmadınız ya da çoktan öldünüz...";
       }
       else if (yas < 18)
       {
           return "Küçüksünüz";
       }
       else if (yas < 35)
       {
           return "Gençsiniz";
       }
       else if (yas < 55)
       {
           return "Yetişkinsiniz";
       }
       else if (yas < 75)
       {
           return "Yaşlısınız";
       }
       else
       {
           return "Çok yaşlısınız";
       }
   }
}

*/

//ikinciödev//


using System;
/*

class ArabaDurumu
{
    static void Main()
    {
        Console.Write("Arabanızın yaşını girin: ");
        int yas = Convert.ToInt32(Console.ReadLine());

        string durum = ArabaDurumuBelirle(yas);
        Console.WriteLine(durum);
    }

    static string ArabaDurumuBelirle(int yas)
    {
        if (yas >= 0 && yas <= 10)
        {
            return "Arabanız yeni";
        }
        else if (yas > 10 && yas <= 20)
        {
            return "Servise götürmeniz gerekebilir";
        }
        else if (yas > 20 && yas <= 30)
        {
            return "Arabanız hurdaya çıkabilir";
        }
        else
        {
            return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        }
    }
}

*/

//ücüncüödev

/*
using System;

class WhileDongu
{
    private int sayac = 0;

    public void MerhabaAcunmedya()
    {
        while (sayac < 5)
        {
            Console.WriteLine("Merhaba Acunmedya");
            sayac++;
        }
    }

    static void Main()
    {
        WhileDongu y = new WhileDongu();
        y.MerhabaAcunmedya();
    }
}

*/

/*
 using System;

class DonguOrnegi
{
    public void MerhabaAcunmedya()
    {
        int sayac = 0;
        do
        {
            Console.WriteLine("Merhaba Acunmedya");
            sayac++;
        }
        while (sayac < 0);
    }

    static void Main()
    {
        DonguOrnegi ornek = new DonguOrnegi();
        ornek.MerhabaAcunmedya();
    }
}
*/

//dorduncuodev

/*
    using System;
using System.Collections.Generic;

class Calisan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Meslek { get; set; }
    public string Departman { get; set; }
    public double Maas { get; set; }

    public Calisan(string ad, string soyad, string meslek, string departman, double maas)
    {
        Ad = ad;
        Soyad = soyad;
        Meslek = meslek;
        Departman = departman;
        Maas = maas;
    }

    public void BilgiYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Meslek: {Meslek}, Departman: {Departman}, Maaş: {Maas} TL");
    }
}

class Program
{
    static void Main()
    {
        List<Calisan> calisanlar = new List<Calisan>();

        calisanlar.Add(new Calisan("sevtap", "arslan", "Genel Müdür", "Yönetim", 30000));
        calisanlar.Add(new Calisan("simge", "cezik", "Müdür", "İnsan Kaynakları", 15000));
        calisanlar.Add(new Calisan("sıla", "ciran", "Programcı", "Yazılım", 12000));
        calisanlar.Add(new Calisan("şebnem", "önalan", "Stajyer", "Yazılım", 3000));

        double toplamMaas = 0;

        Console.WriteLine("Çalışan Bilgileri:");
        Console.WriteLine("---");
        foreach (var calisan in calisanlar)
        {
            calisan.BilgiYazdir();
            toplamMaas += calisan.Maas;
        }

        Console.WriteLine("\nToplam Maaş: " + toplamMaas + " TL");
    }
}
*/

//besinciodev

 /*
   using System;

class Araba
{
    public string Marka;
    public string Model;
    public double KmBasinaTuketim;
    public double YapilanKm;

    public Araba(string marka, string model, double tuketim, double km)
    {
        Marka = marka;
        Model = model;
        KmBasinaTuketim = tuketim;
        YapilanKm = km;
    }

    public double BenzinTuketimi()
    {
        return KmBasinaTuketim * YapilanKm;
    }

    public void BilgiYazdir()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, Tüketim: {BenzinTuketimi():0.00} L");
    }
}

class Program
{
    static void Main()
    {
        Araba araba1 = new Araba("Toyota", "Corolla", 0.06, 600);
        Araba araba2 = new Araba("Honda", "Civic", 0.07, 500);
        Araba araba3 = new Araba("Ford", "Focus", 0.08, 450);

        double toplamTuketim = araba1.BenzinTuketimi() + araba2.BenzinTuketimi() + araba3.BenzinTuketimi();

        Console.WriteLine("Araba Bilgileri ve Benzin Tüketimi:");
        araba1.BilgiYazdir();
        araba2.BilgiYazdir();
        araba3.BilgiYazdir();
        Console.WriteLine($"\nToplam Benzin Tüketimi: {toplamTuketim:0.00} L");
    }
}

*/