
#include <iostream>
#include <stack>
#include <string>
using namespace std;
int main()
{
    setlocale(LC_ALL, "");
    int ile;
    double liczba{};
    double suma = 0;
    stack<double> stosliczby;
    cout << "Podaj ilość liczb : \n"; cin >> ile;
    for (int i = 0; i < ile; i++) {
        cout << "Podaj liczbe : "; cin >> liczba;
        stosliczby.push(liczba);
    }
    while (!stosliczby.empty()) {
        suma += stosliczby.top();
        cout << stosliczby.top() << endl;
        
        
        stosliczby.pop();
        
      
    }
   /* if (liczba / 2 == 0.0) {
        cout << "Jest to liczba parzysta " << endl;
        

    }
    else {
            cout << "Nie jest to liczba parzysta " << endl;

        }*/
    
    cout << "Suma wszystkich liczb to : " << suma << endl;
    cout << "Średnia wszystkich liczb to : " << suma / ile << endl;

    

    return 0;

}

