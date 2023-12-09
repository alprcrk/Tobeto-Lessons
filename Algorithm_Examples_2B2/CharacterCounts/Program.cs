using System;

class Program
{
    static void Main()
    {
        Console.Write("Kelimenizi girin: "); 
        string keyCount = Console.ReadLine(); // Girilen kelime keyCount a atanır

        for (int i = 0; i < keyCount.Length; i++) // Girdi kelimesinin her karakteri için bir döngü başlar.
        {
            char currentChar = keyCount[i]; // Girdi kelimesinin mevcut karakteri "currentChar" adlı bir değişkene atanır.

            if (char.IsLetter(currentChar)) // Mevcut karakter bir harf ise (alfabetik karakter), bu şart bloğu çalışır.
            {
                int count = 1; // Mevcut harf için sayacı başlatır ve 1 olarak ayarlar.

                for (int j = i + 1; j < keyCount.Length; j++) 
                {
                    if (keyCount[j] == currentChar) // Eğer mevcut karakterle aynı karakter bulunursa,
                    {
                        count++; // Sayacı artırır.
                        keyCount = keyCount.Remove(j, 1); // Aynı karakteri girdi kelimesinden kaldırır
                        j--; // j değişkenini bir azaltır; bu, bir karakter kaldırıldığında bir karakteri atlamayı engeller
                    }
                }

                Console.WriteLine($"{currentChar}: {count}"); // Her harf için tekrar sayısını ve harfi yazdırır
            }
            else 
            {
                Console.WriteLine("Lütfen sadece harf içeren kelime giriniz :d ");
                Console.WriteLine("Lütfen sadece harf içeren kelime giriniz :d ");


            }
        }
    }
}