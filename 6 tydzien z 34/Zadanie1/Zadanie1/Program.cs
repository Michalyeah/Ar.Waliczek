using System.Security.Cryptography.X509Certificates;

namespace Zadanie1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] tablica = { 24, 7, 1, 18, 3 };
            //talica nieposortowana

            Console.WriteLine(string.Join(" ", tablica));

            //ta funkcja ma za zadanie posortowac tablice rosnący 
            PokazTablice(tablica);

            //tablica posortowana
            Console.WriteLine(string.Join(" ", tablica));

            //Zwracam wartosc minimalna tablicy 
            Console.WriteLine(PokazMinimum(tablica));
            //Zwracam wartosc maksymalną tablicy 
            Console.WriteLine(PokazMaksium(tablica));
            //Zwraca wartosc sumy tablicy
            Console.WriteLine(SumaTablicy(tablica));

            //Oblicz pole trójkata p_tr = a * h/2
            double PoleTrójkata = ((double)WartoscA(10) * (double)WartoscH(2)) / 2;
            Console.WriteLine($"Wynik P_Tr = {PoleTrójkata:F2}");

            //Dodaj liste imon kolegów z klasy
            List<string> list = new List<string> {
                "Arkadiusz",
                "Mariusz",
                "Dariusz",
                "Kanariusz",
                "Korneliusz"
            };
            ListaImona(list);
        }
        public static void ListaImona(List<string> imiona)
        {
            imiona.Add("Zbigniew");
            imiona.Add("Józefa");
            imiona.Remove("Arkadiusz");
            foreach (var imie in imiona)
            {

                Console.WriteLine(imie);
            }

        }
        public static int[] PokazTablice(int[] t)
        {
            Array.Sort(t);
            return t;

        }
        public static int PokazMinimum(int[] tablica)
        {
            return tablica.Min();

        }
        public static int PokazMaksium(int[] tablica)
        {
            return tablica.Max();

        }
        public static int SumaTablicy(int[] tablica)
        {
            return tablica.Sum();

        }
        public static int WartoscA(int a)
        {
            return a;
        }
        public static int WartoscH(int h)
        {
            return h;
        }

    }
}