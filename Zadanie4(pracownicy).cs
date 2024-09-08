using System;

// Stworzenie klasy Pracownik
//    -||-    właściwości (Imie, Funkcja, Wiek)
//    -||-    metody służącej do obliczania wypłaty
public class Pracownik
{
    public string Imie;
    public string Funkcja;
    public int Wiek;

    public Pracownik(string imie, string funkcja, int wiek)
    {
        Imie = imie;
        Funkcja = funkcja;
        Wiek = wiek;
    }
// Ta metoda wykrywa wpisaną funkcję przez użytkownika
// Jeżeli funkcja wpisana przez użytkownika nie będzie zgodna z danymi tutaj, zostanie wyświetlony komunikat: Brak funkcji!
// Na samym dole funkcji przeliczana jest docelowa wartość pensji dla pracownika
    public double ObliczPensje()
    {
        double naleznosc = 0;

        switch (Funkcja.ToLower())
        {
            case "kierowca":
                naleznosc = 6000;
                break;
            case "mechanik":
                naleznosc = 5000;
                break;
            case "obsluga":
                naleznosc = 4000;
                break;
            default:
                Console.WriteLine("Brak funkcji!");
                return 0;
        }

        return naleznosc * 1.1 * Wiek;
    }
}

// Sworzenie programu "zbierającego" dane podane przez użytkownika
// Program pyta użytkownika o imię, pełnioną przez niego funkcję oraz wiek
// Po podaniu tych informacji (jeżeli funkcja została odpowiednio wybrana) program przelicza pensję
// Na koniec wypisuje otrzymane informacje oraz wartość pensji
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Podaj imię pracownika:");
        string imie = Console.ReadLine();

        Console.WriteLine("Podaj funkcję pracownika (kierowca, mechanik, obsługa):");
        string funkcja = Console.ReadLine();

        Console.WriteLine("Podaj wiek pracownika:");
        int wiek = int.Parse(Console.ReadLine());

        // Tworzenie obiektu pracownika
        Pracownik pracownik = new Pracownik(imie, funkcja, wiek);

        // Obliczanie pensji
        double pensja = pracownik.ObliczPensje();

        if (pensja > 0)
        {
            Console.WriteLine($"Pracownik {pracownik.Imie}, pełni funkcję {pracownik.Funkcja} i w wieku {pracownik.Wiek} lat, zarabia {pensja} zł.");
        }
    }
}
