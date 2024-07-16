using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir metin giriniz:");

        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            CharacterSwapper swapper = new CharacterSwapper();
            string result = swapper.SwapAdjacentCharacters(input);

            Console.WriteLine(result);
        }
    }
}

