namespace Zadanko
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Uczniowie uczen = new Uczniowie(18, "Felipe", "Król");
            uczen.OpisUcznia();Console.WriteLine("------------------------------------");
            List<int> oceny = new List<int>();
            Console.WriteLine("Podaj ile ocen chcesz dodać do listy");
            if(!int.TryParse(Console.ReadLine(),out int liczbaOcen))
            {
                Console.WriteLine("Błąd danych");
            }
            for(int i = 0; i < liczbaOcen; i++)
            {
                Console.WriteLine($"Podaj ocene: {i + 1}");
                if (!int.TryParse(Console.ReadLine(), out int ocena))
                {
                    Console.WriteLine("Błąd danych");
                }
                oceny.Add(ocena);
            }
            uczen.OcenyUcznia(oceny);
            Console.WriteLine(string.Join(" , ", oceny));
            Console.WriteLine();
            Console.WriteLine($"Ocena najlepsza: {uczen.ocenaNajlepsza(oceny)}");
            Console.WriteLine($"Ocena najgorsza: {uczen.ocenaNajgorsza(oceny)}");
            Console.WriteLine($"Średnia ocen: {uczen.Srednia(oceny)}");
        }
    }
    public class Uczniowie
    {
        string imie, nazwisko;
        int wiek;
        public Uczniowie() { }
        public Uczniowie(int wiek, string imie, string nazwisko)
        {
            this.wiek = wiek;
            this.imie = imie;
            this.nazwisko = nazwisko;

        }
        public void OpisUcznia()
        {
            Console.WriteLine($"Nazwisko: {nazwisko}\n" + $"Imie: {imie}\n" + $"Wiek: {wiek}\n");
        }
        public List<int> OcenyUcznia(List<int> mojeOceny)
        {
            mojeOceny.Sort();

            return mojeOceny;
        }
        public int ocenaNajlepsza(List<int> mojeOceny)
        {
            return mojeOceny.Max();
        }
        public int ocenaNajgorsza(List<int> mojeOceny)
        {
            return mojeOceny.Min();
        }
        public double Srednia(List<int> mojeOceny)
        {
            return mojeOceny.Average();
        }
        ~Uczniowie() { }
    }
}
