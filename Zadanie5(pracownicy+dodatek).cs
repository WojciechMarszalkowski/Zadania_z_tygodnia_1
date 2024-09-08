using System;

// Stworzenie klasy Pracownik
//    -||-    właściwości (Imie, Funkcja, Wiek)
//    -||-    metody służącej do obliczania wypłaty
public class Pracownik
{
    public string Imie;
    public string Funkcja;
    public int Wiek;
    public int Lata_Doswiadczenia;
    public int Jakosc_Pracy;

    public Pracownik(string imie, string funkcja, int wiek, int lata_doswiadczenia, int jakosc_pracy)
    {
        Imie = imie;
        Funkcja = funkcja;
        Wiek = wiek;
        Lata_Doswiadczenia = lata_doswiadczenia;
        Jakosc_Pracy = jakosc_pracy;
    }
    // Ta metoda wykrywa wpisaną funkcję przez użytkownika
    // Jeżeli funkcja wpisana przez użytkownika nie będzie zgodna z danymi tutaj, zostanie wyświetlony komunikat: Brak funkcji!
    // Na samym dole funkcji przeliczana jest docelowa wartość pensji dla pracownika
    public double ObliczPensje()
    {
        int naleznosc = 0;

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

        return naleznosc * 1.1 * Wiek * Lata_Doswiadczenia * Jakosc_Pracy;
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

        Console.WriteLine("Podaj ilość lat doświadczenia pracownika:");
        int lata_doswiadczenia = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj jakość pracy pracownika (w skali 1-10):");
        int jakosc_pracy = int.Parse(Console.ReadLine());

        // Tworzenie obiektu pracownika
        Pracownik pracownik = new Pracownik(imie, funkcja, wiek, lata_doswiadczenia, jakosc_pracy);

        // Obliczanie pensji
        double pensja = pracownik.ObliczPensje();

        if (pensja > 0)
        {
            Console.WriteLine($"Pracownik {pracownik.Imie}, pełni funkcję {pracownik.Funkcja}. Ma {pracownik.Lata_Doswiadczenia} rok/lat/lata doświadczenia. W wieku {pracownik.Wiek} lat, zarabia {pensja} zł przy jakości pracy {pracownik.Jakosc_Pracy}/10");
        }
    }
}
