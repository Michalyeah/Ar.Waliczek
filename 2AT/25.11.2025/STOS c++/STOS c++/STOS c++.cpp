//Wczytaj n liczb całkowitych, umieść je na stosie, anestępnie wypisz w odwrotnej
// kolejności
#include <iostream>
#include <stack>
using namespace std;


int main()
{
    stack<int> stosliczb;
    cout << "Odwrócenie kolejności liczby.\n";
    int ile, x;
    cout << "Podaj ilość liczb na stos : "; cin >> ile;
    for (int i = 0; i < ile; i++) {
        cin >> x;
        stosliczb.push(x);
    }
    while (!stosliczb.empty()) {
        cout <<"Liczba na górze :" << stosliczb.top() << endl;
        stosliczb.pop();

    }
    
    



    return 0;
}

