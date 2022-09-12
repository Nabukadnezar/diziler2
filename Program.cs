// See https://aka.ms/new-console-template for more information

// Sort
int[] sayiDizisi = {23,12,4,96,72,3,11,17};

Console.WriteLine("**** Sırasız Dizi ****");
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

Console.WriteLine("**** Sıralı Dizi ****");

Array.Sort(sayiDizisi);

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//Clear
Console.WriteLine("**** Array Clear ****");
Array.Clear(sayiDizisi, 2, 2);

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//Reverse
Console.WriteLine("**** Array Reverse ****");
Array.Reverse(sayiDizisi);

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//indexof
Console.WriteLine("**** Array indexof ****");
Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

//Resize
Console.WriteLine("**** Array resize ****");
Array.Resize<int>(ref sayiDizisi, 9);
sayiDizisi[8] = 99;

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);


//Candle

List<int> candles = new List<int> {3, 2, 1, 3};
int[] sortedCandles = candles.ToArray();
Array.Sort(sortedCandles);
Array.Reverse(sortedCandles);
int tallestCandle = sortedCandles[0];
int tallCandleCount = 0;
Console.WriteLine(string.Join(",", sortedCandles));

foreach (var candle in sortedCandles)
        {
            if (candle == tallestCandle)
            {
               tallCandleCount++; 
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(tallCandleCount);

