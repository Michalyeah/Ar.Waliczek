namespace Zadanko2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Nauczyciel nauczyciel = new Nauczyciel(18, "Arkadiusz", "Waliczek", 20);
            nauczyciel.OpisNauczyciela(); Console.WriteLine("------------------------------------");
            List<int> wyniki = new List<int>();
            Console.WriteLine("Podaj ile wyników matur chcesz dodać do listy");
            if (!int.TryParse(Console.ReadLine(), out int liczbaWynikow))
            {
                Console.WriteLine("Błąd danych");
            }
            for (int i = 0; i < liczbaWynikow; i++)
            {
                Console.WriteLine($"Podaj ocene: {i + 1}");
                if (!int.TryParse(Console.ReadLine(), out int wynik))
                {
                    Console.WriteLine("Błąd danych");
                }
                wyniki.Add(wynik);
            }
            nauczyciel.OpisNauczyciela();
            Console.WriteLine(string.Join(" , ", wyniki));
            Console.WriteLine();
            Console.WriteLine($"Ocena najlepsza: {nauczyciel.ocenaNajlepsza(wyniki)}");
            Console.WriteLine($"Ocena najgorsza: {nauczyciel.ocenaNajgorsza(wyniki)}");
            Console.WriteLine($"Średnia ocen: {nauczyciel.Srednia(wyniki)}");
        }
    }
    public class Nauczyciel
    {
        string imie, nazwisko;
        int wiek;
        int lataNauki;
        public Nauczyciel() { }
        public Nauczyciel(int wiek, string imie, string nazwisko, int lataNauki)
        {
            this.wiek = wiek;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.lataNauki = lataNauki;
        }
        public void OpisNauczyciela()
        {
            Console.WriteLine($"Nazwisko: {nazwisko}\n" + $"Imie: {imie}\n" + $"Wiek: {wiek}\n" + $"Lata pracy: {lataNauki}\n");
        }
        public List<int> OpiszNauczyciela(List<int> wyniki)
        {
            wyniki.Sort();

            return wyniki;
        }
        public int ocenaNajlepsza(List<int> wyniki)
        {
            return wyniki.Max();
        }
        public int ocenaNajgorsza(List<int> wyniki)
        {
            return wyniki.Min();
        }
        public double Srednia(List<int> wyniki)
        {
            return wyniki.Average();
        }

        public double OcenaNauczyciela(List <int> wyniki)
        {
            if(wyniki.Average() > 80)
            {
                Console.WriteLine();
            }

            return wyniki.Average();
            
        }
        ~Nauczyciel() { }
    }
}
