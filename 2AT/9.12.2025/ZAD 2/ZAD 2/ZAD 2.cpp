#include <iostream>
#include <vector>
using namespace std;
int main()
{
    //vector<int, string> v1;  Nie działa nie istnieje 
    //v1[0] = 1,"Arkadiusz";

    vector<pair<int, string>> v1;
    v1.push_back({ 49, "Arkadiusz" });
    cout << v1[0].first << v1[0].second << endl;


    cout << "Wektor\n";
    // to są 2 vectory
    pair<int, int> a = { 3, 2 };
    pair<int, int> b = { -1, 4 };


    pair<int, int> c;

    c.first = a.first + b.first;
    c.second = a.second + b.second;
    

    cout << "Vector c = a + b = ( " << c.first << " , " << c.second << " )";
      



    return 0;
}