
#include <iostream>
#include <cmath>
#define M_PI 3.14159265358979323846
using namespace std;


//Deklaracje funkcji
float polekola(float r)
float polekwadratu(float &a)
float poleprostokątu(float &a, float &b)
float poletrojkata(float &a, float &h)

int main()
{
    cout << "Pola koła, kwadraty, prostokąta, trojkota\n";
	







	return 0;
}

//definiowanie funkcji

float polekola(float r)
{
	return M_PI * r * r;
}
// Przekazanie parametorw przez referencje czyli na orginale
float polekwadratu(float &a)
{
	return a * a;
}
float poleprostokątu(float& a, float& b)
{
	return a * b;
}
float poletrojkata(float& a, float& h)
{
	return (a * h) / 2;
}