
#include <iostream>
#include <stack>
#include <string>
using namespace std;


int main()
{
    setlocale(LC_ALL, "");
    int ile;
    int liczba;
    int suma = 0;
    stack<int> liczby;
    cout << "Podaj ilość liczb : \n"; cin >> ile;
    for (int i = 0; i < ile; i++) {
        cout << "Podaj liczbe : "; cin >> liczba;
        liczby.push(liczba);
    }
    while (!liczby.empty()) {
        suma += liczby.top();
        liczby.pop();
    }
    cout << "Suma : " << suma << endl;
    cout << "Średnia liczb to : " << (suma / ile);



    return 0;
}
