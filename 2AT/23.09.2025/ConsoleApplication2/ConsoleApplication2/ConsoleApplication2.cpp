// ConsoleApplication2.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

int main()
{
    cout << "Średnia arytmetyczna elementów tablicy \n";
    int tablica[] = { 4,5,6,10};

    double srednia;
    double suma;
    int length = sizeof(tablica) / sizeof(tablica[0]);
    
    for (size_t i = 0; i < length; i++) {
        suma += tablica[i];
    }
    srednia = suma / length;
    cout << srednia;
    


    return  0;
}


