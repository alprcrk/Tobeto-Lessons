internal class ArmstrongNumberChecker
{
    private static void Main()
    {
        Console.WriteLine("Enter a number: "); 
        var number = int.Parse(Console.ReadLine()); // girilen sayı number a atanır

        if (IsArmstrongNumber(number)) 
            Console.WriteLine(number + " Girilen sayı Armstrong sayıdır"); 
        else
            Console.WriteLine(number + " Girilen sayı Armstrong sayı değildir"); 
    }

    private static bool IsArmstrongNumber(int number)
    {
        var originalNumber = number; // girilen sayının yedeği alınır
        var numDigits = (int)Math.Floor(Math.Log10(number)) + 1; // basamak sayısı hesabı --> 3
        var sum = 0; // Armstrong sayısını hesaplarken kullanılmak üzere toplam değişkeni oluşturulur 

        while (number > 0)
        {
            var digit = number % 10; // Sayının son basamağı alınır
            sum += (int)Math.Pow(digit, numDigits); // Basamağın numDigits üssü hesaplanır ve sum'a eklenir
            number /= 10; // Sayının son basamağı çıkarılarak bir sonraki basamağa geçilir.
        }

        return sum == originalNumber; // Hesaplanan 'sum' değeri, orijinal sayıya eşitse, sayı bir Armstrong sayısıdır.
    }
}