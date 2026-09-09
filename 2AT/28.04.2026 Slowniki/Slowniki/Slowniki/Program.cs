class Student
{
    public string Imie {  get; set; }
    public string Nazwisko { get; set; }
    public int Wiek {  get; set; }

}

public class Program
{
    public string[] tablica;
    public int[,] tablica2D;

    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        students.Add(new Student() { Imie="Michał", Nazwisko="Kula", Wiek=16});
        students.Add(new Student() { Imie = "Jacob", Nazwisko = "Pear", Wiek = 18 });
        students.Add(new Student() { Imie = "Grzegorz", Nazwisko = "Brzęczyszczykiewicz", Wiek = 19 });

        foreach(var s in students)
        {
            Console.WriteLine($"Nazwisko: {s.Nazwisko}, Imię: {s.Imie}, Wiek: {s.Wiek}");
        }


        //----------------------------------------------------------------------------

        List<string> nazwySzkol = new List<string>
        {
            "Pzs nr 1 w Pszczynie",
            "Pzs nr 2 w Pszczynie",
            "LO Chrobry",
            "21 LO",


        };
        nazwySzkol.Add("Szkola Prywatna kole Orlenu");

        foreach (var item in nazwySzkol)
        {
            Console.WriteLine(item);
        }
        //--------------------------------------------------------------------
        Program program = new Program();
        program.tablica = ["tab1", "tab2", "tab3"];

        foreach(var t in program.tablica)
        {
            Console.WriteLine($"Element tablicy: {t}");
        }
        //-----------------------------------------------------------------------
        for (int i = 0; i< 3; i++)
        {
            for (int j = 0; j < 3; i++)
            {

            }
        }
    }
}