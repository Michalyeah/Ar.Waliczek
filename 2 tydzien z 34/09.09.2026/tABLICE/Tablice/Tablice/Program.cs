namespace Tablice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            sumowanieDanych();
            maksimumTablicy();
            minimumTablicy();

        }
        public static void sumowanieDanych()
        {
            int[] tablica = { 4, 7, 2, 9, 1 };
            int suma = 0;

            foreach (var item in tablica)
            {
                suma += item;
            }
            Console.WriteLine(suma);
        }
        public static void maksimumTablicy()
        {
            int[] tablica = { 4, 7, 2, 9, 1 };
            int max = tablica[0];

            for (int i = 1; i < tablica.Length; i++) {
                if (tablica[i] > max)
                {
                    max = tablica[i];
                }
                Console.WriteLine(max);
            }

        }
        public static void minimumTablicy()
        {
            int[] tablica = { 4, 7, 2, 9, 1 };
            int min = tablica[0];

            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] < min)
                {
                    min = tablica[i];
                }
                Console.WriteLine(min);
            }

        }
        public static void macierze()
        {
            //Macierze czyli tablice wielowymiarowe
            /*
             |1,2,3|
             |3,4,5|
             |6,7,8|
             
             
             */
            int[,] talbica = { { 1, 2, 3 }, { 6, 5, 4 } };
            for(int wiersze = 0; wiersze < talbica.Length; wiersze++)
            {
                for(int kolumny = 0; kolumny < talbica.Length; kolumny++)
                {
                    Console.Write(talbica[wiersze,]);
                }
            }
        }
    }
}