// See https://aka.ms/new-console-template for more information


// Namespace, ad çakışmalarını engeller ve kodun okunabilirliğini artırır.
//Büyük projelerde kodu daha düzenli bir şekilde organize etmenizi sağlar.
//Aynı türdeki sınıfları benzer namespace'lere gruplamak, projenin yapısını daha anlaşılır kılar.
// Kodun daha modüler olması, bakım ve güncelleme işlemlerini daha kolay hale getirir.
// Aynı isme sahip sınıflar, farklı namespace'lerde tanımlanabilir, bu da aynı proje içinde benzer adların kullanılmasına imkan verir.

//Genişletilebilirlik, yazılımın mevcut yapısını bozmadan yeni özelliklerin veya işlevlerin eklenebilmesi yeteneğidir.
//Genişletilebilir bir yazılım, değişen şartlar veya yeni talepler doğrultusunda kolayca geliştirilip, özelleştirilebilir.
//Modüler yapı sayesinde, yeni özellikler eklemek, mevcut fonksiyonları değiştirmek veya kaldırmak daha kolaydır.
//Soyutlama, karmaşık detaylardan ziyade sadece önemli olan işlevleri sunarak kodu daha esnek hale getirir.

using MatematikselIslemler;
using System;

namespace MatematikselIslemler
{
    public class Hesaplama
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesaplama hesaplama = new Hesaplama();

            int toplaSonuc = hesaplama.Topla(5, 7);
            int carpmaSonuc = hesaplama.Carp(5, 7);

            Console.WriteLine($"Toplama Sonucu: {toplaSonuc}");  
            Console.WriteLine($"Çarpma Sonucu: {carpmaSonuc}");  
        }
    }
}
