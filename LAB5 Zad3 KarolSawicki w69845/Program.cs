using System;
using System.Collections.Generic;

class Program
{
    enum Kolor
    {
        Czerwony,
        Niebieski,
        Zielony,
        Żółty,
        Fioletowy
    }

    static void Main(string[] args)
    {
        List<Kolor> kolory = new List<Kolor>
        {
            Kolor.Czerwony,
            Kolor.Niebieski,
            Kolor.Zielony,
            Kolor.Żółty,
            Kolor.Fioletowy
        };

        Random random = new Random();
        Kolor wylosowanyKolor = kolory[random.Next(kolory.Count)];

        Console.WriteLine("Gra w zgadywanie kolorów!");
        Console.WriteLine("Dostępne kolory: Czerwony, Niebieski, Zielony, Żółty, Fioletowy.");

        bool odgadniety = false;

        while (!odgadniety)
        {
            Console.Write("\nZgadnij kolor: ");
            string wpisanyKolor = Console.ReadLine();

            try
            {
                Kolor zgadywanyKolor = (Kolor)Enum.Parse(typeof(Kolor), wpisanyKolor, true);

                if (zgadywanyKolor == wylosowanyKolor)
                {
                    Console.WriteLine("Brawo! Zgadłeś prawidłowy kolor!");
                    odgadniety = true;
                }
                else
                {
                    Console.WriteLine("Nie zgadłeś. Spróbuj ponownie!");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Wpisałeś nieprawidłowy kolor! Użyj jednego z dostępnych: Czerwony, Niebieski, Zielony, Żółty, Fioletowy.");
            }
        }
    }
}
