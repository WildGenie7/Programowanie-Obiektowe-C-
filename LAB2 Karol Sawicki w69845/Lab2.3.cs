using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public List<int> Oceny { get; set; }

    public Student()
    {
        Oceny = new List<int>();
    }

    public void DodajOcene()
    {
        Console.WriteLine("Podaj ocenę do dodania:");
        string help = Console.ReadLine();
        
        if (int.TryParse(help, out int Ocena))
        {
            Oceny.Add(Ocena);
            Console.WriteLine("Oceny po dodaniu:");
            foreach (var ocena in Oceny)
            {
                Console.WriteLine(ocena);
            }
        }
        else
        {
            Console.WriteLine("Podano niepoprawną ocenę, spróbuj ponownie.");
        }
    }

    public void PoliczSrednia()
    {
        if (Oceny.Count > 0)
        {
            double srednia = (double)Oceny.Sum() / Oceny.Count;
            Console.WriteLine($"Średnia ocen: {srednia:F2}");
        }
        else
        {
            Console.WriteLine("Brak ocen do obliczenia średniej.");
        }
    }

    public static void Main()
    {
        Student student = new Student();
        student.Imie = "Karol";
        student.Nazwisko = "Sawicki";
        Console.WriteLine($"Uczeń: {student.Imie} {student.Nazwisko}");
        
        while (true) 
        {
            Console.WriteLine("Co chcesz zrobić?\n1. Dodaj ocenę\n2. Policz średnią\n3. Zakończ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    student.DodajOcene(); 
                    break;
                case "2":
                    student.PoliczSrednia(); 
                    break;
                case "3":
                    Console.WriteLine("Zakończono program.");
                    return;  
                default:
                    Console.WriteLine("Nieznana opcja.");
                    break;
            }
        }
    }
}
