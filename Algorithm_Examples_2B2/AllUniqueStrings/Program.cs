namespace AllUniqueStrings
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Bir string girin: ");
            string input = Console.ReadLine();

            if (HasUniqueCharacters(input))
            {
                Console.WriteLine("Girilen stringin tüm karakterleri benzersizdir.");
            }
            else
            {
                Console.WriteLine("Girilen stringin tüm karakterleri benzersiz değildir.");
            }
        }

        static bool HasUniqueCharacters(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return false; // Aynı karakter birden fazla kez bulundu, benzersiz değil.
                    }
                }
            }
            return true;
        }
    }
}