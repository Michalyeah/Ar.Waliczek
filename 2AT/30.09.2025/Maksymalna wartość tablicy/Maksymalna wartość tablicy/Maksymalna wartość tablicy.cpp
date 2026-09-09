

#include <iostream>
using namespace std;
int main()
{ 
    
    cout << "Max wartosc tablicy\n";
    int tablica[] = { 10, 20, 30,3, 40, 5, 18 };
    int max = tablica[0];
	int dl = sizeof(tablica) / sizeof(tablica[0]);
    for (size_t i = 0; i < dl; i++)
    {
        if (tablica[i] > max)
            max = tablica[i];
	}
    
	cout << "Max wartosc tablicy to: " << max << endl;





    
}

