

#include <iostream>
using namespace std;
int main()
{
    cout << "Sortowanie babelkowe\n";
    int tablica[] = { 28, 3, 55, 12, 5, 6, 7, 2,1 };
    // O(n2) -> złożoność algorytmu: z. czasowej i z. pamięciowej
	int dl = sizeof(tablica) / sizeof(tablica[0]);
    for (size_t i = 0; i < dl - 1; i++)
    {

        for (int j = 0; j < dl - i - 1; j++) {
            if (tablica[j] > tablica[j + 1]) {
                /*
                int temp = tablica[j];
                tablica[j] = tablica[j + 1];
                tablica[j + 1] = temp;
                */
				swap(tablica[j], tablica[j + 1]);
            }
        
        
        }
    }
    cout << "Posortowana tablica: ";
    for(size_t i = 0; i < dl; i++)
    {
        cout << tablica[i] << " ";
	}

    return 0;
}

