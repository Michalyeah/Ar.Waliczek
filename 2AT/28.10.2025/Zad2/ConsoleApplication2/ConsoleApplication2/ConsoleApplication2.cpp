
//Zad 2
#include <iostream>
#include <fstream>
#include <string>
using namespace std;
int main()
{
    fstream plik;
    
    
    plik.open("imiona.txt", ios::in);
    setlocale(LC_ALL, "");
    if (plik.good() == true) {
        cout << "Plik działa :)\n";
        for (int i = 1; i <= 5; i++) {
            cout << i <<  endl;
        }
        
    }
    else {
        cout << "Brak pliku do odczytu. :(";
    }
    
    plik.close();
    return 0;
}


