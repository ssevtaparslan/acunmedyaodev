// See https://aka.ms/new-console-template 

using System;

public class Kullanici
{


    private string ad;
    private string soyad;
    private int yas;
    public string email;

    public Kullanici(string ad, string soyad, int yas, string email)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.yas = yas;
        this.email = email;
    }

    public void BilgileriGoster()
    {
        Console.WriteLine("Ad: " + ad);
        Console.WriteLine("Soyad: " + soyad);
        Console.WriteLine("Yaş: " + yas);
        Console.WriteLine("Email: " + email);
    }


    static void Main()
    {

        Kullanici kullanici = new Kullanici("sevtap", "arslan", 21, "sevtapp@gmail.com");
        kullanici.BilgileriGoster();

    }

}

//Private : Özel anlamına gelir. Private ile tanımlanan metot sadece o sınıf içerisinde kullanılabilir.
// E - devlet şifremiz private metoda örnektir.

//Public- Açık-Erişilebilir anlamına gelir.Tanımlanan metoda başka sınıflar da ulaşabilir. 
//Herkese açık olan sosyal medya hesapları.

//Protected- Korunan anlamına gelir.Miras verdiği sınıflar içerisinde kullanılabilecek metotlardır.
//Bir ailede, ebeveynlerin bazı bilgileri çocuklara miras bırakır. 

//İnternal- Aynı program içerisinden erişilebilir, fakat farklı bir program içerisinden erişilemez. 
//Müşteri verileri sadece şirket sahiplerinin ve çalışanlarının erişebileceği bilgilerdir.

//Nesne yönelimli programlamadaki önemi ise; veri gizliliğini sağlar. Kodun hatalı ve  yanlış kullanımını önler.
//Kodun sürdürülebilirliğini arttıran araçlardır.
