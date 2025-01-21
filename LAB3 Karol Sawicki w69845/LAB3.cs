using System;
using System.Collections.Generic;

namespace LAB3
{
    
    public class Person
    {
        private string firstName;
        private string lastName;
        private int wiek;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Wiek
        {
            get { return this.wiek; }
            set { this.wiek = value; }
        }

        public Person(string firstName, string lastName, int wiek)
        {
            // Słowo kluczowe this. aby rozróżnić parametry od pól
            this.firstName = firstName;
            this.lastName  = lastName;
            this.wiek      = wiek;
        }

        public virtual void View()
        {
            Console.WriteLine($"Osoba: {this.FirstName} {this.LastName}, Wiek: {this.Wiek}");
        }
    }

    public class Book
    {
        protected string title;
        protected Person author;
        protected DateTime publishDate;

        public string Title
        {
            get { return this.title; }
            protected set { this.title = value; }
        }

        public Person Author
        {
            get { return this.author; }
            protected set { this.author = value; }
        }

        public DateTime PublishDate
        {
            get { return this.publishDate; }
            protected set { this.publishDate = value; }
        }

        public Book(string title, Person author, DateTime publishDate)
        {
            this.title       = title;
            this.author      = author;
            this.publishDate = publishDate;
        }

        public virtual void View()
        {
            Console.WriteLine(
                $"Tytuł: {this.Title}, " +
                $"Autor: {this.Author.FirstName} {this.Author.LastName}, " +
                $"Data wydania: {this.PublishDate.ToShortDateString()}"
            );
        }
    }

    public class AdventureBook : Book
    {
        public string Region { get; set; }

        public AdventureBook(string title, Person author, DateTime publishDate, string region)
            : base(title, author, publishDate)
        {
            this.Region = region;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Region przygody: {this.Region}");
        }
    }

    public class DocumentaryBook : Book
    {
        public string Topic { get; set; }

        public DocumentaryBook(string title, Person author, DateTime publishDate, string topic)
            : base(title, author, publishDate)
        {
            this.Topic = topic;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Temat dokumentu: {this.Topic}");
        }
    }

    public class Reader : Person
    {
        private List<Book> booksRead;

        public Reader(string firstName, string lastName, int wiek)
            : base(firstName, lastName, wiek)
        {
            this.booksRead = new List<Book>();
        }

        public void AddBook(Book book)
        {
            this.booksRead.Add(book);
        }

        public void ViewBooks()
        {
            Console.WriteLine("Lista przeczytanych książek:");
            foreach (var book in this.booksRead)
            {
                Console.WriteLine($" - {book.Title}");
            }
        }

        public override void View()
        {
            base.View();
            this.ViewBooks();
        }

        protected List<Book> BooksRead
        {
            get { return this.booksRead; }
        }
    }

    public class Reviewer : Reader
    {
        private Random random;

        public Reviewer(string firstName, string lastName, int wiek)
            : base(firstName, lastName, wiek)
        {
            this.random = new Random();
        }

        public override void View()
        {
            base.View();

            Console.WriteLine("Oceny (losowe) wystawione przez recenzenta:");
            foreach (var book in this.BooksRead)
            {
                int rating = this.random.Next(1, 11); // 1-10
                Console.WriteLine($"   '{book.Title}' → ocena: {rating}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("=== Zadanie 1a: Tworzenie obiektów Person i Book ===\n");

            Person person1 = new Person("Jan", "Kowalski", 45);
            Person person2 = new Person("Agnieszka", "Nowak", 28);

            Book book1 = new Book("C# dla początkujących", person1, new DateTime(2020, 1, 1));
            Book book2 = new Book("Zaawansowane techniki C#", person2, new DateTime(2021, 6, 15));

            person1.View();
            person2.View();
            Console.WriteLine();

            book1.View();
            book2.View();

            Console.WriteLine("\n=== Zadanie 1b: Klasa Reader, przypisywanie książek, ViewBooks ===\n");

            Reader reader1 = new Reader("Piotr", "Zieliński", 22);
            Reader reader2 = new Reader("Monika", "Wiśniewska", 19);
 
            reader1.AddBook(book1);
            reader1.AddBook(book2);

            AdventureBook adventure1 = new AdventureBook(
                "Wyprawa w Himalaje",
                person1,
                new DateTime(2018, 5, 10),
                "Himalaje"
            );
            DocumentaryBook doc1 = new DocumentaryBook(
                "Historia Europy XX wieku",
                person2,
                new DateTime(2019, 11, 1),
                "Wydarzenia wojenne"
            );

            reader2.AddBook(adventure1);
            reader2.AddBook(doc1);

            Console.WriteLine("-- Czytelnik #1 --");
            reader1.ViewBooks();

            Console.WriteLine("\n-- Czytelnik #2 --");
            reader2.ViewBooks();
            
            Console.WriteLine("\n=== Zadanie 1c: Reader.View() wypisuje dane i książki ===\n");
            Console.WriteLine("-- Reader #1 (reader1) --");
            reader1.View();

            Console.WriteLine("\n-- Reader #2 (reader2) --");
            reader2.View();

            Console.WriteLine("\n=== Zadanie 1f: Klasa Reviewer z losowymi ocenami ===\n");

            Reviewer reviewer1 = new Reviewer("Ewa", "Kwiatkowska", 30);
            Reviewer reviewer2 = new Reviewer("Paweł", "Lewandowski", 35);

            reviewer1.AddBook(book1);
            reviewer1.AddBook(adventure1);

            reviewer2.AddBook(book2);
            reviewer2.AddBook(doc1);

            Console.WriteLine("-- Reviewer #1 --");
            reviewer1.View();

            Console.WriteLine("\n-- Reviewer #2 --");
            reviewer2.View();

            Console.WriteLine("\n=== Zadanie 1g: List<Person> i wywołanie View() w pętli ===\n");

            List<Person> people = new List<Person>();
            people.Add(reader1);
            people.Add(reader2);
            people.Add(reviewer1);
            people.Add(reviewer2);

            foreach (var person in people)
            {
                person.View();
                Console.WriteLine();
            }

            Console.WriteLine("=== Koniec działania programu ===");
            Console.ReadKey();
        }
    }
}
