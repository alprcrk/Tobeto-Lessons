using System;

class Program
{
    static void Main()
    {
        int count = 0; // Başlangıçta, mükemmel sayı sayacı 0 olarak ayarlanır.
        int p = 2;     // İlk Mersenne asal sayısının p değeri 2'den başlar.

        while (count < 8)
        {
            

            if (IsMersennePrime(p))
            {
                // Eğer p bir Mersenne asal sayısıysa, bu blok çalışır.

                long mersenneNumber = (long)Math.Pow(2, p) - 1; // Mersenne sayısı hesaplanır.
                long perfectNumber = (long)Math.Pow(2, p - 1) * mersenneNumber; // Mükemmel sayı hesaplanır.

                // Hesaplanan mükemmel sayı ekrana yazdırılır.
                Console.WriteLine($"Perfect Number {count + 1}: {perfectNumber}");
                count++; // Mükemmel sayı sayacı artırılır.
            }

            p++; // Bir sonraki p değerini kontrol etmek için p artırılır.
        }
    }


    static bool IsMersennePrime(int p)
    {
        
        if (p < 2)
            return false;

        // Mersenne asal hesaplama adımı: 2^p - 1
        long potentialMersennePrime = (long)Math.Pow(2, p) - 1;

        
        if (IsPrime(potentialMersennePrime))
            return true; 

        
        return false;
    }


    static bool IsPrime(long number)
    {
        
        if (number <= 1)
            return false;

        
        if (number <= 3)
            return true;

        
        if (number % 2 == 0 || number % 3 == 0)
            return false;

        // 5'ten başlayarak büyük bölenleri kontrol etmek için bir döngü başlatılır
        for (long i = 5; i * i <= number; i += 6)
        {
            // Sayı i veya i + 2'ye bölünebiliyorsa, asal değil
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        // bölen yoksa sayı asal
        return true;

    }
}    
