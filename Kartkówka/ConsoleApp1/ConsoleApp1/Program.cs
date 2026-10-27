namespace Program
{
    public class Samochodowka
    {

        public static void Main(string[] args)
        {
            int[] oceny = new int[5];
            
            for (int i = 0; i < oceny.Length; i++) {
                int ocena;
                if(int.TryParse(Console.ReadLine(), out ocena) == true)
                {
                    oceny[i] = ocena;
                }
               
                
            }
            Avge(oceny);
            Maxi(oceny);
            Mini(oceny);
        }
        public static void Avge(int[] oceny)
        {
            
            Console.WriteLine("Średnia ocen: " + oceny.Average());
        }
        public static void Maxi(int[] oceny)
        {
             
            Console.WriteLine("Najwyższa ocena: " + oceny.Max());
        }
        public static void Mini(int[] oceny)
        {
             
            Console.WriteLine("Najniższa ocena: " + oceny.Min());
        }
    }

    
}
