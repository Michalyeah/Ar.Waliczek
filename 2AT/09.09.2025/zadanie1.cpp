//Ladowanie bibliotek
#include <iostream>
#include <math.h>
//Przestrzeń nazw
using namespace std;

float dodawanie(float liczba1, float liczba2);
float odejmowanie(float liczba1, float liczba2);
float mnożenie(float liczba1, float liczba2);
float dzielenie(float liczba1, float liczba2);
float potegowanie(float liczba1, float liczba2);
float pierwiastkowanie1(float liczba1);
float pierwiastkowanie2(float liczba2);

int main()
{
    cout << "Kalkulator version 1.0" << endl;

    int liczba1,liczba2;

    cout << "Podaj liczbe1: "; cin >> liczba1;
    cout << "Podaj liczbe2: "; cin >> liczba2;

    cout << "Dodawanie: " << dodawanie(liczba1,liczba2) << endl;
    cout << "Odejmowanie: " << odejmowanie(liczba1,liczba2) << endl;
    cout << "Mnożenie: " << mnożenie(liczba1,liczba2) << endl;
    cout << "Dzielenie: " << dzielenie(liczba1,liczba2) << endl;
    cout << "Potęgowanie: " << potegowanie(liczba1,liczba2) << endl;
    cout << "Pierwiastkowanie1 : " << pierwiastkowanie1(liczba1) << endl;
    cout << "Pierwiastkowanie2 : " << pierwiastkowanie2(liczba2) << endl;
    


    return 0;
}
//Definicja funkcji
float dodawanie(float liczba1, float liczba2){
    return liczba1 + liczba2;
}
float odejmowanie(float liczba1, float liczba2){
    return liczba1 - liczba2;
}
float mnożenie(float liczba1, float liczba2){
    return liczba1 * liczba2;
}
float dzielenie(float liczba1, float liczba2){
    if(liczba2>0){
         return liczba1 / liczba2;
        }
    else{
        return 0;
    }
}
float potegowanie(float liczba1, float liczba2){
    return pow(liczba1,liczba2);
}
float pierwiastkowanie1(float liczba1){
    return sqrt(liczba1);
}
float pierwiastkowanie2(float liczba2){
    return sqrt(liczba2);
}
