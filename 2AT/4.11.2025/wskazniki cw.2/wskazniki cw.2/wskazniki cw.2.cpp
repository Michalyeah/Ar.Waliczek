
#include <iostream>
using namespace std;
int main()
{
    int tablica[5] = { 3,5,7,9,1 };
    cout << "Wskazniki cw.2 !\n";

    cout <<"&tablica =" << (int) & tablica << endl;
    cout << "&tablica =" << (int) & tablica[0] << endl;
    cout << "&tablica =" << (int)&tablica[1] << endl;
    cout << "&tablica =" << (int)&tablica[2] << endl;
    cout << "&tablica =" << (int)&tablica[3] << endl;
    cout << "&tablica =" << (int)&tablica[4] << endl;






    int* wsk;
    wsk = &tablica[0];
    //przesuń o 2 x 4 bajty
    cout << "Przesuniecie o 2x4bajty = " << (int)(wsk += 2) << endl;
    cout << "Przesuniecie o 2x4bajty = " << (int)(wsk += 2) << endl;
    cout << "Przesuniecie o 2x4bajty = " << (int)(wsk += 2) << endl;
    cout << "Przesuniecie o 2x4bajty = " << (int)(wsk += 2) << endl;

    int a = 10;
    cout <<(int) & a << endl;
    return 0;
}


