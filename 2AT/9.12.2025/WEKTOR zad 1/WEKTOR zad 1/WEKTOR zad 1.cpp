
#include <iostream>
#include <vector>
using namespace std;
int main()
{
    cout << "Wektor\n";
    vector<int> v;

    v.push_back(10);
    v.push_back(20);
    v.push_back(50);

    cout << v.front() << endl;//wynik 10
    v.erase(v.begin());//usuwanie pierwszej wartości  "10"
    cout << v.front() << endl;//wynik 20
    cout << v[0] << " " << v[1] << endl;//pokazuje, że mogę iterować po vectorze
    


    return 0;
}
