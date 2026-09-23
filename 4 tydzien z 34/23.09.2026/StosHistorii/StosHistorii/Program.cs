//ListyIStos

namespace StosHistorii
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Zasymulujemy historię odwiedzonych stron
            //Push dodaje na szczyt stosu, Pop pobiera ze szczytu
            Stack<string> stos = StosHistorii() ;
            

            Console.WriteLine($"Wstecz do: {stos.Pop()}");
            Console.WriteLine($"Teraz: {stos.Peek()}");

        }
        public static Stack<string> StosHistorii()
        {
            Stack<string> historia = new();
            historia.Push("Start");
            historia.Push("Produkty");
            historia.Push("O nas");
            historia.Push("Kontakt");

            return historia;
        }


    }
}


