namespace ZadanieNumeroUno
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator");
            Program obiekt = new Program();
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            
            double wynik_dod =  obiekt.dodawanie(a, b);
            double wynik_ode = obiekt.odejmowanie(a, b);
            double wynik_mno = obiekt.mnozenie(a, b);
            double wynik_dzi = obiekt.dzielenie(a, b);
            Console.WriteLine($"+:{wynik_dod} -:{wynik_ode} *:{wynik_mno} /:{wynik_dzi} ");
           
        }

        public double  dodawanie(string a, string b)
        {
            Console.WriteLine("Dodawnaie");
            if (double.TryParse(a, out double liczba) && double.TryParse(b, out double liczba2){
                return liczba + liczba2;
            }
            else
            {
                return 0;
            }
        }
        public double  odejmowanie(string a, string b)
        {
            Console.WriteLine("Odejmowanie");
            if (double.TryParse(a, out double liczba) && double.TryParse(b, out double liczba2){
                return liczba - liczba2;
            }
            else
            {
                return 0;
            }
        }
        public double mnozenie(string a, string b)
        {
            Console.WriteLine("Mnozenie");
            if (double.TryParse(a, out double liczba) && double.TryParse(b, out double liczba2){
                return liczba * liczba2;
            }
            else
            {
                return 0;
            }

        }
        public double dzielenie(string a, string b)
        {
            Console.WriteLine("Dzielenie");
            if (double.TryParse(a, out double liczba) && double.TryParse(b, out double liczba2){
                return liczba / liczba2;
            }
            else
            {
                return 0;
            }
        }
    }
}
