#include <iostream>

using namespace std;
int main()
{
    int* wsk;// definicja
    int liczba = 10;
    wsk = &liczba;//& operator referencji
    cout << "Wskazniki c++ cw.1 !\n";

    cout << "WSK = " << (int)wsk << endl;
    //adres zmiennej liczba



    cout << "*WSK = " << *wsk << endl;
    //*wsk * nazywa się to operator wyłuskania,
    //przechodzi pod adres wskazujący przez wskaźnik i pobiera wartość zmiennej liczba
    
    
    cout << "Liczba = " << liczba << endl;
    //Wartość zmiennej liczba

    cout << "&Liczba = " << (int) & liczba << endl;
    //adres zmiennej liczba - czyli taki sam jak wskazuje wsk => wsk === &liczba

    cout << "&WSK = " << (int)&wsk << endl;
    //wskaźnik też posiada swój adres w pamięci RAM




    return 0;
}


