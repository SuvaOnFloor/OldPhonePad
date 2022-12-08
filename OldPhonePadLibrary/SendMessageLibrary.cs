using OldPhonePadLibrary.Constants;

namespace OldPhonePadLibrary;
public static class SendMessageLibrary
{
    public static String OldPhonePad(string input)
    {
        if (!input.Contains(Key.HASH))
            throw new ArgumentException(ExceptionMessage.INVALID_STRING);

        if (input.Length == 1 && input[0] == Key.HASH)
            return String.Empty;


        var message = String.Empty;
        var previousChar = input[0];
        var pressCount = 1;

        for (int currentChar = 1; currentChar < input.Length; currentChar++)
        {
            if (previousChar == input[currentChar])
                pressCount++;
            else
            {
                message += KeyMap.GetCharFromKeys(previousChar, pressCount);

                if (input[currentChar] == Key.HASH)
                    return message;

                if (input[currentChar] == Key.STAR)
                {
                    message = message[..^1];
                    pressCount = 1;
                    previousChar = Key.SPACE;
                    continue;
                }

                previousChar = input[currentChar];
                pressCount = 1;
            }
        }
        return message;

    }

}
