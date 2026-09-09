#include <iostream>
#include <vector>
#include <structuredquery.h>
using namespace std;

struct studentus {
        string imie;
        string nazwisko;
        int wiek;
        double srednia_ocen;

    };



int main()
{
    setlocale(LC_ALL, "");
    vector<studentus> studenci = {
        {"Arkadiusz", "Waliczek", 20, 2.0},
        {"Dorota", "Wliczek", 25, 3.0},
        {"Zbigniew", "Wiczek", 40, 4.2}
    };
    for (auto& st : studenci) {
        cout << st.imie << " " << st.nazwisko << ", wiek: " << st.wiek << ", średnia:  " << st.srednia_ocen << endl;
    }
    studentus* najlepszy = &studenci[0];
    for (auto& s : studenci) {
        if (s.srednia_ocen > najlepszy->srednia_ocen) najlepszy = &s;
    }
    cout << "Najlepszy " << najlepszy->imie << " " << najlepszy->nazwisko << endl;

    return 0;
}