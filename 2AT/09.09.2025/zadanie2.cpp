//Energia potencjalna, kinetyczna i mechniczna
#include <iostream>
#include <math.h>
using namespace std;

//ep - m * h * g
float ep(int m, int h, int g);
//ek = (mv2)/2
float ek(int m, int v);
//em = ep + ek
float em(); 



int main(){
int m, h, g, v;
cout << "Podaj parametry do obliczenia energii " << endl;
cout << "masa = ";cin >> m;
cout << "predkosc = ";cin >> v;
cout << "wusokosc = ";cin >> h;
cout << "grawitacja = ";cin >> g;

cout << "Energia kinetyczna = " << ek(m,v) << endl;
cout << "Energia potencjalna = " << ep(m,h,g) << endl;
 cout << "Energia mechaniczna = " << em(m,h,v,g) << endl;   



    return 0;
}
//ep - m * h * g
float ep(int m, int h, int g){
    return m*h*g;
}
//ek = (mv2)/2
float ek(int m, int v){
    return (m*v*v)/2;
}
//em = ep + ek
float em(int m, int h, int g, int v){
   return ek(m,v) + ep(m,h,g)
}