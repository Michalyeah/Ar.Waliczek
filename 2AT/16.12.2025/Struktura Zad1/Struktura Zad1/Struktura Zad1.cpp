

#include <iostream>
#include <structuredquery.h>
using namespace std;
int main()
{
    setlocale(LC_ALL, "");
    struct uczen {
        string imie;
        string nazwisko;
        int wiek;
        int oceny[5];
        int suma = 0;

    }arek, marek, jarek, dominik;
    arek = { "Arkadiusz", "Waliczek", 50, {1,1,1,1,2} };
    marek = { "Marek", "Wliczek", 40, {3,5,1,3,2} };
    jarek = { "JarosłAW", "Aliczek", 45, {5,1,2,1,2} };
    dominik = { "Dominik", "Saliczek", 32, {5,5,5,5,3} };

    cout << "====================" << endl;

    cout << arek.imie << " " << arek.nazwisko << " " << arek.wiek << endl;
    for (int i = 0; i < 5; i++) {
       cout << arek.oceny[i] << " " << endl;
       arek.suma += arek.oceny[i];
       
    }
    cout << "Suma ocen = " << arek.suma << endl;
    cout << "=====================" << endl;

    
    cout << marek.imie << " " << marek.nazwisko << " " << marek.wiek << endl;
    cout << jarek.imie << " " << jarek.nazwisko << " " << jarek.wiek << endl;
    cout << dominik.imie << " " << dominik.nazwisko << " " << dominik.wiek << endl;








    return 0;
}


