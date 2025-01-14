using System;

public class Licz
{
    private decimal value;

    public Licz(decimal initialValue)
    {
        value = initialValue;
    }

    public void Dodaj(decimal liczba)
    {
        value += liczba;
    }

    public void Odejmij(decimal liczba)
    {
        value -= liczba;
    }

    public void WypiszStan()
    {
        Console.WriteLine("Aktualna wartość: " + value);
    }

    public static void Main()
    {
        
        Licz liczba1 = new Licz(10);  
        Licz liczba2 = new Licz(5);   

       
        liczba1.WypiszStan();
        liczba2.WypiszStan();

        liczba1.Dodaj(7);  
        liczba2.Odejmij(3); 
        
        liczba1.WypiszStan();
        liczba2.WypiszStan();
    }
}
