using System.Diagnostics.CodeAnalysis;

namespace Zada
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> stacki = StosLiczba();
            List<int> lista = ListaLiczba();
            Queue<int> qu = QueLiczba();

            Console.WriteLine($"Suma: {stacki.Sum()}, Średnia{stacki.Average()}, Min: {stacki.Min()}, Max: {stacki.Max()}");
            Console.WriteLine($"Suma: {lista.Sum()}, Średnia{lista.Average()}, Min: {lista.Min()}, Max: {lista.Max()}");
            Console.WriteLine($"Suma: {qu.Sum()}, Średnia{qu.Average()}, Min: {qu.Min()}, Max: {qu.Max()}");
        }
        public static Stack<int> StosLiczba()
        {
            Stack<int> stack = new();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);




            return stack;


        }
        public static List<int> ListaLiczba()
        {
            List<int> list = new();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            return list;
        }
        public static Queue<int> QueLiczba()
        {
            Queue<int> queue = new();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);

            
            return queue;
        }
    }
}