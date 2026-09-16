namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> uczniowie = new List<string>();

            listaUczniow(uczniowie);
            dodajUczniaDoListy(uczniowie);
            usunZListyUcznia(uczniowie);

            Console.WriteLine("Aktualna lista uczniów");
            foreach (string uczen in uczniowie)
            {
                Console.WriteLine(uczen);
            }
            Console.WriteLine("Liczba uczniów: " + uczniowie.Count);
        }

        public static void listaUczniow(List<string> uczniowie)
        {
            uczniowie.Add("Michał");
            uczniowie.Add("Felipe");
            uczniowie.Add("Karollo");
            uczniowie.Add("Patrykson");
            uczniowie.Add("Kubus");

            Console.WriteLine("Lista uczniów:  ");
            foreach (string uczen in uczniowie)
            {
                Console.WriteLine(uczen);
            }
        }

        public static void dodajUczniaDoListy(List<string> uczniowie)
        {
            Console.WriteLine("Podaj imie ucznia aby go dodać do listy: ");
            string imieDodaniaDoListy = Console.ReadLine() ?? "imie puste";

            uczniowie.Add(imieDodaniaDoListy);
        }

        public static void usunZListyUcznia(List<string> uczniowie)
        {
            Console.WriteLine("Podaj imie do usunięcia ucznia: ");
            string imieDoUsuniecia = Console.ReadLine() ?? "";

            if (uczniowie.Contains(imieDoUsuniecia))
            {
                uczniowie.Remove(imieDoUsuniecia);
                Console.WriteLine($"Usunięto ucznia: {imieDoUsuniecia}");
            }
            else
            {
                Console.WriteLine("Nie znaleziono takiego ucznia");
            }
            
        }
    }
}
