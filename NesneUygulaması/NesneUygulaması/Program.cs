// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public double YakıtTüketimi { get; set; }
    public double ToplamMesafe { get; set; }

    public Araba(string marka, string model, double YakıtTüketimi, double ToplamMesafe)
    {
        Marka = marka;
        Model = model;
        this.YakıtTüketimi = YakıtTüketimi;
        this.ToplamMesafe = ToplamMesafe;
    }

    public double CalculateTotalFuelUsed()
    {
        return (ToplamMesafe / 100) * YakıtTüketimi;
    }
}

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>
        {
            new Araba("Toyota", "Corolla", 6.5, 500),
            new Araba("Honda", "Civic", 7.2, 650),
            new Araba("Ford", "Focus", 8.0, 700),
            new Araba("BMW", "X5", 9.0, 5000)
        };

        foreach (var car in arabalar)
        {
            Console.WriteLine($"Marka: {car.Marka}, Model: {car.Model}, 100 km'de Yaktığı Yakıt: {car.YakıtTüketimi} litre, Toplam Yakıt Tüketimi: {car.CalculateTotalFuelUsed():F2} litre");
        }
    }
}

//araştırma ödevi
//Görsel Programlama(Visual Programming), yazılım geliştirme sürecini grafiksel bileşenler, semboller ve sürükle-bırak arayüzleri ile gerçekleştiren bir programlama yöntemidir.
// Geleneksel metin tabanlı kodlama yerine, bloklar, düğümler veya simgeler kullanılarak program akışı oluşturulur.
// Bu sayede kullanıcılar sözdizimi kurallarına bağlı kalmadan mantıksal akışı görsel olarak tasarlayabilirler.

//metin tabanlı prgoramlamadan farkı
//Grafiksel bloklar, düğümler ve simgeler kullanılır
//Kolay öğrenilir, sürükle-bırak ile kod yazılır
//Daha yavaş olabilir, fazladan görsel işleme gerektirir
//Görsel programlama, yeni başlayanlar için kolay ve hızlı bir yöntemdir, ancak büyük ve karmaşık projeler için sınırlıdır.
//Metin tabanlı programlama, daha fazla esneklik ve performans sunar, ancak öğrenmesi daha zordur ve sözdizimi hatalarına açıktır.
