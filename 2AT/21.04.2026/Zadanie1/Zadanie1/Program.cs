class Program
{
    public  double dodawanie(double l1,double l2)
    {
        return l1 + l2;
    }
    public  double odejmowanie(double l1, double l2)
    {
        return l1 - l2;
    }
    public  double mnozenie(double l1, double l2)
    {
        return l1 * l2;
    }
    public double dzielenie(double l1, double l2)
    {
        if (l2 == 0) return 0;
        return l1 / l2;
    }
    public static void Main(string[] args)
    {
        Program obiekt = new Program();
        /*
        Console.Write("Michał Kula: Kalkulator");
        Console.WriteLine("Dodawanie = " + dodawanie(2, 3));
        Console.WriteLine("Odejmowanie = " + odejmowanie(2, 3));
        Console.WriteLine("Mnożenie = " + mnozenie(2, 3));
        Console.WriteLine("Dzielenie = " + dzielenie(2, 3));
        */
        if (args[0] == "1") Console.WriteLine("Dodawanie = " + obiekt.dodawanie(2, 3));
        if (args[0] == "2") Console.WriteLine("Dodawanie = " + obiekt.odejmowanie(2, 3));
        if (args[0] == "3") Console.WriteLine("Dodawanie = " + obiekt.mnozenie(2, 3));
        if (args[0] == "4") Console.WriteLine("Dodawanie = " + obiekt.dzielenie(2, 3));

    } 






}


