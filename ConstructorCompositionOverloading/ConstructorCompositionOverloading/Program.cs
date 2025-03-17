// See https://aka.ms/new-console-template for more information

/*
public class Kapı
{
    public int KapıSayısı { get; set; }

    public Kapı(int kapıSayısı)
    {
        KapıSayısı = kapıSayısı;
    }
}

public class Pencere
{
    public int PencereSayısı { get; set; }

    public Pencere(int pencereSayısı)
    {
        PencereSayısı = pencereSayısı;
    }
}

public class Kasa
{
    public string KasaTipi { get; set; }

    public Kasa(string kasaTipi)
    {
        KasaTipi = kasaTipi;
    }
}

public class Marka
{
    public string MarkaAdı { get; set; }
    public string ModelAdı { get; set; }

    public Marka(string markaAdı, string modelAdı)
    {
        MarkaAdı = markaAdı;
        ModelAdı = modelAdı;
    }
}

public class Araba
{
 
    public Kapı Kapı { get; set; }
    public Pencere Pencere { get; set; }
    public Kasa Kasa { get; set; }
    public Marka Marka { get; set; }
    public double Fiyat { get; set; }

   
    public Araba(Marka marka, Kapı kapı, Pencere pencere, Kasa kasa, double fiyat)
    {
        Marka = marka;
        Kapı = kapı;
        Pencere = pencere;
        Kasa = kasa;
        Fiyat = fiyat;
    }

    public void ArabaBilgileriniYazdir()
    {
        Console.WriteLine($"Arabanın markası {Marka.MarkaAdı}, modeli {Marka.ModelAdı}, " +
            $"kapı sayısı {Kapı.KapıSayısı}, pencere sayısı {Pencere.PencereSayısı}, " +
            $"kasası {Kasa.KasaTipi}, fiyatı {Fiyat} TL’dir.");
    }
}

class Program1
{
    static void Main()
    {
        Marka bmwMarka = new Marka("BMW", "X5");
        Kapı bmwKapı = new Kapı(4);
        Pencere bmwPencere = new Pencere(4);
        Kasa bmwKasa = new Kasa("sedan");
        double bmwFiyat = 2000000;

        Araba bmwX5 = new Araba(bmwMarka, bmwKapı, bmwPencere, bmwKasa, bmwFiyat);

      
        bmwX5.ArabaBilgileriniYazdir();
    }
}
*/
/*
public class Matematik
{
    public int Topla (int x, int y)
    {
        return x + y;
    }
    public int Topla (int x, int y, int z)
    {
        return x + y + z;
    }
    public double Topla ( double x, double y)
    {
        return x + y;
    }
    public double Topla (double x, double y, double z)
    {
        return x + y + z;
    }
    public int Carp (int x, int y)
    {
        return x * y;
    }
    public int Carp (int x, int y, int z)
    {
        return x * y * z;
    }
    public double Carp (double x, double y, double z)
    {
        return x * y * z;
    }
}
class Program
{
    static void Main()
    {
        Matematik matematik = new Matematik();

        Console.WriteLine("Toplama (int, iki parametre): " + matematik.Topla(5, 10));
        Console.WriteLine("Toplama (int, üç parametre): " + matematik.Topla(5, 10, 15));

        Console.WriteLine("Toplama (double, iki parametre): " + matematik.Topla(5.5, 10.2));
        Console.WriteLine("Toplama (double, üç parametre): " + matematik.Topla(5.5, 10.2, 15.3));

        Console.WriteLine("Çarpma (int, iki parametre): " + matematik.Carp(5, 10));
        Console.WriteLine("Çarpma (int, üç parametre): " + matematik.Carp(5, 10, 2));

        Console.WriteLine("Çarpma (double, iki parametre): " + matematik.Carp(5.5, 10.2, 5.2));
        Console.WriteLine("Çarpma (double,): " + matematik.Carp(5.5, 10.2, 2.5));
    }
}
*/
//3.ÖDEV
// Garbage Collector program çalışması sırasında erişilemeyen veya artık mevcut olmayan
// öğeleri otomatik olarak tespit eder ve bunları bellekten temizler.

//Çöp toplayıcı, erişilemeyen nesneleri belirleyip bellekten temizleyerek,
//kullanılan alanları geri kazanır ve belleği optimize eder.

//Çöp toplayıcının bellek yönetimindeki rolü, öğelerin otomatik olarak temizlenerek bellek dağıtmalarını engelleme,
//bellek bölmesi verimli kullanımı ve geliştiricilerin manuel bellek yönetimi yapma seçimini ortadan kaldırmasıdır.


//4.ÖDEV 
//Genel yapıların ayrıntıları:
//İpucu Güvenliği : Derleme zamanında tür denetimi sağlar, böylece çalışma süresi hatalarını azaltır.
//Kod Yeniden Kullanılabilirliği : Farklı veri tipleriyle çalışabilen genel sınıflar ve metotlar oluşturulabilir.
//Performans İyileştirmesi : Boxing ve unboxing işlemlerinin ortadan kalkması, değer tipleriyle çalışırken daha hızlı performans sağlar.
//Esneklik : Farklı türlerle çalışmak için daha esnek bir yapı sunar.

//Genel sınıf ve metotlarla esnek programlama, farklı veri tipleriyle çalışabilen sınıflar ve metotlar oluşturmayı sağlar.
//Bu, aynı kodu farklı türlerdeki verilerle kullanma imkanı verir ve kodun yeniden kullanılabilirliğini arttırır.
//Örneğin, bir listeyi (List <T> ) ya da bir performans yöntemini (Sort <T> ) farklı veri tipleriyle kullanmak için genel yapılar kullanılır.
//Bu sayede hem tür güvenliği hem de kodun artırılması sağlanır.

//Boxing , bir değer tipinin (örneğin int, double) bir referans tipine (birbirine object) dönüştürülmesidir.
//Kutudan çıkarma ise, kutulanmış bir referans tipinin tekrar orijinal değer tipine dönüştürülmesidir.
//Boxing ve Unboxing , ekstra bellek dağıtımı ve tür denetimi gerektirir, bu da performansı olumsuz etkileyebilir .
//Sık yapılan kutulama ve kutudan çıkarma işlemleri, özellikle büyük veri setlerinde bellek ve işlemci üzerindeki yükü artırabilir . 
