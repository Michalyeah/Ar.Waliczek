namespace Zadanie1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> uczniowie = new List<string>();
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
            Console.WriteLine("Podaj imie ucznia aby go dodać do listy: ");
            string imieDodaniaDoListy = Console.ReadLine() ?? "imie puste";
            uczniowie.Add(imieDodaniaDoListy);
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
            Console.WriteLine("Aktualna lista uczniów");
            foreach (string uczen in uczniowie)
            {
                Console.WriteLine(uczen);
            }
            Console.WriteLine("Liczba uczniów: " + uczniowie.Count);
        }
    }
}
