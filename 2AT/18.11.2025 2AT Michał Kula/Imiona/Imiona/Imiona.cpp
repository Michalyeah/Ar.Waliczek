
#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "");

	int ile;
	cout << "Podaj ilość imion.\n"; cin >> ile;
	string* tablica = new string[ile];
	string imie;
	int dlugosc = 0;
	for (int i = 0; i < ile; i++) {
		
		cout << "Podaj imie nr " << i +1 << " : " << endl; cin >> tablica[i];
		

	}
	for (int j = 0; j < ile; j++) {
		cout << j +1 <<". " << tablica[j] << ". Ilość liter : " << sizeof(imie)/sizeof(char) << endl;
	}
	delete[] tablica;
	return 0;
}

