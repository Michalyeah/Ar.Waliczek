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

    };

    uczen Arkadius = { "Arkadiusz", "Waliczek", 50 ,{3,4,5,6,1},0 };
    uczen Arturos = { "Artur", "Wojciech", 40 ,{3,4,5,6,1},0 };
    uczen Kacprus = { "Kacper", "Wilczek", 28 ,{3,4,5,6,1}, 0 };

    cout << Arkadius.imie << " " << Arkadius.nazwisko << " " << Arkadius.wiek << endl;






    return 0;
}
 