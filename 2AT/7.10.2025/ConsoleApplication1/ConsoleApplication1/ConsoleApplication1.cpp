

#include <iostream>
using namespace std;
int main()

{

    
    /*
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
          cout << "#";
        }
        cout<<"\n";

    }
    cout << "ZAD\n";

    for (int o = 0; o < 5; o++) {
        for (int l = 0; l < o; l++) {
            cout << "?";

        }
        cout << "" << endl;

    }
    cout << "ZAD"<< endl*/

    int u = 2;
    for (int i = 0; i < 5; i++) {
        i++;

        for (int o = 0; o < i; o++) {


            for (int p = u; p > 0; p--) {
                cout << " ";
            };

            u--;
            cout << "$";
        };
        cout << endl;
    }







return 0;
}


