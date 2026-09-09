#include <iostream>
using namespace std;
int main()
{

    setlocale(LC_ALL, "");

    cout << "Dynamiczne tablice!\n";
    
    int ile;
    cout << "Podaj wielkośc tablicy "; cin >> ile;
    int* tablica = new int[ile];//definicja dynamicznej tablicy
    
    for (int i = 0; i < ile; i++)
    {
        int wartosc;
        cout << "Dodaj do tablicy element nr " << i << " = "; cin >> wartosc;
        tablica[i] = wartosc;
    }

    cout << " Lista wartości tablicy: " << endl;

    for (int j = 0; j < ile; j++)
    {
        cout << tablica[j] << endl;
    }
    return 0;
}


