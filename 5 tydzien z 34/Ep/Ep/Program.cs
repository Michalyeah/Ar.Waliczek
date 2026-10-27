/*
 * Autor: Miszael
 * Nazwa Projekt: Obliczanie Energi potencjalnej
 * Opis aplikacji: projekt oblicza energie potencjalną i zwraca wynik typu double
 * Liczba zmiennych: 3, masa double, wysokość double, przyciąganie ziemskie
 * liczba metod (funkcji) 2, Main i ep
 * Projekt zawiera projekt do testów jednostkowych: Ep.Test
 */




namespace Ep
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj mase = ");
            if (!double.TryParse(Console.ReadLine(), out double m))
            {
                Console.WriteLine("Podaj liczbe poprawna a nie");
                return;
            }
            Console.WriteLine("Podaj wysokość = ");
            if (!double.TryParse(Console.ReadLine(), out double h))
            {
                Console.WriteLine("Podaj liczbe poprawna a nie");
                return;
            }
            Console.WriteLine($"Energia potencjalna = {ep(m,h,10)}:F2");
        }
        public static double ep(double m,double h, double g)
        {
            return (m * g * h);
        }
    }
}