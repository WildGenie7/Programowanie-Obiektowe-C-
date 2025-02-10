using System;
using System.Collections.Generic; 

enum Operacje
{
    Dodawanie,
    Odejmowanie,
    Mnozenie,
    Dzielenie
}

class Program
{
    static List<double> HistoriaWynikow = new List<double>(); 

    static void Main()
    {
        try
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            double liczba1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            double liczba2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Wybierz operację:");
            Console.WriteLine("0. Dodawanie\n1. Odejmowanie\n2. Mnożenie\n3. Dzielenie");
            Console.Write("Podaj wybór twardzielu: ");
            int wyborOpcji = int.Parse(Console.ReadLine());

            Operacje operacja = (Operacje)wyborOpcji;
            double wynik = Oblicz(liczba1, liczba2, operacja);

            HistoriaWynikow.Add(wynik);
            Console.WriteLine($"Wynik operacji {operacja}: {wynik}");

            Console.WriteLine("\nHistoria wyników:");
            foreach (var hist in HistoriaWynikow)
            {
                Console.WriteLine(hist);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Błąd! Wprowadzone dane nie są liczbami.");
            Console.WriteLine($"Ślad stosu wywołań:\n{ex.StackTrace}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Nie można dzielić przez zero!");
            Console.WriteLine($"Ślad stosu wywołań:\n{ex.StackTrace}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Nieoczekiwany błąd: {ex.Message}");
            Console.WriteLine($"Ślad stosu wywołań:\n{ex.StackTrace}");
        }
    }

    static double Oblicz(double liczba1, double liczba2, Operacje operacja)
    {
        switch (operacja)
        {
            case Operacje.Dodawanie: return liczba1 + liczba2;
            case Operacje.Odejmowanie: return liczba1 - liczba2;
            case Operacje.Mnozenie: return liczba1 * liczba2;
            case Operacje.Dzielenie:
                if (liczba2 == 0)
                    throw new DivideByZeroException("Dzielenie przez zero");
                return liczba1 / liczba2;
            default:
                throw new ArgumentOutOfRangeException(nameof(operacja));
        }
    }
}
