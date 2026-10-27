namespace TestyJednostkowe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> ListaLiczb = new List<int>(); 
            ListaLiczb.Add(1);
            ListaLiczb.Add(3);
            ListaLiczb.Add(6);
            ListaLiczb.Add(5);
            ListaLiczb.Add(2);
            ListaLiczb.Add(4);
            ListaLiczb.Add(7);
            //nie posortowane
            Console.WriteLine(string.Join(" , ", ListaLiczb));
            Console.ReadLine();
            //posortowane
            Console.WriteLine(string.Join(",",SortowanieListy( ListaLiczb)));
            //Max---------------------------------
            Console.WriteLine($"Max: {Maxium(ListaLiczb)}");
            //Min------------------------------
            Console.WriteLine($"Min: {Minium(ListaLiczb)}");

            Console.WriteLine($"Druga max liczba: {secondMaxi(ListaLiczb)}");

        }
        public static List<int> SortowanieListy(List<int> listaLiczb)
        {
            listaLiczb.Sort();
            return listaLiczb;
        }
        public static int Maxium(List<int> listaLiczb)
        {
            return listaLiczb.Max();
        }
        public static int Minium(List<int> listaLiczb)
        {
            return listaLiczb.Min();
        }
        public static int secondMaxi(List<int> listaLiczb)
        {
            int maxi = listaLiczb.Max();
            List<int> Tymczasowa = new List<int>();

            foreach(var item in listaLiczb)
            {
                if(item != maxi)
                {
                    Tymczasowa.Add(item);
                }
            }
            int maxi2 = Tymczasowa.Max();
            return maxi2;
        }
    }
}
