namespace DoborTypowDanych
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string imie = "Michał";
            int wiek = 16;
            double srednia = 4.67;
            bool obecnosc = true;
            char klasa = 'A';

            Console.WriteLine($"{imie} {wiek} {srednia} {obecnosc} {klasa}");

            PobierzWiekUzytkowanika();
            konwertowanieTypuDanych();
            wartosciStale();
            mieszaneDane();

        }
        public static void PobierzWiekUzytkowanika()
        {
            Console.WriteLine("Podaj wiek użytkowniku: ");
            if(int.TryParse(Console.ReadLine(), out int w))
            {
                Console.WriteLine($"Za rok będziesz miał {w+1} lat");
            }
            else
            {
                Console.WriteLine("Nieprawidłowe dane");
            }
        }

        public static void konwertowanieTypuDanych()
        {
            int a = 5;
            int b = 10;
            double wynik = (double)a / b;
            Console.WriteLine(wynik);
        }
        public static void wartosciStale()
        {
            const double PI = 3.14159;
            double r = 4;
            double pole = PI * Math.Pow(r, 2);
            Console.WriteLine(pole);

        }
        public static void mieszaneDane()
        {
            string nazwa = "Filtr";
            int ilosc = 12;
            decimal cena = 89.50m;
            bool aktywny = true;
            char kategoria = 'A';
            Console.WriteLine(cena);
        }
    }
}
