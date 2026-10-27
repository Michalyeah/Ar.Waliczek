namespace projekt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tablica");
            int[] tablica = { 1, 3, 2, 8, 4, 6 };
            Console.WriteLine($"Min: {Mini(tablica)}");
            Console.WriteLine($"Max: {Maxi(tablica)}");
            Console.WriteLine($"Sum: {Sumi(tablica)}");
            Console.WriteLine($"Average: {Aveg(tablica)}");
            Console.WriteLine($"Second Min: {secondMin(tablica)}");

        }
        public static int Mini(int[] tablica)
        {
            return tablica.Min();
        }
        public static int Maxi(int[] tablica)
        {
            return tablica.Max();
        }
        public static int Sumi(int[] tablica)
        {
            return tablica.Sum();
        }
        public static double Aveg(int[] tablica)
        {
            return tablica.Average();
        }
        public static int secondMin(int[] tablica)
        {
           int mini = tablica.Min();
            int[] meanwhile = new int[5];
            foreach(var item in tablica)
            {
                if(item != mini)
                {
                    int j = tablica[item];
                    meanwhile[item] = j;
                }
            }
            int mini2 = meanwhile.Min();
            return mini2;
        }
    }
}
