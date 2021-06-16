using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string charorder = Console.ReadLine();

            int random = 0;
            int deck = 0;

            while (word != "" && random < 10)
            {
                int dollface = word.Length;
                word = word.Replace(charorder[deck].ToString(), "");
                if (dollface == word.Length)
                    random += 1;
                deck += 1;
            }

            if (word == "")
                Console.WriteLine("WIN");
            else
                Console.WriteLine("LOSE");
        }

    }
}

