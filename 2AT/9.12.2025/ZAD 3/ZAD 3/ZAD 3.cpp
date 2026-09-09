#include <iostream>
#include <vector>
using namespace std;
int main()
{
    setlocale(LC_ALL, "");
    int n;
    cout << "Podaj ilość liczb które chcesz dodać do wektora : "; cin >> n;
    vector<double> v;
    double liczba;
    double suma = 0;
    //Dodawanie liczb do wektora w pętli
    for (int i = 0; i < n; i++){
        cout << "Podaj liczbe którą chcesz włożyć do wektora : "; cin >> liczba;
        v.push_back(liczba);//Dodanie liczby do wektora
        suma += liczba;
    }
    double srednia = suma / n;
    cout << "Suma elementów wynosi = " << suma << endl;
    cout << "Średnia elementów wynosi = " << srednia;
    
    //Listowanie zawartości vectora
    for (int i = 0; i < n; i++) {
        cout << v[i] << endl;
    }


    



    return 0;
}