#include <iostream>
#include <time.h>
using namespace std;
int main()
{

    setlocale(LC_ALL, "");
    srand(time(NULL));//znacznik czasowy wykorzystywany w psuedolosowości
    int ile_liczb;
    int wylosowano;
    cout << "Podaj ile liczb losujesz = "; cin >> ile_liczb;
    int* tablica = new int[ile_liczb];
    for (int i = 0; i < ile_liczb; i++)
    {
        wylosowano = rand() % 100 + 1;
        tablica[i] = wylosowano;
        cout << wylosowano << endl;
    }
    int suma = 0;

    for (int j = 0; j < ile_liczb; j++)
    {
        suma += tablica[j];
    }
    cout << "Suma liczb w dynamicznej tablicy = " << suma << endl;
    cout << "Średnia wartośći tablicy = " << suma / ile_liczb << endl;
    delete[] tablica;
    return 0;
}
