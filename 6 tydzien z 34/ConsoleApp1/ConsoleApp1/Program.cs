namespace Zadanie1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //tworze obiekt "yamaha" za pomocą konstruktora klasy "Motocykle"
            Motocykle yamaha = new Motocykle("YAMAHA 125", 125, 7);
            yamaha.opis();

            Motocykle suzuki = new Motocykle("Suzuki Intruder");
            Motocykle honda = new Motocykle();
        }
    }
    public class Motocykle
    {
        public string nazwa_motocykla;
        public double pojemnosc;
        public int moc;
        //Konstruktor klasy

        public Motocykle() { }//to jest default konstruktor
        public Motocykle(string nazwa_motocykla,double pojemnosc,int moc)
        {
            this.nazwa_motocykla = nazwa_motocykla;
            this.pojemnosc = pojemnosc;
            this.moc = moc; 
        }
        public Motocykle(string nazwa_motocykla)
        {
            this.nazwa_motocykla = nazwa_motocykla;
            this.opis2();
        }
        public void opis()
        {
            Console.WriteLine($"Nazwa: {nazwa_motocykla}\n Pojemność: {pojemnosc}\n Moc: {moc}\n");
        }
        public void opis2()
        {
            Console.WriteLine($"{nazwa_motocykla}\n");
        }
    
        //Destruktor klasy
        ~Motocykle()
        {

        }
    }
}