// Stworzenie klasy abstrakcyjnej Roślina
//    -||-    dwóch parametrów (Rodzaj_Rośliny, Nazwa_Rośliny)
//    -||-    abstrakcyjnej metody (WypiszDane)
public abstract class Roslina
{
    public string Rodzaj_Rosliny;
    public string Nazwa_Rosliny;

    public Roslina(string rodzaj, string nazwa)
    {
        Rodzaj_Rosliny = rodzaj;
        Nazwa_Rosliny = nazwa;
    }

    public abstract string WypiszDane();
}

// Dalej zadanie nie zostaje kontynuowane,
// ponieważ wyskakują błędy.
// Nie da się wywołać obiektu z klasy abstrakcyjnej