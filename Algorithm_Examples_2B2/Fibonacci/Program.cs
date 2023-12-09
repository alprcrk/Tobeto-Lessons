using System;

class Program
{
    static void Main()
    {
        int number = 100;  // Hesaplanacak Fibonacci sayısı
        double number1 = 0;  
        double number2 = 1;  

        Console.WriteLine(number + " " + "Fibonnaci");  // hesaplanan Fibonacci dizisinin eleman sayısı

        for (int i = 0; i < number; i++) 
        {
            Console.WriteLine(number1);  

            double next = number1 + number2;  // Bir sonraki Fibonacci terimi hesaplanır ve 'next' değişkenine atanır

            number1 = number2;  // 'number1', 'number2' değerine atanır
            number2 = next;  // 'number2', bir sonraki terim olan 'next' değerine atanır
        }
        
    }
}