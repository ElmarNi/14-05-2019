using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input your sentence");
            string userSentence = Console.ReadLine();
            Console.WriteLine(SpacesofUserSentence(userSentence));
            Console.WriteLine("Press any key for average of numbers");
            Console.ReadKey();
            Console.WriteLine(AverageOfNumbers(150, 2, 1, 0, 0));
            Console.WriteLine("Press any key for find a even numbers");
            Console.ReadKey();
            Console.WriteLine(EvenNumbers(150, 2, 1, 0, 0));
            Console.WriteLine("Press any key for find power");
            Console.ReadKey();
            Console.WriteLine(PowerOfNumber(3,3));
            Console.WriteLine("Press any key for find longest word");
            Console.ReadKey();
            Console.WriteLine(LongestWord("salam", "necesen", "men"));
            Console.WriteLine("Press any key for join words");
            Console.ReadKey();
            Console.WriteLine(JoinWords("salam", "necesen"));
        }
        #region space counter
        static string SpacesofUserSentence(string sentence)
        {
            var spaceCount = 0;
            foreach (var item in sentence)
            {
                if (item == ' ')
                {
                    spaceCount++;
                }
            }
            return $"Number of spaces {spaceCount}";
        }
        #endregion
        #region Average of numbers
        static string AverageOfNumbers(params int[] numbers)
        {
            int avgNumbers = 0;
            int greaterNum = 0;
            foreach (var item in numbers)
            {
                avgNumbers = avgNumbers + item;
            }
            avgNumbers = avgNumbers / numbers.Length;
            foreach (var item in numbers)
            {
                if (item > avgNumbers)
                {
                    greaterNum = item;
                }
            }
            if (greaterNum == 0)
            {
                Console.WriteLine("All numbers less than AVG");
                return $"Average of your numbers: {avgNumbers}";
            }
            return $"Average of your numbers: {avgNumbers} and Greater number from avg is: {greaterNum}";
        }
        #endregion
        #region Even numbers
        static string EvenNumbers(params int[] numbers)
        {
            StringBuilder numbersArr = new StringBuilder();

            foreach (var item in numbers)
            {
                if (item % 2 == 0 && item != 0)
                    numbersArr.Append(item + " ");
            }
            return $"Even numbers: {numbersArr}";
        }
        #endregion
        #region Power of number
        static string PowerOfNumber(int number, int power)
        {
            int poweredNumber = 1;
            for (int i = 0; i < power; i++)
            {
                poweredNumber = poweredNumber * number;
            }
            return $"{poweredNumber}";
        }
        #endregion
        #region Longest word of arr
        static string LongestWord(params string[] words)
        {
            string longestword = " ";
            foreach (var item in words)
            {
                if (item.Length > longestword.Length)
                {
                    longestword = item;
                }
            }
            return $"Longest word is: {longestword}";
        }
        #endregion
        #region Join words from arr
        static string JoinWords(params string[] words)
        {
            StringBuilder word = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                if (i == words.Length - 1)
                {
                    word.Append(words[i]);
                }
                else
                {
                    word.Append(words[i] + ", ");
                }
            }
            return $"{word}";
        }
        #endregion
    }
}
