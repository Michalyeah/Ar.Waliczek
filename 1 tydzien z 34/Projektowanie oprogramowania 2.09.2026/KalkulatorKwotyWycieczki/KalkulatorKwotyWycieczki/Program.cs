//Program ma pobrać liczbę osób i cenę jednej osoby, a nastepnie obliczyć koszt całkowity
// 1 Najpierw identyfikujemy wejście - (liczba osób i cena)
// 2 Przetwarzanie  - np. mnozenie
// 3 Wyjście - np. może to być koszt całkowity

//-----------------Etap 1------------

Console.Write("Liczba osób: ");
int osoby = int.Parse(Console.ReadLine());
Console.Write("Cena jednej osoby: ");
decimal cena = decimal.Parse(Console.ReadLine());
//------------------------------------

//----------------Etap 2--------------
decimal razem = osoby * cena;
//------------------------------------

//----------------Etap 3--------------

Console.Write($"Koszt Łączny: {razem:F2} PLN");

