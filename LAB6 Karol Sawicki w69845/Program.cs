using System;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj numer albumu: ");
        string numerAlbumu = Console.ReadLine();

        Console.WriteLine("Podaj nazwę pliku: ");
        string nazwaPliku = Console.ReadLine();
        
        string json = JsonConvert.SerializeObject(numerAlbumu, Formatting.Indented);

        File.WriteAllText(nazwaPliku, json);

        Console.WriteLine($"Dane zapisano w pliku {nazwaPliku}.");

/////////////////     ZAD2                  ///////////////////////////////////////////////

        Console.WriteLine("Podaj nazwę pliku do odczytu: ");
        string nazwaPlik = Console.ReadLine();

        try
        {
            string zawartosc = File.ReadAllText(nazwaPlik);

            Console.WriteLine($"Zawartość pliku {nazwaPlik}:");
            Console.WriteLine(zawartosc);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Błąd: Plik o nazwie {nazwaPlik} nie istnieje.");
        }

        /////////////////////////// ZAD3 ///////////////////////////////////////////////////////////////////
        string nazwaPeseli = "pesele.txt";

        try
        {
            List<string> pesels = new List<string>(File.ReadAllLines(nazwaPeseli));

            Console.WriteLine($"Wczytano {pesels.Count} peseli z pliku {nazwaPeseli}.");

            int liczbaZenskichPeseli = PoliczZenskiePesels(pesels);

            Console.WriteLine($"Liczba żeńskich peseli: {liczbaZenskichPeseli}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Błąd: Plik {nazwaPeseli} nie istnieje.");
        }
    }

    static int PoliczZenskiePesels(List<string> pesels)
    {
        int liczbaZenskich = 0;

        foreach (string pesel in pesels)
        {
            if (pesel.Length == 11 && (pesel[9] - '0') % 2 == 0) 
            {
                liczbaZenskich++;
            }
        }

        return liczbaZenskich;
    }
}

