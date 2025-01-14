using System;

public class BankAccount
{
    public string DaneWlasciciela;
	private decimal saldo;
	public decimal Saldo
	{
		get { return saldo; }
	}
	
	public BankAccount(string DaneWlasciciela, decimal saldo)
	{
		this.saldo = saldo;
		this.DaneWlasciciela = DaneWlasciciela;
	}
	
	public void wplata (decimal Kwota)
	{	
		saldo += Kwota;
		Console.WriteLine($"Stan konta to: {saldo}");
	}
	
	public void wyplata (decimal Kwota)
	{
		if(saldo <= Kwota)
		{
			throw new ArgumentException("Wyplata nie może być niższa niż stan konta");
		}
		else
			saldo -= Kwota;
			Console.WriteLine($"Stan konta to: {saldo}");
	}
	
	public void info()
	{
	    Console.WriteLine($"Właściciel: {DaneWlasciciela}, Kwota: {saldo}");
	}
	public static void Main()
	{
	    BankAccount konto1 = new BankAccount("Karol Sawicki", 5000);
	    Console.WriteLine("Podaj kwotę do operacji:\n");
	    string help = Console.ReadLine();
	    decimal Kwota = decimal.Parse(help);
	    Console.WriteLine("Co chcesz zrobić? \n 1.Wpłata \n 2.Wypłata");
	    string choice = Console.ReadLine();
	     switch(choice)
        {
            case "1":
                konto1.wplata(Kwota);
                break;
            case "2":
                konto1.wyplata(Kwota);
                break;
        }
	}
}

