

void Restert(ref int x)
{
    int Count = 0;
    int max;
    Boolean Ready = false;

    for (int i = 0; Ready == false; Count++)
    {

        int Lotto = new Random().Next(1, 3);
        max = Lotto;

        Console.WriteLine(Lotto);

        if (max == 1)
        {

            Ready = true;
        }

    }


    x = Count;
}
;
int rekord = 0;
int x = 0;
bool y = false;
while (true)
{


    Console.ReadKey();
    y = false;
    for (int t = 0; y == false; t++)
    {
        Console.Clear();

        Restert(ref x);

        if (rekord < x)
        {
            rekord = x;
            Console.Beep(1000, 10);
            y = true;
        }

    }
    Console.WriteLine(rekord);

}

/*for (int i = 0; Ready == false; Count++)
{
    int Lotto = new Random().Next(0, 10);
    tablica[Lotto] = Lotto;
    if (tablica[0] == 0 && tablica[1] == 1 && tablica[2] == 2 && tablica[3] == 3 && tablica[4] == 4 && tablica[5] == 5 && tablica[6] == 6 && tablica[7] == 7 && tablica[8] == 8 && tablica[9] == 9)
    {


        Ready = true;
        Console.Beep(1000, 1000);
    }
}

    for (int i = 0; i < tablica.Length; i++)
{
    Console.WriteLine(tablica[i]);
    
}*/