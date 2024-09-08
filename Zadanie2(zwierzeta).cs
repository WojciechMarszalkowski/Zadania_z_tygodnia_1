// Stworzenie interfejsu "ZwierzeAkcje" i metod
public interface ZwierzeAkcje
{
    void Jedzenie();
    void Spanie();
    void Ruch();
    void Dzwiek();
}

// Inmpementacja interfejsu, metod
// Stowrzenie unikatowych dwóch metod dla klas Kot i Pies
public class Kot : ZwierzeAkcje
{
    public void Jedzenie()
    {
        Console.WriteLine("Kot je.");
    }
    public void Spanie()
    {
        Console.WriteLine("Kot śpi.");
    }
    public void Ruch()
    {
        Console.WriteLine("Kot cicho chodzi.");
    }
    public void Dzwiek()
    {
        Console.WriteLine("Kot miauczy i mruczy.");
    }
    // Ukikatowe lokalne funkcje dla klasy Kot
    public void Ocieranie_Sie()
    {
        Console.WriteLine("Kot ociera się np o nogę wlasciciela.");
    }
    public void Drapanie()
    {
        Console.WriteLine("Kot drapie drapak.");
    }
}

public class Pies : ZwierzeAkcje
{
    public void Jedzenie()
    {
        Console.WriteLine("Pies je.");
    }
    public void Spanie()
    {
        Console.WriteLine("Pies śpi.");
    }
    public void Ruch()
    {
        Console.WriteLine("Pies biegnie do wlasciciela.");
    }
    public void Dzwiek()
    {
        Console.WriteLine("Pies szczeka.");
    }
    // Ukikatowe lokalne funkcje dla klasy Pies
    public void Komendy()
    {
        Console.WriteLine("Pies słucha się wlasciciela - wykonuje polecenia.");
    }
    public void Cieszy_Sie()
    {
        Console.WriteLine("Pies usmiecha sie i merda ogonem.");
    }
}

// Stworzenie i wywoływanie obiektów
public class Program
{
    public static void Main()
    {
        Kot kot = new Kot();
        Pies pies = new Pies();

        kot.Jedzenie();
        kot.Spanie();
        kot.Ruch();
        kot.Dzwiek();
        kot.Ocieranie_Sie();
        kot.Drapanie();

        pies.Jedzenie();
        pies.Spanie();
        pies.Ruch();
        pies.Dzwiek();
        pies.Komendy();
        pies.Cieszy_Sie();
    }
}

