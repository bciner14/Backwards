public class CharacterSwapper
{
    public string SwapAdjacentCharacters(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 2)
        {
            return input;
        }

        char[] charArray = input.ToCharArray();
        for (int i = 0; i < charArray.Length - 1; i += 2)
        {
            char temp = charArray[i];
            charArray[i] = charArray[i + 1];
            charArray[i + 1] = temp;
        }
        return new string(charArray);
    }
}
