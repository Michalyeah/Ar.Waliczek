//Zad1

#include <iostream>
#include <fstream>
#include <string>
using namespace std;
int main()
{
    
    fstream plik;
    string imie;
    string linia;

    plik.open("imiona.txt", ios::out);
        setlocale(LC_ALL, "");
        if (plik.good() == true) {
            cout << "Plik jest gotowy do pracy\n";
            
            for (int i = 0; i < 5; i++) {
                cout << "Podaj imie\n";
                cin >> imie;
                plik << imie << endl;

            }
            cout << "Dane zapisano poprawnie\n";
        }
        else {
            cout << "Problemy z plikiem.\n";
        }
    
        plik.close();
        return 0;
}


