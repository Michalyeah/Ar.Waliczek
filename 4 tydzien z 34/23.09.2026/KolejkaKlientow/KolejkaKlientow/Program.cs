//ListyIStos

namespace ListyIStos
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Zasymulujemy obsługę klientów w kolejności przyjścia FIFO
            Queue<string> k = GetQueue();

            while(k.Count > 0)
            {
                Console.WriteLine($"Obsługa: {k.Dequeue()}");
            }
        }
        public static Queue<string> GetQueue() {
            Queue<string> klienci = new();
            klienci.Enqueue("Rzecki");
            klienci.Enqueue("Wokulski");
            klienci.Enqueue("Łęcka");
            klienci.Enqueue("Krzeszowska");
            return klienci;
        }
       
    }
}


