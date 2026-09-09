#include <iostream>
#include <vector>
using namespace std;
int main()
{
    setlocale(LC_ALL, "");
    vector<pair<string , int>> pracownik;
    string imie;
    int wiek;
    int n;
    int suma = 0;
    cout << "Podaj ilość pracowników : "; cin >> n;
    for (int i = 1; i <= n; i++) {
        cout << "Podaj imie pracownika : "; cin >> imie;
        cout << "Podaj wiek pracownika : "; cin >> wiek;
        pracownik.push_back({ imie , wiek });
        suma += wiek;
    }
    cout << "Suma wieku pracowników wynosi : " << suma << endl;
    cout << "Średnia wieku pracowników wynosi : " << suma/n << endl;
    for (int i = 1; i <= n; i++) {
        pracownik.front();
        int ilosc_lit;
        size(imie) / 16 = ilosc_lit;
        cout << "Ilość liter w imieniu pracownika nr " << i << "  wynosi " << ilosc_lit;
    }
    







    return 0;
}
