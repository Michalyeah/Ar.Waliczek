/*
 * Autor: Miszael
 * Nazwa projektu: Ek
 * Opis aplikacji: projekt oblicza energie kinetyczną i zwraca wynik typu double
 * Liczba zmiennych: 2, masa double, prędkość double
 * liczba metod (funkcji) 2, Mian i ek
 * Projekt zawiera projekt do testów jednostkowych: Ek.Test
 
 
 
 */




namespace Ek
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Aplikacja EK");
            Console.WriteLine("Podaj m = ");
            if(!double.TryParse(Console.ReadLine(), out double m))
            {
                Console.WriteLine("Błąd danych m");
                return;
            }
            Console.WriteLine("Podaj v = ");
            if (!double.TryParse(Console.ReadLine(), out double v))
            {
                Console.WriteLine("Błąd danych v");
                return;
            }
            Console.WriteLine($"EK = {ek(m,v)}:F2");
        }
        public static double ek(double m, double v)
        {
            return (m * Math.Pow(v, 2) / 2);
        }
    }
}
