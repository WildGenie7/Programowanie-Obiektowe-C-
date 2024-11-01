//Zad.1

using System.Data;
using System.Numerics;

zadanie1();

void zadanie1()
{
    double a, b, c, delta, d1,x1,x2;
    Console.WriteLine("Podaj 3 pierwiastki kwadratowe a,b,c:");
    a = Convert.ToDouble(Console.ReadLine());
    while (a == 0)
    {
        Console.WriteLine("a nie może być równe 0! Spróbuj ponownie:");
        a = Convert.ToDouble(Console.ReadLine());
    }
    
    
    b = Convert.ToDouble(Console.ReadLine());
    c = Convert.ToDouble(Console.ReadLine());
    delta = (Math.Pow(b, 2) - (4 * a * c));
    Console.WriteLine("Delta to:" + delta);
    if(delta > 0)
    {
        Console.WriteLine("Delta większa od zera, są dwa pierwiastki");
        d1 = Math.Sqrt(delta);
        x1 = (-b - d1) / (2 * a); 
        x2 = (-b + d1) / (2 * a);
        Console.WriteLine($"Pierwiastki to {x1} i {x2}");
    }   
    else if(delta == 0)
    {
        Console.WriteLine("Równanie ma jeden podwójny pierwiastek.");
        x1 = (-b) / (2 * a);
    }
    else
    {
        Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
    }
}

//Zad.2

zadanie2();

void zadanie2()
{
    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine("KALKULATOR:");
    double a, b, wynik, kat;
    Console.WriteLine("Podaj liczbę a i b:");
    a = Convert.ToDouble(Console.ReadLine());
    b = Convert.ToDouble(Console.ReadLine());
    while (true)
    {
        Console.WriteLine("Wybierz działanie:");
        Console.WriteLine("1.Suma\n2.Różnica\n3.Mnożenie\n4.Dzielenie\n5.Potęga\n6.Pierwiastek\n7.Trygonometria");
        int wybor = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        switch (wybor)
        {
            case 1:
                Console.WriteLine("Wynik dodawania to:");
                wynik = a + b;
                Console.WriteLine(wynik);
                break;

            case 2:
                Console.WriteLine("Wynik odejmowania to:");
                wynik = a - b;
                Console.WriteLine(wynik);
                break;
            case 3:
                Console.WriteLine("Wynik mnożenia to:");
                wynik = a * b;
                Console.WriteLine(wynik);
                break;
            case 4:
                Console.WriteLine("Wynik dzielenia to:");
                wynik = a / b;
                Console.WriteLine(wynik);
                break;
            case 5:
                Console.WriteLine("Wynik potęgowania to:");
                wynik = Math.Pow(a, b);
                Console.WriteLine(wynik);
                break;
            case 6:
                Console.WriteLine("Wynik pierwiastkowania to:");
                a = Math.Sqrt(a);
                b = Math.Sqrt(a);
                Console.WriteLine($"Wynik pierwiastkowania tych liczb to {a} i {b}");
                break;
            case 7:
                Console.WriteLine("Podaj kąt w radianach:");
                kat = Convert.ToDouble(Console.ReadLine());
                wynik = kat * (180 / Math.PI);
                Console.WriteLine("Wynik to:" + wynik);
                break;

        }
    }
}

//Zad.3

zadanie3();
void zadanie3()
{
    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine("Program do Zad.3");
    double[] liczby = new double[10];
    for(int i = 0; i < 10; i++)
    {
        Console.WriteLine("Podaj liczbę dla indeksu " + i);
        liczby[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("Tablica od pierwszego do ostatnie indeksu:");
    for (int i = 0; i < liczby.Length; i++)
    {
        Console.WriteLine(liczby[i]);
    }
    Console.WriteLine("Tablica od ostatniego do pierwszego indeksu:");
    for (int i = liczby.Length - 1; i>=0;  i--)
    {
        Console.WriteLine(liczby[i]);
    }
    Console.WriteLine("Wyświetlenie elementów o indeksach parzystych:");
    for(int i = 0; i < liczby.Length; i += 2)
    {
        Console.WriteLine(liczby[i]);
    }
    
    Console.WriteLine("Wyświetlenie elementów o indeksach nieparzystych:");
    for(int i = 1; i < liczby.Length; i += 2)
    {
        Console.WriteLine(liczby[i]);
    }
}

//zad.4
zadanie4();
void zadanie4()
{
    double suma = 0, srednia = 0;
    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine("Program do Zad.4");
    Console.WriteLine("Podaj 10 liczb do tablicy:");
    double[] liczby = new double[10];
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Podaj liczbę dla indeksu " + i);
        liczby[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("Liczenie sumy elementów tablicy:");
    for(int i = 0; i < liczby.Length; i++)
    {
        suma += liczby[i];
    }
    Console.WriteLine($"suma to: {suma}");
    suma = 1;
    Console.WriteLine("Liczenie iloczynu elementów tablicy:");
    for(int i = 0; i < liczby.Length; i++)
    {
        suma *= liczby[i];
    }
    Console.WriteLine($"Suma iloczynu elementów to: {suma}");
    Console.WriteLine("Liczenie wartości średniej:");
    for (int i = 0; i < liczby.Length; i++)
    {
        srednia += liczby[i];
    }
    srednia /= liczby.Length;
    Console.WriteLine($"Wartość średnia to: {srednia}");
    Console.WriteLine("Wskazywanie wartości minimalnej:");
    double min = liczby[0];
    for (int i = 0; i < liczby.Length; i++)
    {
        if (liczby[i] < min)
        {
            min = liczby[i];
        }
    }
    Console.WriteLine($"Wartość minimalna to: {min}");
    Console.WriteLine("Wskazywanie wartości maksymalnej:");
    double max = liczby[0];
    for (int i = 0; i < liczby.Length; i++)
    {
        if (max < liczby[i])
        {
            max = liczby[i];
        }
    }
    Console.WriteLine($"Wartość maksymalna to: {max}");
}

//Zad.5
zadanie5();

void zadanie5()
{
    Console.WriteLine("Wyświetlanie liczb 20-0 z wyłączeniem liczb: 2,6,9,15,19");
    for (int i = 20; i >= 0; i--)
    {
        if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
        {
            continue;
        }
        else
        {
            Console.WriteLine(i);
        } 
    }
}

//Zad.6
zadanie6();
void zadanie6()
{
    int calk;
    while (true)
    {
        Console.WriteLine("Podaj liczbę całkowitą dodatnią: ");
        calk = Convert.ToInt16(Console.ReadLine());
        if (calk < 0)
        {
            Console.WriteLine("Podałeś liczbę ujemną! Kończę działanie");
            break;
        }
    }
}

//Zad.7
zadanie7();

void zadanie7()
{
    int dlugosc = 0;
    Console.WriteLine("Podaj długość tablicy do posortowania (za chwilę wprowadzisz do niej liczby): ");
    dlugosc = Convert.ToInt16(Console.ReadLine());
    int[] tablica = new int[dlugosc];
    for (int i = 0; i < tablica.Length; i++)
    {
        Console.WriteLine("Podaj liczbę dla indeksu " + i);
        tablica[i] = Convert.ToInt16(Console.ReadLine());
    }
    
    for (int i = 0; i < tablica.Length - 1; i++)
    {

        for (int j = 0; j < tablica.Length - 1 - i; j++)
        {
            if (tablica[j] > tablica[j + 1])
            {
                int temp = tablica[j];
                tablica[j] = tablica[j + 1];
                tablica[j + 1] = temp;
            }
        }
    }
    Console.WriteLine("Posortowana tablica to: ");
    for (int i = 0; i < tablica.Length; i++)
    {
        Console.WriteLine(tablica[i]);
    }
}