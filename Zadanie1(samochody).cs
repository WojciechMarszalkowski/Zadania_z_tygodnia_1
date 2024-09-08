using System;

public class Auto
{
    // Właściwości klasy Auto
    public string Marka;
    public string Kolor;
    public double Cena;
    public string Model;
    public int RokProdukcji;

    // Konstruktor z 5 parametrami
    public Auto(string marka, string model, int rokProdukcji, string kolor, double cena)
    {
        Marka = marka;
        Kolor = kolor;
        Cena = cena;
        Model = model;
        RokProdukcji = rokProdukcji;
    }

    // Metoda do wyświetlania informacji o samochodzie
    public void WyswietlInformacje()
    {
        Console.WriteLine($"Marka: {Marka}, Kolor: {Kolor}, Cena: {Cena} PLN Model: {Model}, Rok produkcji: {RokProdukcji}");
    }
}

public class Program
{
    public static void Main()
    {
        // Tworzenie dwóch obiektów klasy Auto
        Auto car1 = new Auto("Skoda", "Fabia", 1999, "Szary", 72000);
        Auto car2 = new Auto("Opel", "Astra", 1991, "Czarny", 55000);

        // Wywołanie metody do wyświetlenia informacji o samochodach
        car1.WyswietlInformacje();
        car2.WyswietlInformacje();
    }
}