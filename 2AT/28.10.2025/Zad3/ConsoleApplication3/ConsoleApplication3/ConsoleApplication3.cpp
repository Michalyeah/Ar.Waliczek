//Zad3
#include <iostream>
#include <fstream>
#include <string>
using namespace std;
int main()
{
    fstream plik;
    string linia;

    plik.open("tekst.txt", ios::in);
    setlocale(LC_ALL, "");
    if (plik.good() == true) {
        cout << "Plik działa :)\n";
        int i = 0;
        int slowa;
        while (plik >> linia) {
            stoi(slowa);
            i++;

           
            
        }

    }
    else {
        cout << "Brak pliku do odczytu. :(";
    }

    plik.close();
    return 0;
}
