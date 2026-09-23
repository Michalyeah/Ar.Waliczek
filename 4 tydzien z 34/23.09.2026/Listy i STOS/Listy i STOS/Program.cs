//ListyIStos

namespace ListyIStos
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //LISTE można zmieniać (rozmiar) i ma 2 metody
            //Add i Remove
            List<string> list = GetProdukty(); 
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            ListaProduktowUpdate();
        }
        public static List<string> GetProdukty() {
            List<string> produkty = new() { "Filtry", "Pompa", "Zawór" };
            produkty.Add("Czujnik");

            return produkty;
        }
        public static void ListaProduktowUpdate()
        {
            List<string> pojazdy = new() { "Samochód", "Ciężarówka", "Motocykl" };
            pojazdy.Add("Samolot");
            pojazdy.Remove("Ciężarówka");

            Console.WriteLine(string.Join(", ",pojazdy)+ " "+ pojazdy.Count);
            
        }
    }
}


