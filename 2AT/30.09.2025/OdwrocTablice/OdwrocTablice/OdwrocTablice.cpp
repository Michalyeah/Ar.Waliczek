

#include <iostream>
using namespace std;
int main()
{
	int tablica[] = { 1, 2, 3, 4, 5, 6 ,7 ,8,15 };
	int dl = sizeof(tablica) / sizeof(tablica[0]);


    cout << "Odwracanie Tablicy\n";
	for (size_t i = 0; i < dl/2; i++)
	{
		int tymp = tablica[i];
		tablica[i] = tablica[dl - 1 - i];
		tablica[dl - 1 - i] = tymp;
		
	}
	cout << "Tablica odwrocona:\n";
	for (size_t i = 0; i < dl; i++) {
		cout << tablica[i] << " ";
	}
	



}

