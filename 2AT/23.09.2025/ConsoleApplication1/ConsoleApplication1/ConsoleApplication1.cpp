// Suma elementów tablicy

#include <iostream>
using namespace std;
int main()
{
    cout << "Sumowanie elementów tablicy\n";
    int tablica[] = {4,5,6,1,2,4}; //Suma 22

    //cout << tablica[0] + tablica[1] + tablica[2] + tablica[3] + tablica[4] + tablica[5] << endl;
    int suma = 0;
    for (int i = 0; i < 6; i++) {
        //cout << tablica[i] << endl;
        suma = suma + tablica[i];
    }
//pętla:
   // 1 krok
       // suma = 0 + tablica[0] = 0+ 4 = 4
  //  2 krok
    //    suma = 4 + tablica[1] = 4 + 5 = 9
   // 3 krok
      //  suma = 9 + tablica[2] = 9 + 6 = 15
   // 4 krok
  //      suma = 15 + tablica[3] = 15 + 1 = 16
  //  5 krok
    //    suma = 16 + tablica[4] = 16 + 2 = 18
   // 6 krok
     //   suma = 18 + tablica[5] = 18 + 4 = 22
     



    cout << suma;









    return 0;
}

