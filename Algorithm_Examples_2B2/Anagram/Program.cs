using System;
namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();



            if (AreAnagrams(word1, word2))
            {
                Console.WriteLine($"{word1} ve {word2} anagramdır.");
            }
            else
            {
                Console.WriteLine($"{word1} ve {word2} anagram değildir.");

            }
        }

        static bool AreAnagrams(string word1, string word2)
        {

            char[] charArray1 = word1.ToLower().ToCharArray();
            char[] charArray2 = word2.ToLower().ToCharArray();

            Array.Sort( charArray1);
            Array.Sort(charArray2);

            return new string(charArray1)==new string(charArray2);
        }
    }
}