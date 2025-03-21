// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Basit Hesap Makinesi");
        Console.WriteLine("İşlemler: +, -, *, /");

        try
        {
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İşlem seçin (+, -, *, /): ");
            char islem = Convert.ToChar(Console.ReadLine());

            switch (islem)
            {
                case '+':
                    Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sayi1 + sayi2}");
                    break;
                case '-':
                    Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sayi1 - sayi2}");
                    break;
                case '*':
                    Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sayi1 * sayi2}");
                    break;
                case '/':
                    if (sayi2 != 0)
                        Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {(double)sayi1 / sayi2}");
                    else
                        Console.WriteLine("Hata: Sıfıra bölme yapılamaz!");
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem girdiniz!");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Lütfen geçerli bir tam sayı girin!");
        }
    }
}
