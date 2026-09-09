#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "");

	int ile;
	cout << "Podaj ilość ocen. \n"; cin >> ile;
	float* tablica = new float[ile];
	

	for (int i = 0; i < ile ; i++) {

		cout << "Podaj ocene " << i + 1 << " : " << endl; cin >> tablica[i];//Jęśli nie działa skopiuj cin tablica i wklej ponownie


	}
	double suma = 0;
	for (int j = 0; j < ile; j++) {
		suma += tablica[j];
		
	}
	cout << "Średnia ocen wynosi = " <<(int) suma /(int) ile << endl;
	delete[] tablica;
	return 0;
}