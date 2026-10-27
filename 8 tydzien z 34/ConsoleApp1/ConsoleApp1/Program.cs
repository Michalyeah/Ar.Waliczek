namespace dziedziczenie
{
    //klasa bazowa (rodzic)
    public class Pracownik
    {
        //pola właściowści wspólne dla wszystkich pracowników

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public decimal PodstawyPensji { get; set; }

        //konstruktor klasy bazowej
        public Pracownik(string imie,string nazwisko, decimal podstawapensji) 
        {
            Imie = imie;
            Nazwisko = nazwisko;
            PodstawyPensji = podstawapensji;
        }
        //Metoda virtualna - pozwala na jej nadpisywanie w klasie potomnej
        public virtual void WyswietlDane()
        {
            Console.WriteLine($"Pracownik miesiąca: {Imie} {Nazwisko} {PodstawyPensji}");
        }
    }
    //klasa pochodna (dzieciok)
    public class Programista : Pracownik 
    { 
        public string GlownyJezyk { get; set; }

        //Konstruktor klasy pochodnej - przekazuje dane do bazy za pomocą słowa kluczowego base
        public Programista(string imie, string nazwisko, decimal podstawapensji, string glownyJezyk) :base(imie,nazwisko,podstawapensji)
        {
            GlownyJezyk = glownyJezyk;
        }

        public override void WyswietlDane()
        {
            Console.WriteLine($"Pracownik miesiąca: {Imie} {Nazwisko} {PodstawyPensji} {GlownyJezyk}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //Tworze obiekt klasy bazowej 
            Pracownik zwyklyPracownik = new Pracownik("Artur","Wojciech",8550);
            zwyklyPracownik.WyswietlDane();

            //Tworze obiekt klasy pochdnej 
            Pracownik technikProgramista = new Programista("Julian", "Gruszek", 8550, "C#");
            technikProgramista.WyswietlDane();

            Console.ReadKey();
        }
    }
}
