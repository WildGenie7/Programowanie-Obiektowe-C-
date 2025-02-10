using System;
using System.Collections.Generic;

class Program
{
    enum StatusZamowienia
    {
        Oczekujące,
        Przyjęte,
        Zrealizowane,
        Anulowane
    }

    static void Main(string[] args)
    {
        Dictionary<int, List<string>> zamowienia = new Dictionary<int, List<string>>();
        Dictionary<int, StatusZamowienia> statusy = new Dictionary<int, StatusZamowienia>();

        zamowienia[1] = new List<string> { "Książka", "Jogurt" };
        statusy[1] = StatusZamowienia.Oczekujące;

        zamowienia[2] = new List<string> { "Jabłko", "Maska" };
        statusy[2] = StatusZamowienia.Oczekujące;

        Console.WriteLine("Lista zamówień:");
        foreach (var numer in zamowienia.Keys)
        {
            Console.WriteLine($"Numer zamówienia: {numer}");
            Console.WriteLine("Produkty: " + string.Join(", ", zamowienia[numer]));
            Console.WriteLine($"Status: {statusy[numer]}");
            Console.WriteLine("--------------------");
        }

        Console.WriteLine("\nZmiana statusu zamówienia numer 1 na Przyjęte.");
        statusy[1] = StatusZamowienia.Przyjęte;

        Console.WriteLine("Zmiana statusu zamówienia numer 2 na Zrealizowane.");
        statusy[2] = StatusZamowienia.Zrealizowane;

        Console.WriteLine("\nLista zamówień po zmianie statusów:\n");
        foreach (var numer in zamowienia.Keys)
        {
            Console.WriteLine($"Numer zamówienia: {numer}");
            Console.WriteLine("Produkty: " + string.Join(", ", zamowienia[numer]));
            Console.WriteLine($"Status: {statusy[numer]}");
            Console.WriteLine("--------------------");
        }

        Console.WriteLine("\nPróba zmiany statusu nieistniejącego zamówienia:");
        int nieistniejaceZamowienie = 3;
        if (!zamowienia.ContainsKey(nieistniejaceZamowienie))
        {
            Console.WriteLine($"Zamówienie o numerze {nieistniejaceZamowienie} nie istnieje!");
        }
    }
}
