// See https://aka.ms/new-console-template for more information


using System;

class TahminOyunu
{
    static void Main()
    {
        Random random = new Random();
        int number = random.Next(1, 101); 
        int attempts = 0;
        int tahmin= 0;

        Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Hadi tahmin et!");

        while (tahmin != number)
        {
            try
            {
                Console.Write("Tahmininiz: ");
                tahmin = int.Parse(Console.ReadLine());
                attempts++;

                if (tahmin < number)
                {
                    Console.WriteLine("Daha büyük bir sayı girin.");
                }
                else if (tahmin > number)
                {
                    Console.WriteLine("Daha küçük bir sayı girin.");
                }
                else
                {
                    Console.WriteLine($"Tebrikler! {attempts} denemede doğru tahmini yaptınız.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin.");
            }
        }
    }
}

