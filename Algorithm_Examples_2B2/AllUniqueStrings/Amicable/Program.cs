class Program
{
    
    static int SumOfDivisors(int num)
    {
        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }
        return sum;
    }

    static void Main()
    {
        int pairCount = 0; // Bulunan çift sayı çifti sayısını takip etmek için kullanılır
        int num = 1; // İlk sayıyı 1 olarak başlatır.

        while (pairCount < 2)
        {
            int sum1 = SumOfDivisors(num); // Birinci sayının bölenlerinin toplamını hesaplar ve 'sum1' e atanır

            if (sum1 > num)
            {
                int sum2 = SumOfDivisors(sum1); // İlk toplamın (sum1) bölenlerinin toplamını hesaplar ve 'sum2' değişkenine atar.

                if (sum2 == num && num != sum1)
                {
                    // İki durum kontrol edilir: 
                    // 1. İlk sayının bölenlerinin toplamı ikinci sayıya eşitse (sum2 == num)
                    // 2. İlk sayı, ikinci sayıya eşit değilse (num != sum1)
                    // Eğer bu koşullar sağlanıyorsa, bir çift sayı çifti bulunmuş demektir.

                    Console.WriteLine($"{pairCount + 1}: {num} - {sum1}"); // Çift sayı çiftini ekrana yazdırır.
                    pairCount++; // Bulunan çift sayı çifti sayısını artırır.
                }
            }
            num++; // sonraki sayı kontrolü
        }
    }
}