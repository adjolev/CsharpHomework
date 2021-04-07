using System;

namespace funWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a word or a phrase: ");
                string inputFromUser = Console.ReadLine();
                FunWithString(inputFromUser);
            }


        }
        static void FunWithString(string someText)
        {
            ReverseString(someText);
            Vowels(someText);
            Palindrome(someText);
            LargestWord(someText);
            SmallestWord(someText);
            CountWords(someText);
            MostUsedCharacter(someText);
        }

        static void ReverseString(string text)
        {
            char[] charsReverseString = text.ToCharArray();
            Array.Reverse(charsReverseString);
            Console.WriteLine(charsReverseString);
        }
        static void Vowels(string text)
        {
            char[] charTotalVowelsString = text.ToCharArray();
            int totalVowels = 0;
            foreach (char x in charTotalVowelsString)
            {
                if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                {
                    totalVowels++;
                }
            }
            Console.WriteLine(totalVowels);
        }
        static void Palindrome(string text)
        {
            char[] charPalindromeString = text.ToCharArray();
            Array.Reverse(charPalindromeString);
            string palindrome = string.Join("", charPalindromeString);

            if (text == palindrome)
            {
                Console.WriteLine($"{text} is palindrome");
            }
            else
            {
                Console.WriteLine($"{text} is not a palindrome");
            }
        }
        static void LargestWord(string text)
        {
            string[] textArray = text.Split(" ");
            string largestWord = "";
            foreach (string x in textArray)
            {
                if (x.Length > largestWord.Length)
                {
                    largestWord = x;
                }
            }
            Console.WriteLine(largestWord);
        }
        static void SmallestWord(string text)
        {
            string[] textArray = text.Trim().Split(" ");
            string smallestWord = null;
            foreach (string x in textArray)
            {
                if (smallestWord == null)
                {
                    smallestWord = x;
                }
                if (x.Length < smallestWord.Length)
                {
                    smallestWord = x;
                }
            }
            Console.WriteLine(smallestWord);
        }
        static void CountWords(string text)
        {
            string[] textArray = text.Trim().Split(" ");
            Console.WriteLine(textArray.Length);
        }
        static void MostUsedCharacter(string text)
        {
            string[] splittedText = text.Split(" ");
            string joinedText = string.Join("", splittedText);

            char mostUsedCharacter = '.';
            int timesCharactedUsed = 0;

            for (int i = 0; i < joinedText.Length; i++)
            {
                char character = joinedText[i];
                int characterUsed = 0;
                for (int j = 0; j < joinedText.Length; j++)
                {
                    if (character == joinedText[j])
                    {
                        characterUsed++;
                    }
                }
                if (timesCharactedUsed < characterUsed)
                {
                    mostUsedCharacter = character;
                    timesCharactedUsed = characterUsed;
                }
            }
            Console.WriteLine($"{mostUsedCharacter} is used {timesCharactedUsed} times");
        }
    }
}
