using System;

public class Sumator
{
    private int[] Liczby;

    public Sumator(int[] liczby)
    {
        Liczby = liczby;
    }

    public int Suma()
    {
        int suma = 0;
        foreach (var liczba in Liczby)
        {
            suma += liczba;
        }
        return suma;
    }

    public int SumaPodziel2()
    {
        int suma = 0;
        foreach (var liczba in Liczby)
        {
            if (liczba % 2 == 0)
            {
                suma += liczba;
            }
        }
        return suma;
    }

    public int IleElementów()
    {
        return Liczby.Length;
    }

    public void WypiszElementy()
    {
        Console.WriteLine("Elementy tablicy:");
        foreach (var liczba in Liczby)
        {
            Console.WriteLine(liczba);
        }
    }

    public void WypiszElementyZakres(int lowIndex, int highIndex)
    {
        int start = Math.Max(0, lowIndex);
        int end = Math.Min(Liczby.Length - 1, highIndex);

        Console.WriteLine($"Elementy w zakresie od indeksu {start} do {end}:");

        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(Liczby[i]);
        }
    }

    public static void Main()
    {
        int[] liczby = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Sumator sumator = new Sumator(liczby);

        Console.WriteLine("Suma wszystkich liczb: " + sumator.Suma());
        Console.WriteLine("Suma liczb podzielnych przez 2: " + sumator.SumaPodziel2());
        Console.WriteLine("Liczba elementów w tablicy: " + sumator.IleElementów());
        
        sumator.WypiszElementy();

        sumator.WypiszElementyZakres(3, 7);  
        sumator.WypiszElementyZakres(-1, 5); 
        sumator.WypiszElementyZakres(5, 12); 
    }
}
