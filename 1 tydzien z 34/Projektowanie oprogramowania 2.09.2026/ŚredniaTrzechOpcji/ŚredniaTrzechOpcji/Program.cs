// Pobierz 3 oceny i oblicz ich średnią

//Etap 1
Console.Write("Podaj ocene pierwszą: ");
double ocena1 = double.Parse(Console.ReadLine());
Console.Write("Podaj ocene drugą: ");
double ocena2 = double.Parse(Console.ReadLine());
Console.Write("Podaj ocene trzecią: ");
double ocena3 = double.Parse(Console.ReadLine());

//Etap 2

double srednia = (ocena1 + ocena2 + ocena3) / 3;

//Etap 3 

Console.WriteLine($"Średnia ocen wynosi {srednia:F2}");
