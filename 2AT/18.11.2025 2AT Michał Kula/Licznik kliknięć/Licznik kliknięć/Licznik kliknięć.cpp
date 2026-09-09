#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "");

	int ile;
	cout << "Podaj ilość imion.\n"; cin >> ile;
	string* tablica = new string[ile];
	string imie;
	string nazwisko;
	int dlugosc = 0;

	for (int i = 0; i < ile; i++) {

		cout << "Podaj imie nr " << i + 1 << " : " << imie; cin >> tablica[i];
		cout << "Podaj nazwisko nr " << i + 1 << " : " << nazwisko  ; cin >> tablica[i];


	}
	for (int j = 0; j < ile; j++) {
		dlugosc = sizeof(tablica) / sizeof(char);//Jak kod nie chce działać skopiować i usunąć i wstawić ponownie tą linijke.
		cout << j + 1 << ". " << tablica[j] << ". Ilość liter : "<< dlugosc << endl;
	}
	delete[] tablica;
	return 0;
}
