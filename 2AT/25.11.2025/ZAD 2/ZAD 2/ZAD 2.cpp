
#include <iostream>
#include <stack>
using namespace std;


int main()
{
    stack<string>stosslow;
    cout << "Odwrócenie kolejności slow.\n";
    int ile;
    string x;
    cout << "Podaj ilość liczb na stos : "; cin >> ile;
    for (int i = 0; i < ile; i++) {
        cin >> x;
        stosslow.push(x);
    }
    while (!stosslow.empty()) {
        cout << "Liczba na górze :" << stosslow.top() << endl;
        stosslow.pop();

    }





    return 0;
}
