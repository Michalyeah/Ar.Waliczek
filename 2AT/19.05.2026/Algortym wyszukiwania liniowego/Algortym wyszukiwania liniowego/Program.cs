int[] tablica = { 2, 4, 6, 8, 10, 12, 14 };
int szukana = 10;


int indeks = Array.BinarySearch(tablica, szukana);

if (indeks >= 0)
    Console.WriteLine($"Znaleziono na indeksie: {indeks}");
else
    Console.WriteLine("Element nie istnieje w tablicy.");

 static int BinarySearch(int[] arr, int target)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left <= right)
    {
      
        int middle = left + (right - left) / 2;

     
        if (arr[middle] == target)
            return middle;

        
        if (arr[middle] > target)
            right = middle - 1;
       
        else
            left = middle + 1;
    }

    
    return -1;
}